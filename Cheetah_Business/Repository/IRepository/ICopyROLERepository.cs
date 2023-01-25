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
        public CopyROLEDTO Create(CopyROLEDTO obj_DTO);
        public CopyROLEDTO Update(CopyROLEDTO obj_DTO);
        public int delete (int id);
        public CopyROLEDTO Get(int id);
        public IEnumerable<CopyROLEDTO> GetAll();

    }
}
