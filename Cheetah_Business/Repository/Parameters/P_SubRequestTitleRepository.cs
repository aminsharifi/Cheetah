namespace Cheetah_Business.Repository.IRepository
{
    using AutoMapper;
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class P_SubRequestTitleRepository : IGeneralRepository<P_SubRequestTitle>
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public P_SubRequestTitleRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<P_SubRequestTitle> Create(P_SubRequestTitle obj_DTO)
        {
            var obj = _mapper.Map<P_SubRequestTitle, P_SubRequestTitle>(obj_DTO);

            obj.GuidRecord = Guid.NewGuid();

            var AddedObj = await _db.P_SubRequestTitles.AddAsync(obj);

            await _db.SaveChangesAsync();

            return _mapper.Map<P_SubRequestTitle, P_SubRequestTitle>(AddedObj.Entity);
        }

        public async Task<int> delete(long id)
        {
            var obj = await _db.P_SubRequestTitles.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                _db.P_SubRequestTitles.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return -1;
        }

        public async Task<P_SubRequestTitle> Get(long id)
        {
            var obj = await _db.P_SubRequestTitles.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                return _mapper.Map<P_SubRequestTitle, P_SubRequestTitle>(obj);
            }
            return new P_SubRequestTitle();
        }

        public async Task<IEnumerable<P_SubRequestTitle>> GetAll()
        {
            return _mapper.Map<IEnumerable<P_SubRequestTitle>, IEnumerable<P_SubRequestTitle>>(_db.P_SubRequestTitles);
        }

        public async Task<P_SubRequestTitle> Update(P_SubRequestTitle obj_DTO)
        {
            var obj = await _db.P_SubRequestTitles.FirstOrDefaultAsync(u => u.IdRecord == obj_DTO.IdRecord);
            if (obj != null)
            {
                obj.PName = obj_DTO.PName;
                _db.P_SubRequestTitles.Update(obj);
                await _db.SaveChangesAsync();
                return _mapper.Map<P_SubRequestTitle, P_SubRequestTitle>(obj);
            }
            return obj_DTO;
        }
    }
}
