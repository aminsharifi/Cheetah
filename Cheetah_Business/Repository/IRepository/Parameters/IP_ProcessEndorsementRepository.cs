﻿namespace Cheetah_Business.Repository.IRepository
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Cheetah_DataAccess.Systems;
    using Cheetah_Models;
    using Cheetah_Models.Parameters;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public interface IP_ProcessEndorsementRepository
    {
        public Task<P_ProcessEndorsementDTO> Create(P_ProcessEndorsementDTO obj_DTO);
        public Task<P_ProcessEndorsementDTO> Update(P_ProcessEndorsementDTO obj_DTO);
        public Task<Int32> delete(long id);
        public Task<P_ProcessEndorsementDTO> Get(long id);
        public Task<IEnumerable<P_ProcessEndorsementDTO>> GetAll();
    }
}
