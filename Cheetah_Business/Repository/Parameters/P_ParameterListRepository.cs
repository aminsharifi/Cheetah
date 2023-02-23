namespace Cheetah_Business.Repository.IRepository
{
    using AutoMapper;
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class P_ParameterListRepository : IGeneralRepository<D_ParameterList>
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;

        public P_ParameterListRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<D_ParameterList> Create(D_ParameterList obj_DTO)
        {
            var obj = _mapper.Map<D_ParameterList, D_ParameterList>(obj_DTO);

            obj.GuidRecord = Guid.NewGuid();

            //obj.PL_ParameterType.Add(new P_ParameterType()
            //{
            //    GuidRecord = Guid.NewGuid(),
            //    PName = obj.IdRecord.ToString()
            //});

            var AddedObj = await _db.P_ParameterLists.AddAsync(obj);

            await _db.SaveChangesAsync();

            return _mapper.Map<D_ParameterList, D_ParameterList>(AddedObj.Entity);
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

        public async Task<D_ParameterList> Get(long id)
        {
            var obj = await _db.P_ParameterLists.FirstOrDefaultAsync(u => u.IdRecord == id);

            if (obj != null)
            {
                return _mapper.Map<D_ParameterList, D_ParameterList>(obj);
            }

            return new D_ParameterList();
        }

        public async Task<IEnumerable<D_ParameterList>> GetAll()
        {
            var P_ParameterLists = await _db.P_ParameterLists.ToListAsync();

            return _mapper.Map<IEnumerable<D_ParameterList>, IEnumerable<D_ParameterList>>(P_ParameterLists);
        }

        public async Task<D_ParameterList> Update(D_ParameterList obj_DTO)
        {
            var obj = await _db.P_ParameterLists.FirstOrDefaultAsync(u => u.IdRecord == obj_DTO.IdRecord);
            if (obj != null)
            {
                obj.PName = obj_DTO.PName;

                _db.P_ParameterLists.Update(obj);
                await _db.SaveChangesAsync();
                return _mapper.Map<D_ParameterList, D_ParameterList>(obj);
            }
            return obj_DTO;
        }

    }
}
