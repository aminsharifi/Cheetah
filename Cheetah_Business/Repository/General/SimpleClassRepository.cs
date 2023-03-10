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
            _db.Add(obj_DTO);
            await _db.SaveChangesAsync();
            return obj_DTO;
        }

        public async Task<int> delete(string type, long id)
        {
            if (!String.IsNullOrEmpty(type))
            {
                String schema = type.StartsWith("D") ? "Dimentions" : "Links";
                Type gtype = Type.GetType("Cheetah_DataAccess." + schema + "." + type + ",Cheetah_DataAccess");
                var method = _db.GetType().GetMethod("Set", new Type[0]).MakeGenericMethod(gtype);
                var aa = method.Invoke(_db, new object[0]) as IEnumerable<SimpleClass>;


                var obj = await Task.FromResult(aa.FirstOrDefault(u => u.Id == id));

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
                String schema = type.StartsWith("D") ? "Dimentions" : "Links";

                Type gtype = Type.GetType("Cheetah_DataAccess." + schema + "." + type + ",Cheetah_DataAccess");

                var method = _db.GetType().GetMethod("Set", new Type[0]).MakeGenericMethod(gtype);

                var aa = method.Invoke(_db, new object[0]) as IEnumerable<SimpleClass>;

                if (!id.HasValue)
                {
                    id = 0;
                }
                if (id == 0)
                {
                    var instance = (SimpleClass)Activator.CreateInstance(gtype);
                    instance.PCode = aa.Any() ? aa.Max(x => x.PCode) + 1 : 1;
                    instance.PIndex = aa.Any() ? aa.Max(x => x.PIndex) + 1 : 1;
                    return instance;

                }
                else
                {
                    return await Task.FromResult(aa.Where(x => x.Id == id).FirstOrDefault());
                }
            }
            return null;

        }

        public async Task<IEnumerable<SimpleClass>> GetAllByName(string type)
        {
            if (!String.IsNullOrEmpty(type))
            {
                Type gtype = Type.GetType("Cheetah_DataAccess.Dimentions." + type + ",Cheetah_DataAccess");
                var method = _db.GetType().GetMethod("Set", new Type[0]).MakeGenericMethod(gtype);
                var aa = method.Invoke(_db, new object[0]) as IEnumerable<SimpleClass>;
                return await Task.FromResult(aa.ToList());
            }
            return new List<SimpleClass>();
        }

        public async Task<IEnumerable<SimpleLinkClass>> GetAllLink(String type, string sd_Status, long linkID)
        {
            if (!String.IsNullOrEmpty(type))
            {
                Type gtype = Type.GetType("Cheetah_DataAccess.Links." + type + ",Cheetah_DataAccess");
                var method = _db.GetType().GetMethod("Set", new Type[0]).MakeGenericMethod(gtype);
                var aa = method.Invoke(_db, new object[0]) as IEnumerable<SimpleLinkClass>;

                if (sd_Status == SD.First)
                {
                    return await Task.FromResult(aa.Where(x => x.FirstId == linkID).ToList());
                }
                else if (sd_Status == SD.Second)
                {
                    return await Task.FromResult(aa.Where(x => x.SecondId == linkID).ToList());
                }
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