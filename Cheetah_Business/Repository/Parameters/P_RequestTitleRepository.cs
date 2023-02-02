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

    public class P_RequestTitleRepository : IP_RequestTitleRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public P_RequestTitleRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public async Task<P_RequestTitleDTO> Create(P_RequestTitleDTO obj_DTO)
        {
            var obj = _mapper.Map<P_RequestTitleDTO, P_RequestTitle>(obj_DTO);

            obj.GuidRecord = Guid.NewGuid();

            var AddedObj = await _db.P_RequestTitles.AddAsync(obj);

            await _db.SaveChangesAsync();

            return _mapper.Map<P_RequestTitle, P_RequestTitleDTO>(AddedObj.Entity);
        }

        public async Task<int> delete(long id)
        {
            var obj = await _db.P_RequestTitles.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                _db.P_RequestTitles.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return -1;
        }

        public async Task<P_RequestTitleDTO> Get(long id)
        {
            var obj = await _db.P_RequestTitles.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                return _mapper.Map<P_RequestTitle, P_RequestTitleDTO>(obj);
            }
            return new P_RequestTitleDTO();
        }

        public async Task<IEnumerable<P_RequestTitleDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<P_RequestTitle>, IEnumerable<P_RequestTitleDTO>>(_db.P_RequestTitles);
        }

        public async Task<P_RequestTitleDTO> Update(P_RequestTitleDTO obj_DTO)
        {
            var obj = await _db.P_RequestTitles.FirstOrDefaultAsync(u => u.IdRecord == obj_DTO.IdRecord);
            if (obj != null)
            {
                obj.PName = obj_DTO.PName;
                _db.P_RequestTitles.Update(obj);
                await _db.SaveChangesAsync();
                return _mapper.Map<P_RequestTitle, P_RequestTitleDTO>(obj);
            }
            return obj_DTO;
        }
    }
}
