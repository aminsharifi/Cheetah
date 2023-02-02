namespace Cheetah_Business.Repository.IRepository
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Cheetah_Models;
    using Cheetah_Models.Parameters;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public interface IP_RequestTitleRepository
    {
        public Task<P_RequestTitleDTO> Create(P_RequestTitleDTO obj_DTO);
        public Task<P_RequestTitleDTO> Update(P_RequestTitleDTO obj_DTO);
        public Task<Int32> delete(long id);
        public Task<P_RequestTitleDTO> Get(long id);
        public Task<IEnumerable<P_RequestTitleDTO>> GetAll();
    }
}
