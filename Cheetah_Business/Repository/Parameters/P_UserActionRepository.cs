namespace Cheetah_Business.Repository.IRepository
{
    using AutoMapper;
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class P_UserActionRepository : IGeneralRepository<P_UserAction>
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public P_UserActionRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<P_UserAction> Create(P_UserAction obj_DTO)
        {
            var obj = _mapper.Map<P_UserAction, P_UserAction>(obj_DTO);

            obj.GuidRecord = Guid.NewGuid();

            var AddedObj = await _db.P_UserActions.AddAsync(obj);

            await _db.SaveChangesAsync();

            return _mapper.Map<P_UserAction, P_UserAction>(AddedObj.Entity);
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

        public async Task<P_UserAction> Get(long id)
        {
            var obj = await _db.P_UserActions.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                return _mapper.Map<P_UserAction, P_UserAction>(obj);
            }
            return new P_UserAction();
        }

        public async Task<IEnumerable<P_UserAction>> GetAll()
        {
            return _mapper.Map<IEnumerable<P_UserAction>, IEnumerable<P_UserAction>>(_db.P_UserActions);
        }

        public async Task<P_UserAction> Update(P_UserAction obj_DTO)
        {
            var obj = await _db.P_UserActions.FirstOrDefaultAsync(u => u.IdRecord == obj_DTO.IdRecord);
            if (obj != null)
            {
                obj.PName = obj_DTO.PName;
                _db.P_UserActions.Update(obj);
                await _db.SaveChangesAsync();
                return _mapper.Map<P_UserAction, P_UserAction>(obj);
            }
            return obj_DTO;
        }
    }

}