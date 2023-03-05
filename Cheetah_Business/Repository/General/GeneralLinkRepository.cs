namespace Cheetah_Business.Repository.IRepository
{
    using AutoMapper;
    using Cheetah_DataAccess.Data;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class GeneralLinkRepository<T> : IGeneralLinkRepository<T> where T : BaseLinkClass<T>, new()
    {
        protected readonly ApplicationDbContext _db;
        protected readonly IMapper _mapper;
        public GeneralLinkRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<int> delete(long id)
        {
            var obj = await _db.Set<T>().FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.Set<T>().Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return -1;
        }

        public async Task<IEnumerable<T>> GetAllFirst(long Second)
        {
            var P_ParameterLists = await _db.Set<T>().Where(x => x.SecondId == Second)
                .ToListAsync();

            return P_ParameterLists;
        }
        public async Task<IEnumerable<T>> GetAllSecond(long First)
        {
            var P_ParameterLists = await _db.Set<T>().Where(x => x.FirstId == First)
               .ToListAsync();

            return P_ParameterLists;
        }
        public async Task<T> Get(long? id)
        {
            if (!id.HasValue)
            {
                id = 0;
            }
            if (id == 0)
            {
                if (await _db.Set<T>().AnyAsync())
                {
                    return new T()
                    {
                        PCode = await _db.Set<T>().MaxAsync(x => x.PCode) + 1,
                        PIndex = await _db.Set<T>().MaxAsync(x => x.PIndex) + 1
                    };
                }
                else
                {
                    return new T()
                    {
                        PCode = 1,
                        PIndex = 1
                    };
                }
            }
            else
            {
                var obj = await _db.Set<T>().SingleAsync(u => u.Id == id);

                return obj;
            }
        }
    }
}
