using Ardalis.GuardClauses;
using Cheetah.Application.Business.Condition.Get;
using System.Linq;

namespace Cheetah.Infrastructure.Persistence.Services;

public class Sync(ApplicationDbContext _db, ISender _ISender) : ISync
{
    public async Task<Result<SimpleClassDTO>> SyncLinkAsync(SimpleClassDTO Base, IEnumerable<SimpleLinkClassDTO> Records, CrudOperation Crud)
    {
        _ = Records.Select(x => Guard.Against.Null(x.ERPCode, $"Id of {x.Name} can not be null"));

        var _IsRead = (Crud is CrudOperation.Read);

        if (Crud == CrudOperation.Create || _IsRead)
        {
            if (Base.Name == nameof(L_UserCondition))
            {
                var _AllUserConditions = await _db.L_UserConditions
                    .Select(item => new SimpleLinkClassDTO()
                    {
                        FirstId = item.FirstId,
                        SecondId = item.SecondId
                    })
                    .ToListAsync();

                var _MostBeAdd = Records.Where(x => !_AllUserConditions
                .Where(y => y.FirstId == x.FirstId)
                .Where(y => y.SecondId == x.SecondId)
                .Any());

                await _db.L_UserConditions.AddRangeAsync(_MostBeAdd.Select(
                    item => new L_UserCondition()
                    {
                        Name = item.Name,
                        DisplayName = item.DisplayName,
                        ERPCode = item.ERPCode,
                        FirstId = item.FirstId,
                        SecondId = item.SecondId
                    }));
                await _db.SaveChangesAsync();
            }
        }
        if (Crud == CrudOperation.Delete || _IsRead)
        {
            var _FilterdRecords = Records.Where(y => !y.EnableRecord).Select(y => y.ERPCode);

            if (Base.Name == nameof(L_UserCondition))
            {
                _ = await _db.L_UserConditions
                    .Where(x => _FilterdRecords.Contains(x.ERPCode))
                    .ExecuteUpdateAsync(setters => setters.SetProperty(field => field.EnableRecord, false));

            }
        }

        return Base;
    }
    public async Task<Result<SimpleClassDTO>> SyncConditionAsync(SimpleClassDTO Base, IEnumerable<F_Condition> Records, CrudOperation Crud)
    {
        _ = Records.Select(x => Guard.Against.Null(x.ERPCode, $"Id of {x.Name} can not be null"));

        var _IsRead = (Crud is CrudOperation.Read);

        if (Crud == CrudOperation.Create || _IsRead)
        {
            if (Base.Name == nameof(F_Condition))
            {
                var _AllConditionsERPCode = await _db.F_Conditions.Select(x => x.ERPCode).ToListAsync();

                var _MostBeAdd = Records.Where(x => !_AllConditionsERPCode.Contains(x.ERPCode));

                foreach (var _condition in _MostBeAdd)
                {
                    var _getCondition = await _ISender.Send(new CopyConditionQuery(_condition));
                    await _db.F_Conditions.AddAsync(_getCondition);
                }
            }
            await _db.SaveChangesAsync();
        }
        if (Crud == CrudOperation.Update || _IsRead)
        {
            if (Base.Name == nameof(F_Condition))
            {
                foreach (var Record in Records)
                {
                    var _exist = await _db.F_Conditions
                        .Where(x => x.ERPCode == Record.ERPCode)
                        .SingleOrDefaultAsync();

                    if (_exist is not null)
                    {
                        _exist.Name = Record.Name;
                        _exist.DisplayName = Record.Name;
                        _exist.Description = Record.Description;
                        _exist.EnableRecord = Record.EnableRecord;
                        _db.F_Conditions.Update(_exist);
                    }
                }
            }
            await _db.SaveChangesAsync();
        }
        if (Crud == CrudOperation.Delete || _IsRead)
        {
            var _FilterdRecords = Records.Where(y => !y.EnableRecord).Select(y => y.ERPCode);
            _ = await _db.F_Conditions
                .Where(x => _FilterdRecords.Contains(x.ERPCode))
                .ExecuteUpdateAsync(setters => setters.SetProperty(field => field.EnableRecord, false));
        }
        return Base;
    }

    #region SyncEntityAsync
    public async Task<Result<SimpleClassDTO>> SyncEntityAsync(SimpleClassDTO Base, IEnumerable<SimpleClassDTO> Records, CrudOperation Crud)
    {
        _ = Records.Select(x => Guard.Against.Null(x.ERPCode, $"Id of {x.Name} can not be null"));

        var _IsRead = (Crud is CrudOperation.Read);

        if (Crud == CrudOperation.Create || _IsRead)
        {
            _ = await SyncEntityCreateAsync(Base, Records);
        }
        if (Crud == CrudOperation.Update || _IsRead)
        {
            _ = await SyncEntityUpdateAsync(Base, Records);
        }
        if (Crud == CrudOperation.Delete || _IsRead)
        {
            _ = await SyncEntityDeleteAsync(Base, Records);
        }
        return Base;
    }
    public async Task<Result<SimpleClassDTO>> SyncEntityCreateAsync(SimpleClassDTO Base, IEnumerable<SimpleClassDTO> Records)
    {
        if (Base.Name == nameof(D_User))
        {
            var _AllUsersERPCode = await _db.D_Users.Select(x => x.ERPCode).ToListAsync();

            var _MostBeAdd = Records.Where(x => !_AllUsersERPCode.Any(y => y == x.ERPCode));

            if (_MostBeAdd.Any())
            {
                await _db.D_Users.AddRangeAsync(
                    _MostBeAdd.Select(
                    item => new D_User()
                    {
                        Name = item.Name,
                        DisplayName = item.DisplayName,
                        ERPCode = item.ERPCode
                    }));
            }
        }
        else if (Base.Name == nameof(D_Tag))
        {
            var _AllTagsERPCode = await _db.D_Tags.Select(x => x.ERPCode).ToListAsync();

            var _MostBeAdd = Records.Where(x => !_AllTagsERPCode.Any(y => y == x.ERPCode));

            if (_MostBeAdd.Any())
            {
                await _db.D_Tags.AddRangeAsync(_MostBeAdd.Select(
                item => new D_Tag()
                {
                    Name = item.Name,
                    DisplayName = item.DisplayName,
                    ERPCode = item.ERPCode
                }));
            }
        }
        await _db.SaveChangesAsync();
        return Base;
    }
    public async Task<Result<SimpleClassDTO>> SyncEntityUpdateAsync(SimpleClassDTO Base, IEnumerable<SimpleClassDTO> Records)
    {
        if (Base.Name == nameof(D_User))
        {
            var _users = await _db.D_Users
                .Where(x => Records.Select(y => y.ERPCode).Contains(x.ERPCode))
                .AsNoTracking()
                .ToListAsync();

            foreach (var user in _users)
            {
                var _Record = Records.Where(x => x.ERPCode == user.ERPCode).Single();

                user.Name = _Record.Name;
                user.DisplayName = _Record.DisplayName;
                user.Description = _Record.Description;
                user.EnableRecord = _Record.EnableRecord;
                _db.D_Users.Update(user);
            }
        }
        else if (Base.Name == nameof(D_Tag))
        {
            var _tags = await _db.D_Tags
                .Where(x => Records.Select(y => y.ERPCode).Contains(x.ERPCode))
                .AsNoTracking()
                .ToListAsync();

            foreach (var _tag in _tags)
            {
                var _Record = Records.Where(x => x.ERPCode == _tag.ERPCode).Single();

                _tag.Name = _Record.Name;
                _tag.DisplayName = _Record.DisplayName;
                _tag.Description = _Record.Description;
                _tag.EnableRecord = _Record.EnableRecord;
                _db.D_Tags.Update(_tag);
            }
        }
        await _db.SaveChangesAsync();
        return Base;
    }
    public async Task<Result<SimpleClassDTO>> SyncEntityDeleteAsync(SimpleClassDTO Base, IEnumerable<SimpleClassDTO> Records)
    {
        var _FilterdRecords = Records.Where(y => !y.EnableRecord).Select(y => y.ERPCode);

        if (Base.Name == nameof(D_User))
        {
            _ = await _db.D_Users
                .Where(x => _FilterdRecords.Contains(x.ERPCode))
                .ExecuteUpdateAsync(setters => setters.SetProperty(field => field.EnableRecord, false));
        }
        else if (Base.Name == nameof(D_Tag))
        {
            _ = await _db.D_Tags
                  .Where(x => _FilterdRecords.Contains(x.ERPCode))
                  .ExecuteUpdateAsync(setters => setters.SetProperty(field => field.EnableRecord, false));
        }
        return Base;
    }
    #endregion
}
