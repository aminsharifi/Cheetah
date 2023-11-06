namespace Cheetah.Infrastructure.Persistence.Repository;

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
    public async Task<List<CartableDTO>> GetCartable(CartableDTO cartableDTO,
 IQueryable<F_WorkItem> f_WorkItems)
    {
        if (cartableDTO.User is not null)
        {
            var UserID = await _iCopyClass.GetSimpleClassId(_db.D_Users, cartableDTO.User);

            f_WorkItems = f_WorkItems.Where(x => x.UserId == UserID);
        }
        if (cartableDTO.Process is not null)
        {
            var ProcessId = await _iCopyClass.GetSimpleClassId(_db.D_Processes, cartableDTO.Process);

            f_WorkItems = f_WorkItems.Where(x => x.Case.ProcessId == ProcessId);
        }
        if (cartableDTO.CaseState is not null)
        {
            var CaseStateId = await _iCopyClass.GetSimpleClassId(_db.D_CaseStates, cartableDTO.CaseState);

            f_WorkItems = f_WorkItems.Where(x => x.Case.CaseStateId == CaseStateId);
        }

        if (!string.IsNullOrEmpty(cartableDTO.RadNumber))
        {
            var radNumber = cartableDTO.RadNumber;
            f_WorkItems = f_WorkItems.Where(x => x.CaseId == long.Parse(radNumber));
        }

        var _D_Tags = await _db.D_Tags
            .Where(x => x.Id.Value == 201 || x.Id.Value == 202 || x.Id.Value == 203)
            .ToListAsync();

        var _SelectedTag = _D_Tags.Select(y => _iCopyClass.GetSimpleClass(y)).ToList();

        Int64 _PageSize = 0;

        Int64 _PageNumber = 0;

        var _Filterf_WorkItems = f_WorkItems;

        if (cartableDTO.PageSize is not null)
        {
            _PageSize = cartableDTO.PageSize.Value;

            _PageNumber = cartableDTO.PageNumber.Value;

            _Filterf_WorkItems = f_WorkItems.Skip(Convert.ToInt32(_PageSize * (_PageNumber - 1))).Take(Convert.ToInt32(_PageSize));
        }

        var _TotalItems = f_WorkItems.Count();

        var Records = await _Filterf_WorkItems.ToListAsync();

        var Inbox = Records
        .Select(x =>
        new CartableDTO()
        {
            Process = _iCopyClass.GetSimpleClass(x.Case.Process),
            User = _iCopyClass.GetSimpleClass(x.User),
            RadNumber = x.CaseId.ToString(),
            WorkItemId = x.Id.ToString(),
            Requestor = _iCopyClass.GetSimpleClass(x.Case.Requestor),
            Task = _iCopyClass.GetSimpleClass(x.Endorsement),
            CreateDate = x.Case.CreateTimeRecord,
            RecieveDate = x.CreateTimeRecord,
            Summary = string.Empty,
            PageSize = _PageSize,
            PageNumber = _PageNumber,
            TotalItems = _TotalItems,
            ERPCode = x.Case.ERPCode,
            Tag = _iCopyClass.GetSimpleClass(x.Tag),
            CaseState = _iCopyClass.GetSimpleClass(x.Case.CaseState),
            ValidUserActions = _SelectedTag
        }
        );

        return Inbox.ToList();
    }
    public async Task<List<CartableDTO>> Inbox(CartableDTO cartableDTO)
    {
        var inboxQuery = _db.F_WorkItems
            .Where(x =>
            x.Case.EnableRecord == true &&
            x.EnableRecord == true &&
            x.WorkItemStateId == 1);

        var inbox = await GetCartable(cartableDTO, inboxQuery);

        return inbox;
    }
    public async Task<List<CartableDTO>> Outbox(CartableDTO cartableDTO)
    {
        var outBoxQuery = _db.F_WorkItems
       .Where(x =>
       x.Case.EnableRecord == true &&
       x.EnableRecord == true &&
       x.WorkItemStateId == 2);

        var outBox = await GetCartable(cartableDTO, outBoxQuery);

        return outBox;
    }
}
