namespace Cheetah_Business.Repository.IRepository
{
    using AutoMapper;
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class P_UserActionGroupRepository : IGeneralRepository<P_UserActionGroup>
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public P_UserActionGroupRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<P_UserActionGroup> Create(P_UserActionGroup obj_DTO)
        {
            var obj = _mapper.Map<P_UserActionGroup, P_UserActionGroup>(obj_DTO);

            obj.GuidRecord = Guid.NewGuid();

            var AddedObj = await _db.P_UserActionGroups.AddAsync(obj);

            await _db.SaveChangesAsync();

            return _mapper.Map<P_UserActionGroup, P_UserActionGroup>(AddedObj.Entity);
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

        public async Task<P_UserActionGroup> Get(long id)
        {
            var obj = await _db.P_UserActionGroups.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                return _mapper.Map<P_UserActionGroup, P_UserActionGroup>(obj);
            }
            return new P_UserActionGroup();
        }

        public async Task<IEnumerable<P_UserActionGroup>> GetAll()
        {
            return _mapper.Map<IEnumerable<P_UserActionGroup>, IEnumerable<P_UserActionGroup>>(_db.P_UserActionGroups);
        }

        public async Task<P_UserActionGroup> Update(P_UserActionGroup obj_DTO)
        {
            var obj = await _db.P_UserActionGroups.FirstOrDefaultAsync(u => u.IdRecord == obj_DTO.IdRecord);
            if (obj != null)
            {
                obj.PName = obj_DTO.PName;
                _db.P_UserActionGroups.Update(obj);
                await _db.SaveChangesAsync();
                return _mapper.Map<P_UserActionGroup, P_UserActionGroup>(obj);
            }
            return obj_DTO;
        }
    }
}
