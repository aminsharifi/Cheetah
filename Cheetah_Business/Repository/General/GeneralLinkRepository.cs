namespace Cheetah_Business.Repository.IRepository
{
    using AutoMapper;
    using Cheetah_DataAccess.Data;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class GeneralLinkRepository<T> : GeneralRepository<T>, IGeneralLinkRepository<T> where T : BaseLinkClass<T>, new()
    {
        public GeneralLinkRepository(ApplicationDbContext db, IMapper mapper) : base(db, mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<IEnumerable<T>> GetAllFirst(long First)
        {
            var P_ParameterLists = await _db.Set<T>().Where(x => x.FirstId == First)
              .ToListAsync();

            return P_ParameterLists;
        }

        public async Task<IEnumerable<T>> GetAllSecond(long Second)
        {
            var P_ParameterLists = await _db.Set<T>().Where(x => x.SecondId == Second)
              .ToListAsync();

            return P_ParameterLists;
        }
    }
}
