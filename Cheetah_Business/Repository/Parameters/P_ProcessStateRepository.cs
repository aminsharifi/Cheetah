namespace Cheetah_Business.Repository.IRepository
{
    using AutoMapper;
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class P_ProcessStateRepository : IGeneralRepository<D_ProcessState>
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public P_ProcessStateRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<D_ProcessState> Create(D_ProcessState obj_DTO)
        {
            var obj = _mapper.Map<D_ProcessState, D_ProcessState>(obj_DTO);

            obj.GuidRecord = Guid.NewGuid();

            var AddedObj = await _db.P_ProcessStates.AddAsync(obj);

            await _db.SaveChangesAsync();

            return _mapper.Map<D_ProcessState, D_ProcessState>(AddedObj.Entity);
        }

        public async Task<int> delete(long id)
        {
            var obj = await _db.P_ProcessStates.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                _db.P_ProcessStates.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return -1;
        }

        public async Task<D_ProcessState> Get(long id)
        {
            var obj = await _db.P_ProcessStates.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                return _mapper.Map<D_ProcessState, D_ProcessState>(obj);
            }
            return new D_ProcessState();
        }

        public async Task<IEnumerable<D_ProcessState>> GetAll()
        {
            return _mapper.Map<IEnumerable<D_ProcessState>, IEnumerable<D_ProcessState>>(_db.P_ProcessStates);
        }

        public async Task<D_ProcessState> Update(D_ProcessState obj_DTO)
        {
            var obj = await _db.P_ProcessStates.FirstOrDefaultAsync(u => u.IdRecord == obj_DTO.IdRecord);
            if (obj != null)
            {
                obj.PName = obj_DTO.PName;
                _db.P_ProcessStates.Update(obj);
                await _db.SaveChangesAsync();
                return _mapper.Map<D_ProcessState, D_ProcessState>(obj);
            }
            return obj_DTO;
        }
    }
}
