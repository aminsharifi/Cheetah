namespace Cheetah_Business.Repository.IRepository
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Cheetah_Models;
    using Cheetah_Models.Parameters;
    using Microsoft.EntityFrameworkCore.Metadata;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 
    public interface IBasePSClassRepository
    { 
        public IEnumerable<IEntityType> GetAllEntityType();
    }
}
