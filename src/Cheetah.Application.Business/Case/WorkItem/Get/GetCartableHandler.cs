namespace Cheetah.Application.Business.WorkItem.Get;

public class GetCartableHandler(
    IReadRepository<F_WorkItem> _WorkItemRepository,
    IReadRepository<D_Process> _processRepository,
    IReadRepository<F_Condition> _conditionRepository,
    IReadRepository<D_User> _userRepository,
    IReadRepository<F_Case> _caseRepository,
    IReadRepository<D_CaseState> _caseStateRepository,
    IReadRepository<F_Task> _taskRepository,
    IReadRepository<F_Scenario> _scenarioRepository,
    ISender _ISender, ICopyClass _iCopyClass)
  : IQueryHandler<GetCartableQuery, Result<IEnumerable<CartableDTO>>>
{
    public async Task<Result<IEnumerable<CartableDTO>>> Handle(GetCartableQuery request, CancellationToken cancellationToken)
    {
        if (request.cartableDTO.User is not null)
        {
            GetIdEntitySpec<D_User> _getIdEntitySpec = new(request.cartableDTO.User);

            var _userId = await _userRepository.FirstOrDefaultAsync(_getIdEntitySpec);

            request.cartableDTO.User = new() { Id = _userId.Value };
        }
        if (request.cartableDTO.Process is not null)
        {
            GetIdEntitySpec<D_Process> _getIdEntitySpec = new(request.cartableDTO.Process);

            var _processId = await _processRepository.FirstOrDefaultAsync(_getIdEntitySpec);

            request.cartableDTO.Process = new() { Id = _processId.Value };
        }

        if (request.cartableDTO.Scenario is not null)
        {
            GetIdEntitySpec<F_Scenario> _getIdEntitySpec = new(request.cartableDTO.Scenario);

            var _processId = await _scenarioRepository.FirstOrDefaultAsync(_getIdEntitySpec);

            request.cartableDTO.Scenario = new() { Id = _processId.Value };
        }
        if (request.cartableDTO.CaseState is not null)
        {
            GetIdEntitySpec<D_CaseState> _getIdEntitySpec = new(request.cartableDTO.CaseState);

            var _caseState = await _caseStateRepository.FirstOrDefaultAsync(_getIdEntitySpec);

            request.cartableDTO.CaseState = new() { Id = _caseState.Value };
        }

        var _GetCartableSpec = new GetCartableSpec(cartableDTO: request.cartableDTO, cartableProperty: request.cartableProperty);
        var Records = await _WorkItemRepository.ListAsync(_GetCartableSpec, cancellationToken);

        var _totalItems = await _WorkItemRepository.CountAsync(_GetCartableSpec, cancellationToken);

        var Inbox = Records
            .Select(x =>
            new CartableDTO()
            {
                PageSize = request.cartableDTO.PageSize,
                PageNumber = request.cartableDTO.PageNumber,
                TotalItems = _totalItems,
                Case = _iCopyClass.GetSimpleClass(x.Case),
                CaseState = _iCopyClass.GetSimpleClass(x.Case.CaseState),
                WorkItem = _iCopyClass.GetSimpleClass(x),
                WorkItemState = _iCopyClass.GetSimpleClass(x.WorkItemState),
                Summary = string.Empty
            }
            );

        var _inboxList = Inbox.ToList();

        for (int i = 0; i < _inboxList.LongCount(); i++)
        {
            var _Record = Records.First(x => x.Id == _inboxList[i].WorkItem.Id);

            var _process = await _processRepository.FirstOrDefaultAsync(new GetEntitySpec<D_Process>(_Record.Case.ProcessId));
            _inboxList[i].Process = _iCopyClass.GetSimpleClass(_process);

            var _user = await _userRepository.FirstOrDefaultAsync(new GetEntitySpec<D_User>(_Record.UserId));

            _inboxList[i].User = _iCopyClass.GetSimpleClass(_user);

            if (_Record.Case.RequestorId == 103)
            {

            }

            var _requestor = await _userRepository.FirstOrDefaultAsync(new GetEntitySpec<D_User>(_Record.Case.RequestorId));



            _inboxList[i].Requestor = _iCopyClass.GetSimpleClass(_requestor);

            var _creator = await _userRepository.FirstOrDefaultAsync(new GetEntitySpec<D_User>(_Record.Case.CreatorId));

            _inboxList[i].Creator = _iCopyClass.GetSimpleClass(_creator);

            var _task = await _taskRepository.FirstOrDefaultAsync(new GetEntitySpec<F_Task>(_Record.TaskId));

            _inboxList[i].Task = _iCopyClass.GetSimpleClass(_task);

            var _flows = await _ISender.Send(new GetFlowsByTaskQuery(_Record.TaskId));


            var _validUserActions = _flows.Value.SelectMany(a => a.Flow.FlowConditions,
            (a, b) => _iCopyClass.GetSimpleClass(
                _conditionRepository.FirstOrDefaultAsync(new GetEntitySpec<F_Condition>(b.SecondId)).GetAwaiter().GetResult()));

            _inboxList[i].ValidUserActions = _validUserActions;


            var _occurredUserActions = _Record.WorkItemConditions.Select(x => _iCopyClass.GetSimpleClass(
                _conditionRepository.FirstOrDefaultAsync(new GetEntitySpec<F_Condition>(x.SecondId)).GetAwaiter().GetResult()));

            _inboxList[i].OccurredUserActions = _occurredUserActions;

        }

        return _inboxList;
    }
}
