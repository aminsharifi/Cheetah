namespace Cheetah_Business.Repository.IRepository
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Cheetah_Models;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public interface IP_UserActionGroupRepository
    {
        public Task<P_UserActionGroupDTO> Create(P_UserActionGroupDTO obj_DTO);
        public Task<P_UserActionGroupDTO> Update(P_UserActionGroupDTO obj_DTO);
        public Task<Int32> delete(long id);
        public Task<P_UserActionGroupDTO> Get(long id);
        public Task<IEnumerable<P_UserActionGroupDTO>> GetAll();
    }
}
