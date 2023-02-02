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

    public class P_UserActionGroupRepository : IP_UserActionGroupRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public P_UserActionGroupRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<P_UserActionGroupDTO> Create(P_UserActionGroupDTO obj_DTO)
        {
            var obj = _mapper.Map<P_UserActionGroupDTO, P_UserActionGroup>(obj_DTO);

            obj.GuidRecord = Guid.NewGuid();

            var AddedObj = await _db.P_UserActionGroups.AddAsync(obj);

            await _db.SaveChangesAsync();

            return _mapper.Map<P_UserActionGroup, P_UserActionGroupDTO>(AddedObj.Entity);
        }

        public async Task<int> delete(long id)
        {
            var obj = await _db.P_UserActionGroups.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                _db.P_UserActionGroups.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return -1;
        }

        public async Task<P_UserActionGroupDTO> Get(long id)
        {
            var obj = await _db.P_UserActionGroups.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                return _mapper.Map<P_UserActionGroup, P_UserActionGroupDTO>(obj);
            }
            return new P_UserActionGroupDTO();
        }

        public async Task<IEnumerable<P_UserActionGroupDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<P_UserActionGroup>, IEnumerable<P_UserActionGroupDTO>>(_db.P_UserActionGroups);
        }

        public async Task<P_UserActionGroupDTO> Update(P_UserActionGroupDTO obj_DTO)
        {
            var obj = await _db.P_UserActionGroups.FirstOrDefaultAsync(u => u.IdRecord == obj_DTO.IdRecord);
            if (obj != null)
            {
                obj.PName = obj_DTO.PName;
                _db.P_UserActionGroups.Update(obj);
                await _db.SaveChangesAsync();
                return _mapper.Map<P_UserActionGroup, P_UserActionGroupDTO>(obj);
            }
            return obj_DTO;
        }
    }
}
