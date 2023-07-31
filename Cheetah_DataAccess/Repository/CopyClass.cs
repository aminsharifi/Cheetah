using AutoMapper;
using Cheetah_Business.Facts;
using Cheetah_Business.Repository;
using Cheetah_DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace Cheetah_DataAccess.Repository
{
    public class CopyClass: ICopyClass
    {
        protected ApplicationDbContext _db;
        protected IMapper _mapper;
        protected ISync _iSync;
        protected ITableCRUD _itableCRUD;
        public CopyClass(ApplicationDbContext db, IMapper mapper, ISync iSync, ITableCRUD itableCRUD)
        {
            _db = db;
            _iSync = iSync;
            _itableCRUD = itableCRUD;
        }
        public async Task<F_Case> DeepCopy(F_Case obj)
        {
            if (obj.Conditions is not null
                   && obj.Conditions.Count > 0)
            {
                foreach (var item in obj.Conditions)
                {
                    item.TagId = await _db.D_Tags
                        .Where(x => x.Name == item.Tag.Name)
                        .AsNoTracking()
                        .Select(x => x.Id).SingleAsync();

                    item.Tag = null;
                }
            }

            if (obj.CreatorId is null || obj.CreatorId == 0)
            {
                var creator = await _iSync.GetUser(obj.Creator.Name);
                obj.CreatorId = creator.Id;
                obj.Creator = null;
            }
            if (obj.RequestorId is null || obj.RequestorId == 0)
            {
                var requestor = await _iSync.GetUser(obj.Requestor.Name);
                obj.RequestorId = requestor.Id;
                obj.Requestor = null;
            }
            if (obj.ProcessId is null || obj.ProcessId == 0)
            {
                var process = await _db.D_Processes
                    .Where(x => x.Name == obj.Process.Name)
                    .SingleAsync();
                obj.ProcessId = process.Id;
                obj.Process = null;
            }

            obj.CreateTimeRecord = DateTime.Now;
            obj = await _itableCRUD.Create(obj) as F_Case;
            return obj;
        }
    }
}
