using Cheetah_Business.Data;
using Cheetah_Business.Facts;
using Cheetah_Business.Repository;
using Cheetah_DataAccess.Data;
using Microsoft.EntityFrameworkCore;

namespace Cheetah_DataAccess.Repository
{
    public class Cartable : ICartable
    {
        protected ApplicationDbContext _db;

        public Cartable(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<F_Case> GetCaseAsync(F_Case request)
        {
            F_Case GeneralRequest = await _db.F_Cases
                .Include(x => x.Creator)
                .Include(x => x.Requestor)
                .Include(x => x.Process)
                .Include(x => x.SelectedScenario)
                .Include(x => x.Conditions)
                .Include(x => x.CaseState)
                .Include(x => x.WorkItems).ThenInclude(x => x.WorkItemState)
                .Include(x => x.WorkItems).ThenInclude(x => x.User)
                .SingleAsync(x => request.Id > 0 ? x.Id == request.Id :
                x.Process.Name == request.Process.Name &&
                x.ERPCode == request.ERPCode);

            return GeneralRequest;
        }
        public IQueryable<CartableDTO> GetCartable(CartableDTO cartableDTO,
     IQueryable<F_WorkItem> f_WorkItems)
        {
            if (!string.IsNullOrEmpty(cartableDTO.Username))
            {
                var username = cartableDTO.Username;
                f_WorkItems = f_WorkItems.Where(x => x.User.Name == username);
            }

            if (!string.IsNullOrEmpty(cartableDTO.ProcessName))
            {
                var processName = cartableDTO.ProcessName;
                f_WorkItems = f_WorkItems
                    .Where(x => x.Case.Process.Name == processName);
            }
            if (!string.IsNullOrEmpty(cartableDTO.RadNumber))
            {
                var radNumber = cartableDTO.RadNumber;
                f_WorkItems = f_WorkItems.Where(x => x.CaseId == long.Parse(radNumber));
            }

            var Inbox = f_WorkItems
            .Select(x =>
            new CartableDTO()
            {
                ProcessName = x.Case.Process.DisplayName,
                RadNumber = x.CaseId.ToString(),
                WorkItemId = x.Id.ToString(),
                Requestor = x.Case.Requestor.DisplayName,
                TaskName = x.Endorsement.DisplayName,
                CreateDate = x.Case.CreateTimeRecord,
                RecieveDate = x.CreateTimeRecord,
                Summary = string.Empty
            }
            );

            return Inbox;
        }
        public async Task<IEnumerable<CartableDTO>> Inbox(CartableDTO cartableDTO)
        {
            var inboxQuery = _db.F_WorkItems.Where(x => x.WorkItemStateId == 1);

            var inbox = GetCartable(cartableDTO, inboxQuery).AsEnumerable();

            return inbox.ToList();
        }
        public async Task<IEnumerable<CartableDTO>> Outbox(CartableDTO cartableDTO)
        {
            var outBoxQuery = _db.F_WorkItems.Where(x => x.WorkItemStateId == 2);

            var outBox = GetCartable(cartableDTO, outBoxQuery).AsEnumerable();

            return outBox.ToList();
        }
    }
}
