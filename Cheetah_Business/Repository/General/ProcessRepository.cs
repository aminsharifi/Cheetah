namespace Cheetah_Business.Repository.IRepository.General
{
    using AutoMapper;
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Masters;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata;
    using System;
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Threading.Tasks;

    public class ProcessRepository : IProcessRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public ProcessRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }

        public IEnumerable<IEntityType> GetAllEntityType()
        {
            return _db.Model.GetEntityTypes();
        }

        public async Task<F_RequestInformation> CreateProcess(String Input)
        {
            //var obj_DTO = JsonSerializer.Deserialize<M_RequestInformationDTO>(Input);
            //var obj = _mapper.Map<M_RequestInformationDTO, M_RequestInformation>(obj_DTO);

            var obj = JsonSerializer.Deserialize<F_RequestInformation>(Input);
            obj.RI_AllApprove = new F_AllApprove()
            {
                AAP_Current_Approve = new F_Approve()
                {
                    PCode = 10,
                    PName = "10"
                },
            };


            var AddedObj = await _db.M_RequestInformations.AddAsync(obj);

            await _db.SaveChangesAsync();

            AddedObj.Entity.RI_AllApprove.AAP_Last_Approve = AddedObj.Entity.RI_AllApprove.AAP_Current_Approve;

            AddedObj.Entity.RI_AllApprove.AAP_Approves.Add(AddedObj.Entity.RI_AllApprove.AAP_Current_Approve);

            await _db.SaveChangesAsync();
            
            return AddedObj.Entity;

            //return _mapper.Map<M_RequestInformation, M_RequestInformationDTO>(AddedObj.Entity);
        }

        public async Task<F_RequestInformation> GetProcess(long id)
        {
            var obj = await _db.M_RequestInformations.FirstOrDefaultAsync(x => x.Id == id);

            if (obj != null)
            {
                return obj;
                //return _mapper.Map<M_RequestInformation, M_RequestInformationDTO>(obj);
            }

            return new F_RequestInformation();
        }
    }
}
