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

    public class P_UserActionRepository : IP_UserActionRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public P_UserActionRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<P_UserActionDTO> Create(P_UserActionDTO obj_DTO)
        {
            var obj = _mapper.Map<P_UserActionDTO, P_UserAction>(obj_DTO);

            obj.GuidRecord = Guid.NewGuid();

            var AddedObj = await _db.P_UserActions.AddAsync(obj);

            await _db.SaveChangesAsync();

            return _mapper.Map<P_UserAction, P_UserActionDTO>(AddedObj.Entity);
        }

        public async Task<int> delete(long id)
        {
            var obj = await _db.P_UserActions.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                _db.P_UserActions.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return -1;
        }

        public async Task<P_UserActionDTO> Get(long id)
        {
            var obj = await _db.P_UserActions.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                return _mapper.Map<P_UserAction, P_UserActionDTO>(obj);
            }
            return new P_UserActionDTO();
        }

        public async Task<IEnumerable<P_UserActionDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<P_UserAction>, IEnumerable<P_UserActionDTO>>(_db.P_UserActions);
        }

        public async Task<P_UserActionDTO> Update(P_UserActionDTO obj_DTO)
        {
            var obj = await _db.P_UserActions.FirstOrDefaultAsync(u => u.IdRecord == obj_DTO.IdRecord);
            if (obj != null)
            {
                obj.PName = obj_DTO.PName;
                _db.P_UserActions.Update(obj);
                await _db.SaveChangesAsync();
                return _mapper.Map<P_UserAction, P_UserActionDTO>(obj);
            }
            return obj_DTO;
        }
    }

}