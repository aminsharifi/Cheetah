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
        public Task<int> delete (int id);
        public Task<CopyROLEDTO> Get(int id);
        public Task<IEnumerable<CopyROLEDTO>> GetAll();
    }
}
