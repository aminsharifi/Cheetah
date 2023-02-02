using Cheetah_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheetah_Business.Repository.IRepository
{
    public interface ICopyROLERepository
    {
        public Task<CopyROLEDTO> Create(CopyROLEDTO obj_DTO);
        public Task<CopyROLEDTO> Update(CopyROLEDTO obj_DTO);
        public Task<Int32> delete (Int32 id);
        public Task<CopyROLEDTO> Get(Int32 id);
        public Task<IEnumerable<CopyROLEDTO>> GetAll();
    }
}
