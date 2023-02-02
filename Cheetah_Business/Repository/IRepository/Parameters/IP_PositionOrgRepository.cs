namespace Cheetah_Business.Repository.IRepository
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


    public interface IP_PositionOrgRepository
    {
        public Task<P_PositionOrgDTO> Create(P_PositionOrgDTO obj_DTO);
        public Task<P_PositionOrgDTO> Update(P_PositionOrgDTO obj_DTO);
        public Task<Int32> delete(long id);
        public Task<P_PositionOrgDTO> Get(long id);
        public Task<IEnumerable<P_PositionOrgDTO>> GetAll();
    }
}
