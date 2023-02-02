namespace Cheetah_Business.Repository.IRepository
{
    using AutoMapper;
    using Cheetah_DataAccess;
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Cheetah_Models;
    using Cheetah_Models.Parameters;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Threading.Tasks;

    public class P_ProcessStateRepository : IP_ProcessStateRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public P_ProcessStateRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<P_ProcessStateDTO> Create(P_ProcessStateDTO obj_DTO)
        {
            var obj = _mapper.Map<P_ProcessStateDTO, P_ProcessState>(obj_DTO);

            obj.GuidRecord = Guid.NewGuid();

            var AddedObj = await _db.P_ProcessStates.AddAsync(obj);

            await _db.SaveChangesAsync();

            return _mapper.Map<P_ProcessState, P_ProcessStateDTO>(AddedObj.Entity);
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

        public async Task<P_ProcessStateDTO> Get(long id)
        {
            var obj = await _db.P_ProcessStates.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                return _mapper.Map<P_ProcessState, P_ProcessStateDTO>(obj);
            }
            return new P_ProcessStateDTO();
        }

        public async Task<IEnumerable<P_ProcessStateDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<P_ProcessState>, IEnumerable<P_ProcessStateDTO>>(_db.P_ProcessStates);
        }

        public async Task<P_ProcessStateDTO> Update(P_ProcessStateDTO obj_DTO)
        {
            var obj = await _db.P_ProcessStates.FirstOrDefaultAsync(u => u.IdRecord == obj_DTO.IdRecord);
            if (obj != null)
            {
                obj.PName = obj_DTO.PName;
                _db.P_ProcessStates.Update(obj);
                await _db.SaveChangesAsync();
                return _mapper.Map<P_ProcessState, P_ProcessStateDTO>(obj);
            }
            return obj_DTO;
        }
    }
}
