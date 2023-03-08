namespace Cheetah_Business.Repository.IRepository
{
    using AutoMapper;
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Dimentions;
    using Cheetah_DataAccess.Parameters;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class P_ParameterTypeRepository : IGeneralRepository<D_ParameterType>
    {
        protected readonly ApplicationDbContext _db;
        protected readonly IMapper _mapper;

        public P_ParameterTypeRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<D_ParameterType> Create(D_ParameterType obj_DTO)
        {
            var obj = _mapper.Map<D_ParameterType, D_ParameterType>(obj_DTO);

            obj.GuidRecord = Guid.NewGuid();

            var AddedObj = await _db.P_ParameterTypes.AddAsync(obj);

            await _db.SaveChangesAsync();

            return _mapper.Map<D_ParameterType, D_ParameterType>(AddedObj.Entity);
        }

        public async Task<int> delete(long id)
        {
            var obj = await _db.P_ParameterTypes.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.P_ParameterTypes.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return -1;
        }

        public async Task<D_ParameterType> Get(long? id)
        {
            var obj = await _db.P_ParameterTypes.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                return _mapper.Map<D_ParameterType, D_ParameterType>(obj);
            }
            return new D_ParameterType();
        }

        public async Task<IEnumerable<D_ParameterType>> GetAll()
        {
            return _db.P_ParameterTypes.ToList();
        }

        public Task<IEnumerable<object>> GetAllByName(string Name)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<SimpleClass>> GetAllByName(Type type)
        {
            throw new NotImplementedException();
        }

        public async Task<D_ParameterType> Update(D_ParameterType obj_DTO)
        {
            var obj = await _db.P_ParameterTypes.FirstOrDefaultAsync(u => u.Id == obj_DTO.Id);
            if (obj != null)
            {
                obj.PName = obj_DTO.PName;
                _db.P_ParameterTypes.Update(obj);
                await _db.SaveChangesAsync();
                return _mapper.Map<D_ParameterType, D_ParameterType>(obj);
            }
            return obj_DTO;
        }

    }
}