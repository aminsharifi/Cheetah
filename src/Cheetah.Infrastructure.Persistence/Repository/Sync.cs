using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Links;

namespace Cheetah.Infrastructure.Persistence.Repository;
public class Sync(ApplicationDbContext _db, ITableCRUD _itableCRUD) : ISync
{
    public async Task<D_User> GetUser(D_User v_Creator)
    {
        var Cheetah_User = _db.D_Users.Where(x => x.Name == v_Creator.Name);

        D_User SelectedUser = new D_User();

        if (Cheetah_User is null)
        {
            SelectedUser = new D_User()
            {
                ERPCode = v_Creator.ERPCode,
                Name = v_Creator.Name,
                DisplayName = v_Creator.DisplayName,
                EnableRecord = v_Creator.EnableRecord,
                LastModified = DateTime.Now
            };

            if (v_Creator.Parent is not null)
            {
                SelectedUser.Parent = await GetUser(v_Creator.Parent);
            }

            await _db.D_Users.AddAsync(SelectedUser);

            await _db.SaveChangesAsync();
        }
        else
        {
            SelectedUser = await Cheetah_User.Include(x => x.Parent).SingleAsync();

            if (SelectedUser.LastModified < DateTime.Now.AddMinutes(-10))
            {
                var changed = false;

                if (SelectedUser.DisplayName != v_Creator.DisplayName)
                {
                    SelectedUser.DisplayName = v_Creator.DisplayName;
                    changed = true;
                }

                if (SelectedUser.EnableRecord != v_Creator.EnableRecord)
                {
                    SelectedUser.EnableRecord = v_Creator.EnableRecord;
                    changed = true;
                }

                if (v_Creator.Parent is not null)
                {
                    if (SelectedUser.Parent is null || SelectedUser.Parent?.Name != v_Creator.Parent.Name)
                    {
                        SelectedUser.Parent = await GetUser(v_Creator.Parent);

                        changed = true;
                    }
                }

                SelectedUser.LastModified = DateTime.Now;

                if (changed)
                {
                    await _db.SaveChangesAsync();
                }
            }
        }

        return SelectedUser;
    }
    public async Task<bool> SyncUser(IEnumerable<D_User> Users)
    {
        foreach (var item in Users)
        {
            await GetUser(item);
        }
        return true;
    }
    public async Task<D_Position> GetPosition(D_Position v_Position)
    {
        var D_Positions = await _db.D_Positions
            .Where(x => x.Name == v_Position.Name).SingleOrDefaultAsync();

        var _d_Position = new D_Position();

        if (D_Positions is null)
        {
            _d_Position = new D_Position()
            {
                ERPCode = v_Position.ERPCode,
                Name = v_Position.Name,
                DisplayName = v_Position.DisplayName,
                LastModified = DateTime.Now
            };

            await _db.D_Positions.AddAsync(_d_Position);
        }
        else
        {
            _d_Position = D_Positions;
            _d_Position.Name = v_Position.Name;
            _d_Position.DisplayName = v_Position.DisplayName;
        }
        await _db.SaveChangesAsync();

        return _d_Position;
    }
    public async Task<bool> SyncPosition(IEnumerable<D_Position> V_Positions)
    {
        foreach (var item in V_Positions)
        {
            await GetPosition(item);
        }
        return true;
    }
    public async Task<D_Location> GetLocation(D_Location V_Location)
    {
        var D_Positions = await _itableCRUD.Get(nameof(D_Location), V_Location.Name) as D_Location;

        var _d_Location = new D_Location();

        if (D_Positions is null)
        {
            _d_Location = new D_Location()
            {
                ERPCode = V_Location.ERPCode,
                Name = V_Location.Name,
                DisplayName = V_Location.DisplayName,
                LastModified = DateTime.Now
            };

            await _db.D_Locations.AddAsync(_d_Location);
        }
        else
        {
            _d_Location = D_Positions;
            _d_Location.Name = V_Location.Name;
            _d_Location.DisplayName = V_Location.DisplayName;
        }
        await _db.SaveChangesAsync();

        return _d_Location;
    }
    public async Task<bool> SyncLocation(IEnumerable<D_Location> v_Locations)
    {
        foreach (var item in v_Locations)
        {
            await GetLocation(item);
        }

        return true;
    }
    public async Task<bool> Sync_UserPosition(IEnumerable<L_UserPosition> v_UserPositions)
    {
        var d_Users = await _db.D_Users.ToListAsync();
        var d_Positions = await _db.D_Positions.ToListAsync();

        foreach (var item in v_UserPositions)
        {
            var users = d_Users.Where(x => x.ERPCode == item.FirstId);
            var positions = d_Positions.Where(x => x.ERPCode == item.SecondId);

            var MustAdd = true;

            if (!users.Any())
            {
                MustAdd = false;
            }

            if (!positions.Any())
            {
                MustAdd = false;
            }
            if (MustAdd)
            {
                var user = users.Single();
                var position = positions.Single();

                MustAdd = !await _db.L_UserPositions.AnyAsync(x => x.FirstId == user.Id && x.SecondId == position.Id);

                if (MustAdd)
                {
                    var l_UserPosition = new L_UserPosition()
                    {
                        FirstId = user.Id,
                        SecondId = position.Id,
                        Name = user.Name + "-" + position.Name,
                        DisplayName = user.DisplayName + "-" + position.DisplayName,
                        EnableRecord = item.EnableRecord,
                        LastModified = DateTime.Now
                    };
                    await _db.L_UserPositions.AddAsync(l_UserPosition);
                }
            }
        }

        await _db.SaveChangesAsync();

        return true;
    }
    public async Task<bool> Sync_UserLocation(IEnumerable<L_UserLocation> v_UserLocations)
    {
        var d_Users = await _db.D_Users.ToListAsync();
        var d_Locations = await _db.D_Locations.ToListAsync();

        foreach (var item in v_UserLocations)
        {
            var d_User = d_Users.Where(x => x.ERPCode == item.FirstId);
            var d_Location = d_Locations.Where(x => x.ERPCode == item.SecondId);

            var MustAdd = true;

            if (!d_User.Any())
            {
                MustAdd = false;
            }
            if (!d_Location.Any())
            {
                MustAdd = false;
            }

            if (MustAdd)
            {
                var user = d_User.Single();

                var location = d_Location.Single();

                MustAdd = !await _db.L_UserLocations
                    .AnyAsync(x => x.FirstId == user.Id && x.SecondId == location.Id);

                if (MustAdd)
                {
                    var l_UserLocation = new L_UserLocation()
                    {
                        FirstId = user.Id,
                        SecondId = location.Id,
                        Name = user.Name + "-" + location.Name,
                        DisplayName = user.DisplayName + "-" + location.DisplayName,
                        EnableRecord = item.EnableRecord,
                        LastModified = DateTime.Now
                    };
                    await _db.L_UserLocations.AddAsync(l_UserLocation);
                }
            }
        }

        await _db.SaveChangesAsync();

        return true;
    }
}