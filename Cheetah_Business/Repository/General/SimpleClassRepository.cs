namespace Cheetah_Business.Repository.IRepository
{
    using AutoMapper;
    using Cheetah_Common;
    using Cheetah_DataAccess.Data;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class SimpleClassRepository : ISimpleClassRepository
    {
        protected ApplicationDbContext _db;
        protected IMapper _mapper;
        public SimpleClassRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<SimpleClass> Create(SimpleClass obj_DTO)
        {
            await _db.AddAsync(obj_DTO);
            await _db.SaveChangesAsync();
            return obj_DTO;
        }
        public async Task<int> delete(string type, long id)
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
        public async Task<SimpleClass> Get(string type, long? id)
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
                    var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<SimpleClass>;
                    var instance = (SimpleClass)Activator.CreateInstance(gtype);
                    instance.PCode = aa.Any() ? aa.Max(x => x.PCode) + 1 : 1;
                    instance.PIndex = aa.Any() ? aa.Max(x => x.PIndex) + 1 : 1;
                    return instance;

                }
                else
                {
                    return await _db.FindAsync(gtype, id) as SimpleClass;
                }
            }
            return null;

        }
        public async Task<IEnumerable<SimpleClass>> GetAllByName(string type)
        {
            if (!String.IsNullOrEmpty(type))
            {
                var gtype = DatabaseClass.GetDBType(type);
                var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<SimpleClass>;
                return await Task.FromResult(aa.ToList());
            }
            return new List<SimpleClass>();
        }
        public async Task<IEnumerable<SimpleLinkClass>> GetAllLink(String type, string sd_Status, long linkID)
        {
            if (!String.IsNullOrEmpty(type))
            {
                var gtype = DatabaseClass.GetDBType(type);
                var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<SimpleLinkClass>;

                return await Task.FromResult(
                    aa.Where(x => (x.FirstId == linkID && sd_Status == SD.First) ||
                    (x.SecondId == linkID && sd_Status == SD.Second)).ToList());
            }
            return new List<SimpleLinkClass>();
        }
        public async Task<IEnumerable<KeyValuePair<string, string>>> GetAllTableName(string SchemaName)
        {
            if (!String.IsNullOrEmpty(SchemaName))
            {
                return await Task.FromResult(
                    _db.Model.GetEntityTypes()
                    .ToDictionary(x => x.Name.Split('.').Last(), x => x.Name.Split('.').Last()).ToList());
            }
            return new List<KeyValuePair<string, string>>();
        }
        public async Task<SimpleClass> Update(SimpleClass obj_DTO)
        {
            _db.Update(obj_DTO);
            await _db.SaveChangesAsync();
            return obj_DTO;
        }
    }
}