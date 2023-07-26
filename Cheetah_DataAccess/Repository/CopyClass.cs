using Cheetah_Business.Facts;
using Cheetah_Business.Repository;
using Cheetah_DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace Cheetah_DataAccess.Repository
{
    public static class CopyClass
    {
        public static async Task<F_Case> DeepCopy(this F_Case obj,ApplicationDbContext _db, ISync _iSync,
            ITableCRUD _itableCRUD)
        {
            var f_Case = (F_Case) obj.ShallowCopy();

            if (f_Case.CreatorId is null || f_Case.CreatorId == 0)
            {
                var creator = await _iSync.GetUser(obj.Creator.Name);
                obj.CreatorId = creator.Id;
                obj.Creator = null;
            }
            if (f_Case.RequestorId is null || f_Case.RequestorId == 0)
            {
                var requestor = await _iSync.GetUser(obj.Requestor.Name);
                obj.RequestorId = requestor.Id;
                obj.Requestor = null;
            }
            if (f_Case.ProcessId is null || f_Case.ProcessId == 0)
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
