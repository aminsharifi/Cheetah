namespace Cheetah_Business.Repository.IRepository
{
    using AutoMapper;
    using Cheetah_DataAccess.Data;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class GeneralRepository<T> : IGeneralRepository<T> where T : BaseClass<T>, new()
    {
        protected readonly ApplicationDbContext _db;
        protected readonly IMapper _mapper;
        public GeneralRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<T> Create(T obj_DTO)
        {
            var AddedObj = await _db.Set<T>().AddAsync(obj_DTO);
            await _db.SaveChangesAsync();

            return obj_DTO;
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

        public async Task<IEnumerable<T>> GetAll()
        {
            var P_ParameterLists = await _db.Set<T>().ToListAsync();

            return P_ParameterLists;
        }
        public async Task<IEnumerable<Object>> GetAllByName(String Name)
        {
            var P_ParameterLists = await _db.Set<T>().ToListAsync();

            return P_ParameterLists;
        }

        public async Task<T> Update(T obj_DTO)
        {
            var obj = await _db.Set<T>().FirstOrDefaultAsync(u => u.Id == obj_DTO.Id);
            if (obj != null)
            {
                obj.PName = obj_DTO.PName;

                _db.Set<T>().Update(obj);
                await _db.SaveChangesAsync();
                return obj;
            }
            return obj_DTO;
        }

    }
}
