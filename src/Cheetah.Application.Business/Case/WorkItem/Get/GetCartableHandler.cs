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

            if (_userId.HasValue)
                request.cartableDTO.User.Id = _userId.Value;
        }
        if (request.cartableDTO.Process is not null)
        {
            GetIdEntitySpec<D_Process> _getIdEntitySpec = new(request.cartableDTO.Process);

            var _processId = await _processRepository.FirstOrDefaultAsync(_getIdEntitySpec);

            if (_processId.HasValue)
                request.cartableDTO.Process.Id = _processId.Value;
        }

        if (request.cartableDTO.Scenario is not null)
        {
            GetIdEntitySpec<F_Scenario> _getIdEntitySpec = new(request.cartableDTO.Scenario);

            var _scenarioId = await _scenarioRepository.FirstOrDefaultAsync(_getIdEntitySpec);

            if (_scenarioId.HasValue)
                request.cartableDTO.Scenario.Id = _scenarioId.Value;
        }
        if (request.cartableDTO.CaseState is not null)
        {
            GetIdEntitySpec<D_CaseState> _getIdEntitySpec = new(request.cartableDTO.CaseState);

            var _caseState = await _caseStateRepository.FirstOrDefaultAsync(_getIdEntitySpec);

            if (_caseState.HasValue)
                request.cartableDTO.CaseState.Id = _caseState.Value;
        }
        if (request.cartableDTO.Case is not null)
        {
            GetIdEntitySpec<F_Case> _getIdEntitySpec = new(request.cartableDTO.Case);

            var _case = await _caseRepository.FirstOrDefaultAsync(_getIdEntitySpec);

            if (_case.HasValue)
                request.cartableDTO.Case.Id = _case.Value;
        }
        if (request.cartableDTO.CaseStateList is not null)
        {
            var _caseStateList = request.cartableDTO.CaseStateList.ToList();

            for (int i = 0; i < _caseStateList.Count(); i++)
            {
                GetIdEntitySpec<D_CaseState> _getIdEntitySpec = new(_caseStateList[i]);
                var _caseState = await _caseStateRepository.FirstOrDefaultAsync(_getIdEntitySpec);

                if (_caseState.HasValue)
                    _caseStateList[i].Id = _caseState.Value;
            }
            request.cartableDTO.CaseStateList = _caseStateList;
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

            _inboxList[i].ValidUserActions = _validUserActions.ToList();

            var _occurredUserActions = _Record.WorkItemConditions.Select(x => _iCopyClass.GetSimpleClass(
                _conditionRepository.FirstOrDefaultAsync(new GetEntitySpec<F_Condition>(x.SecondId)).GetAwaiter().GetResult()));

            _inboxList[i].OccurredUserActions = _occurredUserActions;

        }

        return _inboxList;
    }
}
