namespace Cheetah_Business.Repository.IRepository
{
    using AutoMapper;
    using Cheetah_DataAccess.Data;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class GeneralRepository<TEntity> where TEntity : BasePSClass, IGeneralRepository<TEntity>
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public GeneralRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<TEntity> Create(TEntity obj_DTO)
        {
            var AddedObj = await _db.Set<TEntity>().AddAsync(obj_DTO);           
            await _db.SaveChangesAsync();

            return obj_DTO;
        }
        public async Task<int> delete(long id)
        {
            var obj = await _db.Set<TEntity>().FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                _db.Set<TEntity>().Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return -1;
        }
        public async Task<TEntity> Get(long id)
        {
            var obj = await _db.Set<TEntity>().FirstOrDefaultAsync(u => u.IdRecord == id);

            return obj;
        }
        public async Task<IEnumerable<TEntity>> GetAll()
        {
            var P_ParameterLists = await _db.Set<TEntity>().ToListAsync();

            return P_ParameterLists;
        }
        public async Task<TEntity> Update(TEntity obj_DTO)
        {
            var obj = await _db.Set<TEntity>().FirstOrDefaultAsync(u => u.IdRecord == obj_DTO.IdRecord);
            if (obj != null)
            {
                obj.PName = obj_DTO.PName;

                _db.Set<TEntity>().Update(obj);
                await _db.SaveChangesAsync();
                return obj;
            }
            return obj_DTO;
        }

    }
}
