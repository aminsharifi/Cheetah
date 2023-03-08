namespace Cheetah_Business.Repository.IRepository
{
    using AutoMapper;
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Dimentions;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.ConstrainedExecution;
    using System.Threading.Tasks;
    using System.Xml.Linq;
    using static Azure.Core.HttpHeader;

    public class SimpleClassRepository : ISimpleClassRepository
    {
        protected ApplicationDbContext _db;
        protected IMapper _mapper;
        public SimpleClassRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<int> delete(string type, long id)
        {
            if (!String.IsNullOrEmpty(type))
            {
                Type gtype = Type.GetType("Cheetah_DataAccess.Dimentions." + type + ",Cheetah_DataAccess");
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
    }

}