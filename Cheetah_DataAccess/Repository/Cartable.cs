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
        protected ICopyClass _iCopyClass;

        public Cartable(ApplicationDbContext db, ICopyClass iCopyClass)
        {
            _db = db;
            _iCopyClass = iCopyClass;
        }
        public async Task<IQueryable<F_Case>> GetCaseAsync(F_Case request)
        {
            var GeneralRequest = _db.F_Cases
                .Include(x => x.Creator)
                .Include(x => x.Requestor)
                .Include(x => x.Process)
                .Include(x => x.SelectedScenario)
                .Include(x => x.Conditions)
                .Include(x => x.CaseState)
                .Include(x => x.WorkItems)
                .ThenInclude(x => x.WorkItemState)
                .Include(x => x.WorkItems)
                .ThenInclude(x => x.User)
                .AsNoTracking();



            if (request.ProcessId > 0)
            {
                GeneralRequest = GeneralRequest.Where(x => x.ProcessId == request.ProcessId);
            }
            if (request.CaseStateId > 0)
            {
                GeneralRequest = GeneralRequest.Where(x => x.CaseStateId == request.CaseStateId);
            }
            if (request.ERPCode > 0)
            {
                GeneralRequest = GeneralRequest.Where(x => x.ERPCode == request.ERPCode);
            }
            if (request.Id > 0)
            {
                GeneralRequest = GeneralRequest.Where(x => x.Id == request.Id);
            }
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
            if (!String.IsNullOrEmpty(cartableDTO.CaseState?.Name))
            {
                f_WorkItems = f_WorkItems
                    .Where(x => x.Case.CaseState.Name == cartableDTO.CaseState.Name);
            }

            if (cartableDTO.CaseState?.ERPCode is not null && cartableDTO.CaseState?.ERPCode > 0)
            {
                f_WorkItems = f_WorkItems
                    .Where(x => x.Case.CaseState.ERPCode == cartableDTO.CaseState.ERPCode);
            }

            int _PageSize = 0;

            int _PageNumber = 0;

            var _Filterf_WorkItems = f_WorkItems;

            if (cartableDTO.PageSize is not null)
            {
                _PageSize = cartableDTO.PageSize.Value;

                _PageNumber = cartableDTO.PageNumber.Value;

                _Filterf_WorkItems = f_WorkItems.Skip(_PageSize * (_PageNumber - 1)).Take(_PageSize);
            }

            var _TotalItems = f_WorkItems.Count();

            var Inbox = _Filterf_WorkItems
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
                Summary = string.Empty,
                PageSize = _PageSize,
                PageNumber = _PageNumber,
                TotalItems = _TotalItems,
                ERPCode = x.Case.ERPCode,
                Tag = new SimpleClassDTO()
                {
                    Id = x.Tag.Id.Value,
                    Name = x.Tag.Name,
                    DisplayName = x.Tag.DisplayName,
                    ERPCode = x.Tag.ERPCode
                },
                CaseState = new SimpleClassDTO()
                {
                    Id = x.Case.CaseState.Id,
                    Name = x.Case.CaseState.Name,
                    DisplayName = x.Case.CaseState.DisplayName,
                    ERPCode = x.Case.CaseState.ERPCode
                },
                ValidUserActions = _db.D_Tags
                .Where(x=>x.Id.Value == 201 || x.Id.Value == 202 || x.Id.Value == 203)
                .Select
                (y => new SimpleClassDTO()
                {
                    Id = y.Id,
                    Name = y.Name,
                    DisplayName = y.DisplayName,
                    ERPCode = y.ERPCode
                })
            }
            );

            return Inbox;
        }
        public async Task<IQueryable<CartableDTO>> Inbox(CartableDTO cartableDTO)
        {
            var inboxQuery = _db.F_WorkItems.Where(x => x.WorkItemStateId == 1);

            var inbox = GetCartable(cartableDTO, inboxQuery);

            return inbox;
        }
        public async Task<IQueryable<CartableDTO>> Outbox(CartableDTO cartableDTO)
        {
            var outBoxQuery = _db.F_WorkItems.Where(x => x.WorkItemStateId == 2);

            var outBox = GetCartable(cartableDTO, outBoxQuery);

            return outBox;
        }
    }
}
