namespace Cheetah_Business.Repository.IRepository
{
    using AutoMapper;
    using Cheetah_DataAccess;
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Cheetah_Models;
    using Cheetah_Models.Parameters;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Threading.Tasks;
   
    public class BasePSClassRepository : IBasePSClassRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly IMapper _mapper;
        public BasePSClassRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
      
        public IEnumerable<IEntityType> GetAllEntityType()
        {
            return _db.Model.GetEntityTypes();
        }
    }
}