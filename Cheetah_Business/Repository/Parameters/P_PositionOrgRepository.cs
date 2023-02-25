namespace Cheetah_Business.Repository.IRepository
{
    using AutoMapper;
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class P_PositionOrgRepository : IGeneralRepository<D_Position>
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public P_PositionOrgRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<D_Position> Create(D_Position obj_DTO)
        {
            var obj = _mapper.Map<D_Position, D_Position>(obj_DTO);

            obj.GuidRecord = Guid.NewGuid();

            var AddedObj = await _db.P_PositionOrgs.AddAsync(obj);

            await _db.SaveChangesAsync();

            return _mapper.Map<D_Position, D_Position>(AddedObj.Entity);
        }

        public async Task<int> delete(long id)
        {
            var obj = await _db.P_PositionOrgs.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                _db.P_PositionOrgs.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return -1;
        }

        public async Task<D_Position> Get(long id)
        {
            var obj = await _db.P_PositionOrgs.FirstOrDefaultAsync(u => u.Id == id);
            if (obj != null)
            {
                return _mapper.Map<D_Position, D_Position>(obj);
            }
            return new D_Position();
        }

        public async Task<IEnumerable<D_Position>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<D_Position> Update(D_Position obj_DTO)
        {
            var obj = await _db.P_PositionOrgs.FirstOrDefaultAsync(u => u.Id == obj_DTO.Id);
            if (obj != null)
            {
                obj.PName = obj_DTO.PName;
                _db.P_PositionOrgs.Update(obj);
                await _db.SaveChangesAsync();
                return _mapper.Map<D_Position, D_Position>(obj);
            }
            return obj_DTO;
        }
    }
}
