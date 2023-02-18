namespace Cheetah_Business.Repository.IRepository
{
    using AutoMapper;
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class P_PositionOrgRepository : IGeneralRepository<P_PositionOrg>
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public P_PositionOrgRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<P_PositionOrg> Create(P_PositionOrg obj_DTO)
        {
            var obj = _mapper.Map<P_PositionOrg, P_PositionOrg>(obj_DTO);

            obj.GuidRecord = Guid.NewGuid();

            var AddedObj = await _db.P_PositionOrgs.AddAsync(obj);

            await _db.SaveChangesAsync();

            return _mapper.Map<P_PositionOrg, P_PositionOrg>(AddedObj.Entity);
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

        public async Task<P_PositionOrg> Get(long id)
        {
            var obj = await _db.P_PositionOrgs.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                return _mapper.Map<P_PositionOrg, P_PositionOrg>(obj);
            }
            return new P_PositionOrg();
        }

        public async Task<IEnumerable<P_PositionOrg>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<P_PositionOrg> Update(P_PositionOrg obj_DTO)
        {
            var obj = await _db.P_PositionOrgs.FirstOrDefaultAsync(u => u.IdRecord == obj_DTO.IdRecord);
            if (obj != null)
            {
                obj.PName = obj_DTO.PName;
                _db.P_PositionOrgs.Update(obj);
                await _db.SaveChangesAsync();
                return _mapper.Map<P_PositionOrg, P_PositionOrg>(obj);
            }
            return obj_DTO;
        }
    }
}
