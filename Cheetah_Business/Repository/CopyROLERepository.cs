using Cheetah_Business.Repository.IRepository;
using Cheetah_DataAccess.Data;
using Cheetah_Models;
using CheetahClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheetah_Business.Repository
{
    public class CopyROLERepository : ICopyROLERepository
    {
        private readonly ApplicationDbContext _db;
        public CopyROLERepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public CopyROLEDTO Create(CopyROLEDTO obj_DTO)
        {
            var _CopyROLE = new CopyROLE()
            {
                guidRole = new Guid(),
                idRole = obj_DTO.idRole,
                roleName = obj_DTO.roleName
            };
            _db.CopyROLEs.Add(_CopyROLE);
            _db.SaveChanges();

            return new CopyROLEDTO()
            {
                idRole = _CopyROLE.idRole,
                roleName = _CopyROLE.roleName
            };
        }

        public int delete(int id)
        {
            throw new NotImplementedException();
        }

        public CopyROLEDTO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CopyROLEDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public CopyROLEDTO Update(CopyROLEDTO obj_DTO)
        {
            throw new NotImplementedException();
        }
    }
}
