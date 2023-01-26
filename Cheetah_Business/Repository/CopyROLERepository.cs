using Cheetah_Business.Repository.IRepository;
using Cheetah_DataAccess.Data;
using Cheetah_Models;
using Cheetah_DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Cheetah_Business.Repository
{
    public class CopyROLERepository : ICopyROLERepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public CopyROLERepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<CopyROLEDTO> Create(CopyROLEDTO obj_DTO)
        {                       
            var obj = _mapper.Map<CopyROLEDTO, CopyROLE>(obj_DTO);

            obj.guidRole = Guid.NewGuid();
            
            var AddedObj = await _db.CopyROLEs.AddAsync(obj);

            await _db.SaveChangesAsync();

            return _mapper.Map<CopyROLE, CopyROLEDTO>(AddedObj.Entity);
        }

        public async Task<int> delete(int id)
        {
            var obj = await _db.CopyROLEs.FirstOrDefaultAsync(u => u.idRole == id);
            if (obj != null)
            {
                _db.CopyROLEs.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return -1;
        }

        public async Task<CopyROLEDTO> Get(int id)
        {
            var obj = await _db.CopyROLEs.FirstOrDefaultAsync(u => u.idRole == id);
            if (obj != null)
            {
                return _mapper.Map<CopyROLE, CopyROLEDTO>(obj);
            }
            return new CopyROLEDTO();
        }

        public async Task<IEnumerable<CopyROLEDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<CopyROLE>, IEnumerable<CopyROLEDTO>>(_db.CopyROLEs);
        }

        public async Task<CopyROLEDTO> Update(CopyROLEDTO obj_DTO)
        {
            var obj = await _db.CopyROLEs.FirstOrDefaultAsync(u => u.idRole == obj_DTO.idRole);
            if (obj != null)
            {
                obj.roleName = obj_DTO.roleName;
                _db.CopyROLEs.Update(obj);
                await _db.SaveChangesAsync();
                return _mapper.Map<CopyROLE, CopyROLEDTO>(obj);
            }
            return obj_DTO;
        }
    }
}
