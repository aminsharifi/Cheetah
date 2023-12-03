namespace Cheetah.Infrastructure.Persistence.Repository;

public class TableCRUD(ApplicationDbContext _db, IMapper _mapper) : ITableCRUD
{
    public async Task<Int32> AddLink(SimpleLinkClassDTO obj_DTO)
    {
        await _db.AddAsync(obj_DTO);

        return 1;
    }
    public async Task<SimpleLinkClass> AddLinkName(SimpleLinkClass simpleLinkClass, SimpleClass? firstClass, SimpleClass? SecondClass)
    {
        simpleLinkClass.DisplayName = new StringBuilder()
                 .Append(firstClass?.DisplayName ?? String.Empty)
                 .Append("-")
                 .Append(SecondClass?.DisplayName ?? String.Empty)
                 .ToString();

        simpleLinkClass.Name = new StringBuilder()
                          .Append(firstClass?.Name ?? String.Empty)
                          .Append("-")
                          .Append(SecondClass?.Name ?? String.Empty)
                          .ToString();
        return simpleLinkClass;
    }
    public async Task<SimpleClass> Create(SimpleClass obj_DTO)
    {
        obj_DTO.Id = null;
        await _db.AddAsync(obj_DTO);
        await _db.SaveChangesAsync();
        return obj_DTO;
    }
    public async Task<Int32> delete(String type, Int64? id)
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
    public async Task<SimpleClass> Get(String type, Int64? id, Boolean Tracking = true)
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
                return await GetLast(type);
            }
            else
            {
                _db.ChangeTracker.QueryTrackingBehavior = Tracking ? QueryTrackingBehavior.TrackAll : QueryTrackingBehavior.NoTracking;

                var _SimpleClass = await _db.FindAsync(gtype, id) as SimpleClass;

                return _SimpleClass;
            }
        }
        return null;
    }
    public async Task<SimpleClass> Get(String type, string? recordName, Boolean Tracking = true, params String[] TableIncludes)
    {
        //_db.ChangeTracker.QueryTrackingBehavior = Tracking;
        var gtype = DatabaseClass.GetDBType(type);

        var Q_SimpleClass = DatabaseClass
            .InvokeSet(_db, gtype)
            .AsQueryable()
            .Where(x => x.Name == recordName)
            as IQueryable<SimpleClass>;

        foreach (var x in TableIncludes)
        {
            Q_SimpleClass = Q_SimpleClass.Include(x);
        }

        var S_SimpleClass = await Q_SimpleClass.SingleOrDefaultAsync();

        return S_SimpleClass;
    }

    public async Task<Tuple<SimpleClass, IEnumerable<SimpleClass>>> GetAllBySimpleClass(SimpleClass simpleClass)
    {
        var ReturnOutput = new Tuple<SimpleClass, IEnumerable<SimpleClass>>(new SimpleClassDTO(), new List<SimpleClass>());

        if (String.IsNullOrEmpty(simpleClass.Name))
        {
            return ReturnOutput;
        }

        var InputEntity = await _db.D_Entities.Where(x => x.Name == simpleClass.Name).AsNoTracking().FirstAsync();


        var gtype = DatabaseClass.GetDBType(InputEntity.Name);
        var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<SimpleClass>;
        var Result = await Task.FromResult(aa.ToList());

        ReturnOutput = new Tuple<SimpleClass, IEnumerable<SimpleClass>>(InputEntity, Result);

        return ReturnOutput;
    }

    public async Task<IEnumerable<SimpleClass>> GetAllByName(String type)
    {
        if (!String.IsNullOrEmpty(type))
        {
            new List<SimpleClass>();
        }

        var gtype = DatabaseClass.GetDBType(type);
        var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<SimpleClass>;
        var Result = await Task.FromResult(aa.ToList());
        return Result;
    }

    public async Task<IEnumerable<SimpleLinkClass>> GetAllLink(String type, String sd_Status, Int64? linkID)
    {
        if (!String.IsNullOrEmpty(type))
        {
            _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            var gtype = DatabaseClass.GetDBType(type);
            var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<SimpleLinkClass>;

            var Result = await Task.FromResult(
                aa.Where(x => (x.FirstId == linkID && sd_Status == nameof(LinkProperty.First)) ||
                (x.SecondId == linkID && sd_Status == nameof(LinkProperty.Second))).ToList());
            return Result;
        }
        _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
        return new List<SimpleLinkClass>();
    }
    public async Task<Dictionary<String, String>> GetAllTableName(String SchemaName)
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
    public async Task<SimpleClass> GetLast(String type)
    {
        var gtype = DatabaseClass.GetDBType(type);
        var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<SimpleClass>;
        var instance = (SimpleClass)Activator.CreateInstance(gtype);
        instance.SortIndex = aa.Any() ? aa.Max(x => x.SortIndex) + 1 : 1;
        return instance;
    }
    public async Task<Int32> RemoveLink(SimpleLinkClassDTO obj_DTO)
    {
        _db.Remove(obj_DTO);

        return 1;
    }
    public async Task<SimpleClass> Update(SimpleClass obj_DTO)
    {
        _db.Update(obj_DTO);
        await _db.SaveChangesAsync();
        _db.ChangeTracker.Clear();
        return obj_DTO;
    }
    public async Task<Int32> UpdateLink(SimpleLinkClassDTO obj_DTO)
    {
        var gtype = DatabaseClass.GetDBType(obj_DTO.LinkType);

        var simpleLinkClass = new List<SimpleLinkClass>();

        var fixedInstance = await Get(
            type: obj_DTO.Sd_Status == nameof(LinkProperty.First) ? obj_DTO.FirstType : obj_DTO.SecondType,
            id: obj_DTO.FixedId, Tracking: false);

        foreach (var link in obj_DTO.FloatState.Where(x => x.Value))
        {
            var instance = (SimpleLinkClass)Activator.CreateInstance(gtype);

            if (simpleLinkClass.Any())
            {
                instance.SortIndex = simpleLinkClass.Last().SortIndex + 1;
            }
            else
            {
                instance = await GetLast(obj_DTO.LinkType) as SimpleLinkClass;
            }

            Type firstType, secondType;

            firstType = DatabaseClass.GetDBType(obj_DTO.FirstType);

            secondType = DatabaseClass.GetDBType(obj_DTO.SecondType);


            if (obj_DTO.Sd_Status == nameof(LinkProperty.First))
            {
                instance.FirstId = obj_DTO.FixedId;
                instance.SecondId = link.Key.Item1;

            }
            else
            {
                instance.FirstId = link.Key.Item1;
                instance.SecondId = obj_DTO.FixedId;
            }

            var floatedInstance = await Get(
            type: obj_DTO.Sd_Status == nameof(LinkProperty.First) ? obj_DTO.SecondType : obj_DTO.FirstType,
            id: link.Key.Item1, Tracking: false);

            if (obj_DTO.Sd_Status == nameof(LinkProperty.First))
            {
                instance = await AddLinkName(instance, fixedInstance, floatedInstance);
            }
            else
            {
                instance = await AddLinkName(instance, floatedInstance, fixedInstance);
            }

            simpleLinkClass.Add(instance);
        }

        var allLink = await GetAllLink
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
}