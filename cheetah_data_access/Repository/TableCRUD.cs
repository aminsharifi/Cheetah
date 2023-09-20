using AutoMapper;
using Cheetah_Business;
using Cheetah_Business.Data;
using Cheetah_Business.Repository;
using Cheetah_DataAccess.Data;
using FluentAssertions;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Cheetah_DataAccess.Repository;

public class TableCRUD : ITableCRUD
{
    protected ApplicationDbContext _db;
    protected IMapper _mapper;
    public TableCRUD(ApplicationDbContext db, IMapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }
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
    public async Task<SimpleClass> Get(String type, Int64? id, QueryTrackingBehavior Tracking = QueryTrackingBehavior.TrackAll)
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
                _db.ChangeTracker.QueryTrackingBehavior = Tracking;

                var _SimpleClass = await _db.FindAsync(gtype, id) as SimpleClass;

                return _SimpleClass;
            }
        }
        return null;
    }
    public async Task<SimpleClass> Get(String type, string? recordName,
        QueryTrackingBehavior Tracking = QueryTrackingBehavior.TrackAll,params String[] TableIncludes)
    {
        //_db.ChangeTracker.QueryTrackingBehavior = Tracking;
        var gtype = DatabaseClass.GetDBType(type);

        var Q_SimpleClass = DatabaseClass
            .InvokeSet(_db, gtype)
            .AsQueryable()
            .Where(x => x.Name == recordName)
            as IQueryable<SimpleClass>;

        foreach ( var x in TableIncludes )
        {
            Q_SimpleClass = Q_SimpleClass.Include(x);
        }

        var S_SimpleClass = await Q_SimpleClass.SingleOrDefaultAsync();

        return S_SimpleClass;
    }

    public async Task<IEnumerable<SimpleClass>> GetAllByName(String type)
    {
        if (!String.IsNullOrEmpty(type))
        {
            var gtype = DatabaseClass.GetDBType(type);
            var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<SimpleClass>;
            var Result = await Task.FromResult(aa.ToList());
            return Result;
        }
        return new List<SimpleClass>();
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
        var gtype = DatabaseClass.GetDBType(obj_DTO.linkType);    

        var simpleLinkClass = new List<SimpleLinkClass>();

        var fixedInstance = await Get(
            type: obj_DTO.sd_Status == nameof(LinkProperty.First) ? obj_DTO.firstType : obj_DTO.secondType,
            id: obj_DTO.fixedId, Tracking: QueryTrackingBehavior.NoTracking);

        foreach (var link in obj_DTO.floatState.Where(x => x.Value))
        {
            var instance = (SimpleLinkClass)Activator.CreateInstance(gtype);

            if (simpleLinkClass.Any())
            {
                instance.SortIndex = simpleLinkClass.Last().SortIndex + 1;
            }
            else
            {
                instance = await GetLast(obj_DTO.linkType) as SimpleLinkClass;
            }

            Type firstType, secondType;

            firstType = DatabaseClass.GetDBType(obj_DTO.firstType);

            secondType = DatabaseClass.GetDBType(obj_DTO.secondType);


            if (obj_DTO.sd_Status == nameof(LinkProperty.First))
            {
                instance.FirstId = obj_DTO.fixedId;
                instance.SecondId = link.Key.Item1;

            }
            else
            {
                instance.FirstId = link.Key.Item1;
                instance.SecondId = obj_DTO.fixedId;
            }

            var floatedInstance = await Get(
            type: obj_DTO.sd_Status == nameof(LinkProperty.First) ? obj_DTO.secondType : obj_DTO.firstType,
            id: link.Key.Item1, Tracking: QueryTrackingBehavior.NoTracking);

            if (obj_DTO.sd_Status == nameof(LinkProperty.First))
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
            obj_DTO.linkType,
            obj_DTO.sd_Status,
            obj_DTO.fixedId
        );

        _db.RemoveRange(allLink);       

        _db.AddRange(simpleLinkClass);

        await _db.SaveChangesAsync();

        return 0;

        //return await _db.SaveChangesAsync();
    }
}