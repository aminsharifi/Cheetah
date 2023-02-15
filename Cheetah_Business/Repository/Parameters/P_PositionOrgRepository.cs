namespace Cheetah_Business.Repository.IRepository
{
    using AutoMapper;
    using Cheetah_Business.Repository.IRepository.General;
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Cheetah_DataAccess.Systems;
    using Cheetah_Models;
    using Cheetah_Models.Parameters;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Threading.Tasks;

    public class P_PositionOrgRepository : IP_PositionOrgRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public P_PositionOrgRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<P_PositionOrgDTO> Create(P_PositionOrgDTO obj_DTO)
        {
            var obj = _mapper.Map<P_PositionOrgDTO, P_PositionOrg>(obj_DTO);

            obj.GuidRecord = Guid.NewGuid();

            var AddedObj = await _db.P_PositionOrgs.AddAsync(obj);

            await _db.SaveChangesAsync();

            return _mapper.Map<P_PositionOrg, P_PositionOrgDTO>(AddedObj.Entity);
        }

        public async Task<int> delete(long id)
        {
            var obj = await _db.P_PositionOrgs.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                _db.P_PositionOrgs.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return -1;
        }

        public async Task<P_PositionOrgDTO> Get(long id)
        {
            var obj = await _db.P_PositionOrgs.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                return _mapper.Map<P_PositionOrg, P_PositionOrgDTO>(obj);
            }
            return new P_PositionOrgDTO();
        }

        public async Task<IEnumerable<P_PositionOrgDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<P_PositionOrgDTO> Update(P_PositionOrgDTO obj_DTO)
        {
            var obj = await _db.P_PositionOrgs.FirstOrDefaultAsync(u => u.IdRecord == obj_DTO.IdRecord);
            if (obj != null)
            {
                obj.PName = obj_DTO.PName;
                _db.P_PositionOrgs.Update(obj);
                await _db.SaveChangesAsync();
                return _mapper.Map<P_PositionOrg, P_PositionOrgDTO>(obj);
            }
            return obj_DTO;
        }
    }
}
