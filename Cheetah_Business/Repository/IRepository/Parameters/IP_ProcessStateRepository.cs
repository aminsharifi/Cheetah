﻿namespace Cheetah_Business.Repository.IRepository
{
    using Cheetah_DataAccess.Data;
    using Cheetah_Models;
    using Cheetah_Models.Parameters;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public interface IP_ProcessStateRepository
    {
        public Task<P_ProcessStateDTO> Create(P_ProcessStateDTO obj_DTO);
        public Task<P_ProcessStateDTO> Update(P_ProcessStateDTO obj_DTO);
        public Task<Int32> delete(long id);
        public Task<P_ProcessStateDTO> Get(long id);
        public Task<IEnumerable<P_ProcessStateDTO>> GetAll();
    }
}