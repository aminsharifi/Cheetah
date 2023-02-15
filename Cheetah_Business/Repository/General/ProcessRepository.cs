namespace Cheetah_Business.Repository.IRepository.General
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Systems;
    using Cheetah_Models;
    using Cheetah_Models.Parameters;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Cheetah_Business.Repository.IRepository.General;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.EntityFrameworkCore.Metadata;
    using Cheetah_DataAccess.Masters;
    using Cheetah_DataAccess.Parameters;
    using CheetahDataAccess.Migrations;
    using Cheetah_Models.Masters;
    using System.Text.Json;
    using System.Security.Cryptography.X509Certificates;
    using Microsoft.EntityFrameworkCore;

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

        public async Task<M_RequestInformation> CreateProcess(String Input)
        {
            //var obj_DTO = JsonSerializer.Deserialize<M_RequestInformationDTO>(Input);
            //var obj = _mapper.Map<M_RequestInformationDTO, M_RequestInformation>(obj_DTO);

            var obj = JsonSerializer.Deserialize<M_RequestInformation>(Input);
            obj.RI_AllApprove = new M_AllApprove()
            {
                Current_M_Approve = new M_Approve()
                {
                    PCode = 10,
                    PName = "10"
                },
            };


            var AddedObj = await _db.M_RequestInformations.AddAsync(obj);

            await _db.SaveChangesAsync();

            AddedObj.Entity.RI_AllApprove.Last_M_Approve = AddedObj.Entity.RI_AllApprove.Current_M_Approve;

            AddedObj.Entity.RI_AllApprove.M_Approves.Add(AddedObj.Entity.RI_AllApprove.Current_M_Approve);

            await _db.SaveChangesAsync();
            
            return AddedObj.Entity;

            //return _mapper.Map<M_RequestInformation, M_RequestInformationDTO>(AddedObj.Entity);
        }

        public async Task<M_RequestInformation> GetProcess(long id)
        {
            var obj = await _db.M_RequestInformations.FirstOrDefaultAsync(x => x.IdRecord == id);

            if (obj != null)
            {
                return obj;
                //return _mapper.Map<M_RequestInformation, M_RequestInformationDTO>(obj);
            }

            return new M_RequestInformation();
        }
    }
}
