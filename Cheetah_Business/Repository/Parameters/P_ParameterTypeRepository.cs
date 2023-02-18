namespace Cheetah_Business.Repository.IRepository
{
    using AutoMapper;
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class P_ParameterTypeRepository : IGeneralRepository<P_ParameterType>
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public P_ParameterTypeRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<P_ParameterType> Create(P_ParameterType obj_DTO)
        {
            var obj = _mapper.Map<P_ParameterType, P_ParameterType>(obj_DTO);

            obj.GuidRecord = Guid.NewGuid();

            var AddedObj = await _db.P_ParameterTypes.AddAsync(obj);

            await _db.SaveChangesAsync();

            return _mapper.Map<P_ParameterType, P_ParameterType>(AddedObj.Entity);
        }

        public async Task<int> delete(long id)
        {
            var obj = await _db.P_ParameterTypes.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                _db.P_ParameterTypes.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return -1;
        }

        public async Task<P_ParameterType> Get(long id)
        {
            var obj = await _db.P_ParameterTypes.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                return _mapper.Map<P_ParameterType, P_ParameterType>(obj);
            }
            return new P_ParameterType();
        }

        public async Task<IEnumerable<P_ParameterType>> GetAll()
        {
            return _mapper.Map<IEnumerable<P_ParameterType>, IEnumerable<P_ParameterType>>
                (_db.P_ParameterTypes);
        }

        public async Task<P_ParameterType> Update(P_ParameterType obj_DTO)
        {
            var obj = await _db.P_ParameterTypes.FirstOrDefaultAsync(u => u.IdRecord == obj_DTO.IdRecord);
            if (obj != null)
            {
                obj.PName = obj_DTO.PName;
                _db.P_ParameterTypes.Update(obj);
                await _db.SaveChangesAsync();
                return _mapper.Map<P_ParameterType, P_ParameterType>(obj);
            }
            return obj_DTO;
        }
    }
}