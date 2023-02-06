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

    public class P_ParameterListRepository : IP_ParameterListRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public P_ParameterListRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<P_ParameterListDTO> Create(P_ParameterListDTO obj_DTO)
        {
            var obj = _mapper.Map<P_ParameterListDTO, P_ParameterList>(obj_DTO);

            obj.GuidRecord = Guid.NewGuid();

            obj.PL_ParameterType.Add(new P_ParameterType()
            {
                GuidRecord = Guid.NewGuid(),
                PName = obj.IdRecord.ToString()
            });

            var AddedObj = await _db.P_ParameterLists.AddAsync(obj);

            await _db.SaveChangesAsync();

            return _mapper.Map<P_ParameterList, P_ParameterListDTO>(AddedObj.Entity);
        }

        public async Task<int> delete(long id)
        {
            var obj = await _db.P_ParameterLists.FirstOrDefaultAsync(u => u.IdRecord == id);
            if (obj != null)
            {
                _db.P_ParameterLists.Remove(obj);
                return await _db.SaveChangesAsync();
            }
            return -1;
        }

        public async Task<P_ParameterListDTO> Get(long id)
        {
            var obj = await _db.P_ParameterLists.Include(x => x.PL_ParameterType)
                .FirstOrDefaultAsync(u => u.IdRecord == id);

            if (obj != null)
            {
                return _mapper.Map<P_ParameterList, P_ParameterListDTO>(obj);
            }

            return new P_ParameterListDTO();
        }

        public async Task<IEnumerable<P_ParameterListDTO>> GetAll()
        {
            var P_ParameterLists = await _db.P_ParameterLists.ToListAsync();

            return _mapper.Map<IEnumerable<P_ParameterList>, IEnumerable<P_ParameterListDTO>>(P_ParameterLists);
        }

        public async Task<P_ParameterListDTO> Update(P_ParameterListDTO obj_DTO)
        {
            var obj = await _db.P_ParameterLists.FirstOrDefaultAsync(u => u.IdRecord == obj_DTO.IdRecord);
            if (obj != null)
            {
                obj.PName = obj_DTO.PName;
                obj.PL_ParameterType.Add(new P_ParameterType()
                {
                    GuidRecord = Guid.NewGuid(),
                    PName = obj.IdRecord.ToString()
                });
                _db.P_ParameterLists.Update(obj);
                await _db.SaveChangesAsync();
                return _mapper.Map<P_ParameterList, P_ParameterListDTO>(obj);
            }
            return obj_DTO;
        }

    }
}
