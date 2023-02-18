namespace Cheetah_Business.Repository.IRepository
{
    using AutoMapper;
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class P_ProcessEndorsementRepository  : IGeneralRepository<P_ProcessEndorsement>
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        
        public P_ProcessEndorsementRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<P_ProcessEndorsement> Create(P_ProcessEndorsement obj_DTO)
        {
            var obj = _mapper.Map<P_ProcessEndorsement, P_ProcessEndorsement>(obj_DTO);

            obj.GuidRecord = Guid.NewGuid();

            var AddedObj = await _db.P_ProcessEndorsements.AddAsync(obj);

            await _db.SaveChangesAsync();

            return _mapper.Map<P_ProcessEndorsement, P_ProcessEndorsement>(AddedObj.Entity);
        }

        public async Task<int> delete(long id)
        {
            var obj = await _db.P_ProcessEndorsements.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                _db.P_ProcessEndorsements.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return -1;
        }

        public async Task<P_ProcessEndorsement> Get(long id)
        {
            var obj = await _db.P_ProcessEndorsements.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                return _mapper.Map<P_ProcessEndorsement, P_ProcessEndorsement>(obj);
            }
            return new P_ProcessEndorsement();
        }

        public async Task<IEnumerable<P_ProcessEndorsement>> GetAll()
        {
            return _mapper.Map<IEnumerable<P_ProcessEndorsement>, IEnumerable<P_ProcessEndorsement>>(_db.P_ProcessEndorsements);
        }

        public async Task<P_ProcessEndorsement> Update(P_ProcessEndorsement obj_DTO)
        {
            var obj = await _db.P_ProcessEndorsements.FirstOrDefaultAsync(u => u.IdRecord == obj_DTO.IdRecord);
            if (obj != null)
            {
                obj.PName = obj_DTO.PName;
                _db.P_ProcessEndorsements.Update(obj);
                await _db.SaveChangesAsync();
                return _mapper.Map<P_ProcessEndorsement, P_ProcessEndorsement>(obj);
            }
            return obj_DTO;
        }
    }
}
