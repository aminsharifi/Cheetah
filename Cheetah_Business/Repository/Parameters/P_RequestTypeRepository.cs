namespace Cheetah_Business.Repository.IRepository
{
    using AutoMapper;
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class P_RequestTypeRepository : IGeneralRepository<P_RequestType>
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public P_RequestTypeRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<P_RequestType> Create(P_RequestType obj_DTO)
        {
            var obj = _mapper.Map<P_RequestType, P_RequestType>(obj_DTO);

            obj.GuidRecord = Guid.NewGuid();

            var AddedObj = await _db.P_RequestTypes.AddAsync(obj);

            await _db.SaveChangesAsync();

            return _mapper.Map<P_RequestType, P_RequestType>(AddedObj.Entity);
        }

        public async Task<int> delete(long id)
        {
            var obj = await _db.P_RequestTypes.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                _db.P_RequestTypes.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return -1;
        }

        public async Task<P_RequestType> Get(long id)
        {
            var obj = await _db.P_RequestTypes.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                return _mapper.Map<P_RequestType, P_RequestType>(obj);
            }
            return new P_RequestType();
        }

        public async Task<IEnumerable<P_RequestType>> GetAll()
        {
            return _mapper.Map<IEnumerable<P_RequestType>, IEnumerable<P_RequestType>>(_db.P_RequestTypes);
        }

        public async Task<P_RequestType> Update(P_RequestType obj_DTO)
        {
            var obj = await _db.P_RequestTypes.FirstOrDefaultAsync(u => u.IdRecord == obj_DTO.IdRecord);
            if (obj != null)
            {
                obj.PName = obj_DTO.PName;
                _db.P_RequestTypes.Update(obj);
                await _db.SaveChangesAsync();
                return _mapper.Map<P_RequestType, P_RequestType>(obj);
            }
            return obj_DTO;
        }
    }
}
