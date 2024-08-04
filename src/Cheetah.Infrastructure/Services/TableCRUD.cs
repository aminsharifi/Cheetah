using Cheetah.Core.Common;
using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Enums;
using Cheetah.Core.Interfaces;
using Cheetah.Core.Entities.Dimentions;
using Cheetah.Infrastructure.Data;

namespace Cheetah.Infrastructure.Services;

public class TableCRUD(ApplicationDbContext _db) : ITableCRUD
{
    public async Task<int> AddLink(BaseLink obj_DTO)
    {
        await _db.AddAsync(obj_DTO);

        return 1;
    }
    public BaseLink AddLinkName(BaseLink simpleLinkClass,
        BaseEntity? firstClass, BaseEntity? SecondClass)
    {
        var _name = new StringBuilder()
            .Append(firstClass?.Name ?? string.Empty)
            .Append("-")
            .Append(SecondClass?.Name ?? string.Empty)
            .ToString();

        var _displayName = new StringBuilder()
            .Append(firstClass?.DisplayName ?? string.Empty)
            .Append("-")
            .Append(SecondClass?.DisplayName ?? string.Empty)
            .ToString();

        simpleLinkClass = (BaseLink)simpleLinkClass
            .SetName(_name)
            .SetDisplayName(_displayName);

        return simpleLinkClass;
    }
    public async Task<BaseEntity> CreateAsync(BaseEntity obj_DTO)
    {
        //obj_DTO.Id = null;
        await _db.AddAsync(obj_DTO);
        await _db.SaveChangesAsync();
        return obj_DTO;
    }
    public async Task<int> deleteAsync(string type, long? id)
    {
        if (!string.IsNullOrEmpty(type))
        {
            var gtype = DatabaseClass.GetDBType(type);
            var obj = await _db.FindAsync(gtype, id);

            if (obj != null)
            {
                _db.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return -1;
        }
        return -1;
    }
    public Task<BaseEntity> GetAsync(long? RecordId)
    {
        throw new NotImplementedException();
    }
    public async Task<BaseEntity> GetAsync(string type, long? id, bool Tracking = true)
    {
        if (!string.IsNullOrEmpty(type))
        {
            var gtype = DatabaseClass.GetDBType(type);

            if (!id.HasValue)
            {
                id = 0;
            }
            if (id == 0)
            {
                return await GetLastAsync(type);
            }
            else
            {
                _db.ChangeTracker.QueryTrackingBehavior = Tracking ? QueryTrackingBehavior.TrackAll : QueryTrackingBehavior.NoTracking;

                var _SimpleClass = await _db.FindAsync(gtype, id) as BaseEntity;

                return _SimpleClass;
            }
        }
        return null;
    }
    public async Task<BaseEntity> GetAsync(string type, string? recordName, bool Tracking = true, params string[] TableIncludes)
    {
        //_db.ChangeTracker.QueryTrackingBehavior = Tracking;
        var gtype = DatabaseClass.GetDBType(type);

        var Q_SimpleClass = DatabaseClass
            .InvokeSet(_db, gtype)
            .AsQueryable()
            .Where(x => x.Name == recordName)
            as IQueryable<BaseEntity>;

        foreach (var x in TableIncludes)
        {
            Q_SimpleClass = Q_SimpleClass.Include(x);
        }

        var S_SimpleClass = await Q_SimpleClass.SingleOrDefaultAsync();

        return S_SimpleClass;
    }
    public async Task<Tuple<SimpleClassDTO, IEnumerable<SimpleClassDTO>>> GetAllBySimpleClassAsync(SimpleClassDTO simpleClass)
    {
        var ReturnOutput = new Tuple<SimpleClassDTO, IEnumerable<SimpleClassDTO>>(new SimpleClassDTO(), new List<SimpleClassDTO>());

        if (string.IsNullOrEmpty(simpleClass.Name))
        {
            return ReturnOutput;
        }

        SimpleClassDTO d_Entity;

        var _inputQuery = _db.D_Entities
            .Where(x => x.Name == simpleClass.Name);

        if (await _inputQuery.AnyAsync())
        {
            d_Entity = await _inputQuery
                .AsNoTracking()
                .Select(x => x.Adapt<SimpleClassDTO>())
                .FirstAsync();
        }
        else
        {
            d_Entity = new()
            {
                Id = -1,
                ERPCode = -1,
                SortIndex = -1,
                Name = nameof(D_Entity),
                DisplayName = "تمام جدول ها"
            };
        }

        var gtype = DatabaseClass.GetDBType(d_Entity.Name);
        var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<BaseEntity>;
        var Result = await Task.FromResult(aa.ToList().Select(x => x.Adapt<SimpleClassDTO>()));

        ReturnOutput = new Tuple<SimpleClassDTO, IEnumerable<SimpleClassDTO>>(d_Entity, Result);

        return ReturnOutput;
    }
    public async Task<IEnumerable<BaseEntity>> GetAllByNameAsync(string type)
    {
        var gtype = DatabaseClass.GetDBType(type);
        var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<BaseEntity>;
        var Result = await Task.FromResult(aa.ToList());
        return Result;
    }
    public async Task<IEnumerable<BaseLink>> GetAllLinkAsync(string type, string sd_Status, long? linkID)
    {
        if (!string.IsNullOrEmpty(type))
        {
            _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            var gtype = DatabaseClass.GetDBType(type);
            var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<BaseLink>;

            var Result = await Task.FromResult(
                aa.Where(x => x.EnableRecord && x.FirstId == linkID && sd_Status == nameof(LinkProperty.First) ||
                x.SecondId == linkID && sd_Status == nameof(LinkProperty.Second)).ToList());
            return Result;
        }
        _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
        return new List<BaseLink>();
    }
    public async Task<Dictionary<string, string>> GetAllTableNameAsync(string SchemaName)
    {
        if (!string.IsNullOrEmpty(SchemaName))
        {
            _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            var Result = await Task.FromResult(
                _db.Model.GetEntityTypes()
                .ToDictionary(x => x.Name.Split('.').Last(),
                x => x.Name.Split('.').Last()));
            _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            return Result;
        }
        return new Dictionary<string, string>();
    }
    public async Task<BaseEntity> GetLastAsync(string type)
    {
        var gtype = DatabaseClass.GetDBType(type);
        var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<BaseEntity>;
        var instance = (BaseEntity)Activator.CreateInstance(gtype);
        instance
            .SetSortIndex(aa.Any() ? aa.Max(x => x.SortIndex) + 1 : 1);
        return instance;
    }
    public async Task<int> RemoveLink(LinkStateClassDTO obj_DTO)
    {
        _db.Remove(obj_DTO);

        return 1;
    }
    public async Task<BaseEntity> UpdateAsync(BaseEntity obj_DTO)
    {
        _db.Update(obj_DTO);
        await _db.SaveChangesAsync();
        _db.ChangeTracker.Clear();
        return obj_DTO;
    }
    public async Task<int> UpdateLinkAsync(LinkStateClassDTO obj_DTO)
    {
        var gtype = DatabaseClass.GetDBType(obj_DTO.LinkType);

        var simpleLinkClass = new List<BaseLink>();

        var fixedInstance = await GetAsync(
            type: obj_DTO.Sd_Status == nameof(LinkProperty.First) ? obj_DTO.FirstType : obj_DTO.SecondType,
            id: obj_DTO.FixedId, Tracking: false);

        foreach (var link in obj_DTO.FloatState.Where(x => x.Value))
        {
            var instance = (BaseLink)Activator.CreateInstance(gtype);

            if (simpleLinkClass.Any())
            {
                instance
                    .SetSortIndex(simpleLinkClass.Last().SortIndex + 1);
            }
            else
            {
                instance = await GetLastAsync(obj_DTO.LinkType) as BaseLink;
            }

            Type firstType, secondType;

            firstType = DatabaseClass.GetDBType(obj_DTO.FirstType);

            secondType = DatabaseClass.GetDBType(obj_DTO.SecondType);


            if (obj_DTO.Sd_Status == nameof(LinkProperty.First))
            {
                //instance.SetFirstAndSecond(obj_DTO.FixedId, link.Key.Item1);


            }
            else
            {
                //instance.SetFirstAndSecond(link.Key.Item1, obj_DTO.FixedId);
            }

            var floatedInstance = await GetAsync(
            type: obj_DTO.Sd_Status == nameof(LinkProperty.First) ? obj_DTO.SecondType : obj_DTO.FirstType,
            id: link.Key.Item1, Tracking: false);

            if (obj_DTO.Sd_Status == nameof(LinkProperty.First))
            {
                instance = AddLinkName(instance, fixedInstance, floatedInstance);
            }
            else
            {
                instance = AddLinkName(instance, floatedInstance, fixedInstance);
            }

            simpleLinkClass.Add(instance);
        }

        var allLink = await GetAllLinkAsync
        (
            obj_DTO.LinkType,
            obj_DTO.Sd_Status,
            obj_DTO.FixedId
        );

        _db.RemoveRange(allLink);

        _db.AddRange(simpleLinkClass);

        await _db.SaveChangesAsync();

        return 0;

        //return await _db.SaveChangesAsync();
    }
    public async Task<DateTimeOffset?> GetLastUpdate(string TableName)
    {
        var _lastModified =
        await _db.D_Entities.Where(x => x.Name == TableName)
        .AsNoTracking()
        .Select(x => x.LastModified)
        .FirstOrDefaultAsync();

        return _lastModified;
    }
}