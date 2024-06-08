namespace Cheetah.Infrastructure.Persistence.Services;

public class TableCRUD(ApplicationDbContext _db) : ITableCRUD
{
    public async Task<Int32> AddLink(LinkClassDTO obj_DTO)
    {
        await _db.AddAsync(obj_DTO);

        return 1;
    }
    public SimpleLinkClass AddLinkName(SimpleLinkClass simpleLinkClass, BaseEntity? firstClass, BaseEntity? SecondClass)
    {
        var _name = new StringBuilder()
            .Append(firstClass?.Name ?? String.Empty)
            .Append("-")
            .Append(SecondClass?.Name ?? String.Empty)
            .ToString();

        var _displayName = new StringBuilder()
            .Append(firstClass?.DisplayName ?? String.Empty)
            .Append("-")
            .Append(SecondClass?.DisplayName ?? String.Empty)
            .ToString();

        simpleLinkClass.SetNameAndDisplayName(name: _name, displayName: _displayName);

        return simpleLinkClass;
    }
    public async Task<BaseEntity> CreateAsync(BaseEntity obj_DTO)
    {
        //obj_DTO.Id = null;
        await _db.AddAsync(obj_DTO);
        await _db.SaveChangesAsync();
        return obj_DTO;
    }
    public async Task<Int32> deleteAsync(String type, Int64? id)
    {
        if (!String.IsNullOrEmpty(type))
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
    public async Task<BaseEntity> GetAsync(String type, Int64? id, Boolean Tracking = true)
    {
        if (!String.IsNullOrEmpty(type))
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
    public async Task<BaseEntity> GetAsync(String type, string? recordName, Boolean Tracking = true, params String[] TableIncludes)
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
    public async Task<Tuple<SimpleClassDTO, IEnumerable<SimpleClassDTO>>> GetAllBySimpleClassAsync(BaseEntity simpleClass)
    {
        var ReturnOutput = new Tuple<SimpleClassDTO, IEnumerable<SimpleClassDTO>>(new SimpleClassDTO(), new List<SimpleClassDTO>());

        if (String.IsNullOrEmpty(simpleClass.Name))
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
                .Select(x=>x.Adapt<SimpleClassDTO>())
                .FirstAsync();
        }
        else
        {
            d_Entity = new()
            {
                Id= -1, ERPCode= -1, SortIndex= -1, Name = nameof(D_Entity), DisplayName= "تمام جدول ها"
            };
        }

        var gtype = DatabaseClass.GetDBType(d_Entity.Name);
        var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<BaseEntity>;
        var Result = await Task.FromResult(aa.ToList().Select(x=> x.Adapt<SimpleClassDTO>()));

        ReturnOutput = new Tuple<SimpleClassDTO, IEnumerable<SimpleClassDTO>>(d_Entity, Result);

        return ReturnOutput;
    }
    public async Task<IEnumerable<BaseEntity>> GetAllByNameAsync(String type)
    {
        var gtype = DatabaseClass.GetDBType(type);
        var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<BaseEntity>;
        var Result = await Task.FromResult(aa.ToList());
        return Result;
    }
    public async Task<IEnumerable<SimpleLinkClass>> GetAllLinkAsync(String type, String sd_Status, Int64? linkID)
    {
        if (!String.IsNullOrEmpty(type))
        {
            _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            var gtype = DatabaseClass.GetDBType(type);
            var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<SimpleLinkClass>;

            var Result = await Task.FromResult(
                aa.Where(x => x.EnableRecord && (x.FirstId == linkID && sd_Status == nameof(LinkProperty.First)) ||
                (x.SecondId == linkID && sd_Status == nameof(LinkProperty.Second))).ToList());
            return Result;
        }
        _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
        return new List<SimpleLinkClass>();
    }
    public async Task<Dictionary<String, String>> GetAllTableNameAsync(String SchemaName)
    {
        if (!String.IsNullOrEmpty(SchemaName))
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
    public async Task<BaseEntity> GetLastAsync(String type)
    {
        var gtype = DatabaseClass.GetDBType(type);
        var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<BaseEntity>;
        var instance = (BaseEntity)Activator.CreateInstance(gtype);
        instance.SetSortIndex(aa.Any() ? aa.Max(x => x.SortIndex) + 1 : 1);
        return instance;
    }
    public async Task<Int32> RemoveLink(LinkClassDTO obj_DTO)
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
    public async Task<Int32> UpdateLinkAsync(LinkClassDTO obj_DTO)
    {
        var gtype = DatabaseClass.GetDBType(obj_DTO.LinkType);

        var simpleLinkClass = new List<SimpleLinkClass>();

        var fixedInstance = await GetAsync(
            type: obj_DTO.Sd_Status == nameof(LinkProperty.First) ? obj_DTO.FirstType : obj_DTO.SecondType,
            id: obj_DTO.FixedId, Tracking: false);

        foreach (var link in obj_DTO.FloatState.Where(x => x.Value))
        {
            var instance = (SimpleLinkClass)Activator.CreateInstance(gtype);

            if (simpleLinkClass.Any())
            {
                instance.SetSortIndex(simpleLinkClass.Last().SortIndex + 1);
            }
            else
            {
                instance = await GetLastAsync(obj_DTO.LinkType) as SimpleLinkClass;
            }

            Type firstType, secondType;

            firstType = DatabaseClass.GetDBType(obj_DTO.FirstType);

            secondType = DatabaseClass.GetDBType(obj_DTO.SecondType);


            if (obj_DTO.Sd_Status == nameof(LinkProperty.First))
            {
                instance.SetFirstAndSecond(obj_DTO.FixedId, link.Key.Item1);
            }
            else
            {
                instance.SetFirstAndSecond(link.Key.Item1, obj_DTO.FixedId);
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

    Task<IEnumerable<SimpleClassDTO>> ITableCRUD.GetAllByNameAsync(string type)
    {
        throw new NotImplementedException();
    }

    public Task<Tuple<SimpleClassDTO, IEnumerable<SimpleClassDTO>>> GetAllBySimpleClassAsync(SimpleClassDTO simpleClass)
    {
        throw new NotImplementedException();
    }

    Task<SimpleClassDTO> ITableCRUD.GetAsync(string type, long? id, bool Tracking)
    {
        throw new NotImplementedException();
    }

    Task<SimpleClassDTO> ITableCRUD.GetAsync(string type, string? recordName, bool Tracking, params string[] TableIncludes)
    {
        throw new NotImplementedException();
    }

    Task<SimpleClassDTO> ITableCRUD.GetLastAsync(string type)
    {
        throw new NotImplementedException();
    }

    public Task<SimpleClassDTO> CreateAsync(SimpleClassDTO obj_DTO)
    {
        throw new NotImplementedException();
    }

    public Task<SimpleClassDTO> UpdateAsync(SimpleClassDTO obj_DTO)
    {
        throw new NotImplementedException();
    }

    public LinkClassDTO AddLinkName(LinkClassDTO simpleLinkClass, SimpleClassDTO? firstClass, SimpleClassDTO? SecondClass)
    {
        throw new NotImplementedException();
    }
}