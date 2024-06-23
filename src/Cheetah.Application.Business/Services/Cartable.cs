namespace Cheetah.Application.Business.Services;

public class Cartable(
    ISender iSender,
    IRepository<D_Process> processRepository,
    IReadRepository<F_WorkItem> workItemRepository,
    IReadRepository<F_Condition> conditionRepository,
    IReadRepository<D_User> userRepository,
    IReadRepository<F_Case> caseRepository,
    IReadRepository<D_CaseState> caseStateRepository,
    IReadRepository<F_Task> taskRepository,
    IReadRepository<F_Scenario> scenarioRepository
    ) : ICartable
{

    public async Task<Result<IEnumerable<CartableDTO>>> GetCartableAsync(CartableDTO cartableDTO)
    {
        if (cartableDTO.User is not null)
        {
            GetIdEntitySpec<D_User> _getIdEntitySpec = new(cartableDTO.User);

            var _userId = await userRepository.FirstOrDefaultAsync(_getIdEntitySpec);

            if (_userId.HasValue)
                cartableDTO.User.Id = _userId.Value;
        }
        if (cartableDTO.Process is not null)
        {
            GetIdEntitySpec<D_Process> _getIdEntitySpec = new(cartableDTO.Process);

            var _processId = await processRepository.FirstOrDefaultAsync(_getIdEntitySpec);

            if (_processId.HasValue)
                cartableDTO.Process.Id = _processId.Value;
        }
        if (cartableDTO.Scenario is not null)
        {
            GetIdEntitySpec<F_Scenario> _getIdEntitySpec = new(cartableDTO.Scenario);

            var _scenarioId = await scenarioRepository.FirstOrDefaultAsync(_getIdEntitySpec);

            if (_scenarioId.HasValue)
                cartableDTO.Scenario.Id = _scenarioId.Value;
        }
        if (cartableDTO.Case is not null)
        {
            GetIdEntitySpec<F_Case> _getIdEntitySpec = new(cartableDTO.Case);

            var _case = await caseRepository.FirstOrDefaultAsync(_getIdEntitySpec);

            if (_case.HasValue)
                cartableDTO.Case.Id = _case.Value;
        }
        if (cartableDTO.CaseState is not null)
        {
            GetIdEntitySpec<D_CaseState> _getIdEntitySpec = new(cartableDTO.CaseState);

            var _caseState = await caseStateRepository.FirstOrDefaultAsync(_getIdEntitySpec);

            if (_caseState.HasValue)
                cartableDTO.CaseState.Id = _caseState.Value;
        }
        if (cartableDTO.CaseStateList is not null)
        {
            var _caseStateList = cartableDTO.CaseStateList.ToList();

            for (int i = 0; i < _caseStateList.Count(); i++)
            {
                GetIdEntitySpec<D_CaseState> _getIdEntitySpec = new(_caseStateList[i]);
                var _caseState = await caseStateRepository.FirstOrDefaultAsync(_getIdEntitySpec);

                if (_caseState.HasValue)
                    _caseStateList[i].Id = _caseState.Value;
            }
            cartableDTO.CaseStateList = _caseStateList;
        }

        #region CartableProperty
        CartableProperty? _cartableProperty = default(CartableProperty); ;

        switch (cartableDTO.WorkItemState?.Id)
        {
            case long w when w == D_WorkItemState.Inbox.Id:
                _cartableProperty = CartableProperty.Inbox;
                break;
            case long w when w == D_WorkItemState.Sent.Id:
                _cartableProperty = CartableProperty.Outbox;
                break;
            default:
                _cartableProperty = CartableProperty.All;
                break;
        }
        #endregion

        var _GetCartableSpec = new GetCartableSpec(cartableDTO: cartableDTO, cartableProperty: _cartableProperty);
        var Records = await workItemRepository.ListAsync(_GetCartableSpec);
        var _totalItems = await workItemRepository.CountAsync(_GetCartableSpec);

        var Inbox = Records
        .Select(workItem =>
            new CartableDTO()
            {
                PageSize = cartableDTO.PageSize,
                PageNumber = cartableDTO.PageNumber,
                TotalItems = _totalItems,
                Case = workItem.Case.Adapt<SimpleClassDTO>(),
                CaseState = workItem?.Case?.CaseState.Adapt<SimpleClassDTO>(),
                WorkItem = workItem.Adapt<SimpleClassDTO>(),
                WorkItemState = workItem?.WorkItemState.Adapt<SimpleClassDTO>(),
                Summary = string.Empty
            }
            );

        var _inboxList = Inbox.ToList();

        for (int i = 0; i < _inboxList.LongCount(); i++)
        {
            var _Record = Records.First(x => x.Id == _inboxList[i]?.WorkItem?.Id);

            var _user = await userRepository.FirstOrDefaultAsync(new GetEntitySpec<D_User>(_Record.UserId));

            _inboxList[i].User = _user.Adapt<SimpleClassDTO>();

            var _requestor = await userRepository.FirstOrDefaultAsync(new GetEntitySpec<D_User>(_Record.Case.RequestorId));

            _inboxList[i].Requestor = _requestor.Adapt<SimpleClassDTO>();

            var _creator = await userRepository.FirstOrDefaultAsync(new GetEntitySpec<D_User>(_Record.Case.CreatorId));

            _inboxList[i].Creator = _creator.Adapt<SimpleClassDTO>();

            var _process = await processRepository.FirstOrDefaultAsync(new GetEntitySpec<D_Process>(_Record.Case.ProcessId));
            _inboxList[i].Process = _process.Adapt<SimpleClassDTO>();

            var _task = await taskRepository.FirstOrDefaultAsync(new GetEntitySpec<F_Task>(_Record.TaskId));
            _inboxList[i].Task = _task.Adapt<SimpleClassDTO>();

            var _flows = await iSender.Send(new GetFlowsByTaskQuery(_Record.TaskId));

            #region validUserActions

            var _validUserActions = _flows.Value.SelectMany(a => a.Flow.FlowConditions,
                 (a, b) =>
                 (
                     conditionRepository.FirstOrDefaultAsync(
                         new GetEntitySpec<F_Condition>(b.SecondId)).GetAwaiter().GetResult()
                 ).Adapt<SimpleClassDTO>());
            _inboxList[i].ValidUserActions = _validUserActions.ToList();

            #endregion

            #region occurredUserActions

            List<SimpleClassDTO> _occurredUserActions = new();

            foreach (var workItemCondition in _Record?.WorkItemConditions)
            {
                var _condition = await conditionRepository.FirstOrDefaultAsync(
                    new GetEntitySpec<F_Condition>(workItemCondition.SecondId));
                _occurredUserActions.Add(_condition.Adapt<SimpleClassDTO>());
            }

            _inboxList[i].OccurredUserActions = _occurredUserActions;

            #endregion

        }
        return _inboxList;
    }
    public async Task<Result<IEnumerable<CartableDTO>>> InboxAsync(CartableDTO cartableDTO)
    {
        cartableDTO.WorkItemState = D_WorkItemState.Inbox.Adapt<SimpleClassDTO>();

        var _GetCartableQuery = await GetCartableAsync(cartableDTO);

        return _GetCartableQuery;
    }
    public async Task<Result<IEnumerable<CartableDTO>>> OutboxAsync(CartableDTO cartableDTO)
    {
        cartableDTO.WorkItemState = D_WorkItemState.Sent.Adapt<SimpleClassDTO>();

        var _GetCartableQuery = await GetCartableAsync(cartableDTO);

        return _GetCartableQuery;
    }
}
