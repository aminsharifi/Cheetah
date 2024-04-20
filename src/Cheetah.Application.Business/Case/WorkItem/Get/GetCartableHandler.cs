namespace Cheetah.Application.Business.WorkItem.Get;

public class GetCartableHandler(
    IReadRepository<F_WorkItem> _WorkItemRepository,
    IReadRepository<D_Process> _processRepository,
    IReadRepository<F_Condition> _conditionRepository,
    IReadRepository<D_User> _userRepository,
    IReadRepository<F_Case> _caseRepository,
    IReadRepository<F_Task> _taskRepository,
    ISender _ISender, ICopyClass _iCopyClass)
  : IQueryHandler<GetCartableQuery, Result<IEnumerable<CartableDTO>>>
{
    public async Task<Result<IEnumerable<CartableDTO>>> Handle(GetCartableQuery request, CancellationToken cancellationToken)
    {
        var _GetCartableSpec = new GetCartableSpec(cartableDTO: request.cartableDTO, cartableProperty: request.cartableProperty);
        var Records = await _WorkItemRepository.ListAsync(_GetCartableSpec, cancellationToken);
        var Inbox = Records
            .Select(x =>
            new CartableDTO()
            {
                PageSize = request.cartableDTO.PageSize,
                PageNumber = request.cartableDTO.PageNumber,
                TotalItems = request.cartableDTO.TotalItems,
                Process = _iCopyClass
                .GetSimpleClass(
                    _processRepository
                    .FirstOrDefaultAsync(new GetEntitySpec<D_Process>(x.Case.ProcessId)).GetAwaiter().GetResult()),
                User = _iCopyClass.GetSimpleClass(
                _userRepository.FirstOrDefaultAsync(new GetEntitySpec<D_User>(x.UserId)).GetAwaiter().GetResult()),
                Case = _iCopyClass.GetSimpleClass(x.Case),
                Requestor = _iCopyClass.GetSimpleClass(
                    _userRepository.FirstOrDefaultAsync(new GetEntitySpec<D_User>(x.Case.RequestorId)).GetAwaiter().GetResult()),
                Creator = _iCopyClass.GetSimpleClass(
                    _userRepository.FirstOrDefaultAsync(new GetEntitySpec<D_User>(x.Case.CreatorId)).GetAwaiter().GetResult()),
                CaseState = _iCopyClass.GetSimpleClass(x.Case.CaseState),
                WorkItem = _iCopyClass.GetSimpleClass(x),
                WorkItemState = _iCopyClass.GetSimpleClass(x.WorkItemState),
                Task = _iCopyClass.GetSimpleClass(
                    _taskRepository.FirstOrDefaultAsync(new GetEntitySpec<F_Task>(x.TaskId)).GetAwaiter().GetResult()),
                ValidUserActions =
                (_ISender.Send(new GetFlowsByTaskQuery(x.TaskId)).GetAwaiter().GetResult().Value)
                .SelectMany(a => a.Flow.FlowConditions,
                (a, b) => _iCopyClass.GetSimpleClass(b.Condition)),
                OccurredUserActions = x.WorkItemConditions.Select(x => _iCopyClass.GetSimpleClass(
                    _conditionRepository.FirstOrDefaultAsync(new GetEntitySpec<F_Condition>(x.SecondId)).GetAwaiter().GetResult())),
                Summary = string.Empty
            }
            );
        return Inbox.ToList();
    }
}
