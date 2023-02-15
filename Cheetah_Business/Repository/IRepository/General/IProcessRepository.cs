namespace Cheetah_Business.Repository.IRepository.General
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Masters;
    using Cheetah_DataAccess.Systems;
    using Cheetah_Models;
    using Cheetah_Models.Masters;
    using Cheetah_Models.Parameters;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public interface IProcessRepository
    {
        public Task<M_RequestInformation> CreateProcess(String Input);
        public Task<M_RequestInformation> GetProcess(long id);
    }
}
