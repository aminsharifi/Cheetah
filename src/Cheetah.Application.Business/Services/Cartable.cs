﻿using Cheetah.Application.Business.Queries.Process.TaskCondition.List;
using Cheetah.Domain.Aggregates.ProcessAggregate.DTOs;
using Microsoft.Extensions.Logging;

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
    IReadRepository<F_Scenario> scenarioRepository,
    IMediator mediator, ILogger<Cartable> logger) : ICartable
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

            var _task = await taskRepository.FirstOrDefaultAsync(new GetTask(_Record.TaskId));
            _inboxList[i].Task = _task.Adapt<SimpleClassDTO>();
            _inboxList[i].Form = _task?.Form.Adapt<SimpleClassDTO>();

            var _flows = await iSender.Send(new ListFlowsByTaskQuery(_Record.TaskId));

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

    public async Task<Result<Cartable_Response>> GetCartableAsync(Cartable_Request request, CartableProperty? cartableProperty)
    {
        logger.LogInformation("started " + nameof(Cartable));
        logger.LogInformation("{@InputCartable}", request);

        #region Input

        var _assignee = request.Assignee?.Adapt<SimpleClassDTO>();
        var _process = request.Process?.Adapt<SimpleClassDTO>();
        var _caseState = request.CaseState?.Adapt<SimpleClassDTO>();
        var _caseStateList = request.CaseStateList?.Select(caseState => caseState.Adapt<SimpleClassDTO>());
        var _case = request.Case?.Adapt<SimpleClassDTO>();
        var _workItem = request.WorkItem?.Adapt<SimpleClassDTO>();

        CartableDTO cartableDTO = new()
        {
            User = _assignee,
            Process = _process,
            Case = _case,
            WorkItem = _workItem,
            CaseState = _caseState,
            CaseStateList = _caseStateList,
            PageSize = request.PageSize,
            PageNumber = request.PageNumber,
        };

        #endregion

        Result<IEnumerable<CartableDTO>> OutputRequest =
            (cartableProperty == CartableProperty.Inbox) ?
           await InboxAsync(cartableDTO) :
           ((cartableProperty == CartableProperty.Outbox) ?
           await OutboxAsync(cartableDTO) :
           await GetCartableAsync(cartableDTO));

        #region Output
        Cartable_Response _OutputCartable = new();

        _OutputCartable.Cases = new();

        if (OutputRequest.Value.Any())
        {
            _OutputCartable.TotalItems = OutputRequest.Value.FirstOrDefault()?.TotalItems.Value;
            _OutputCartable.PageSize = OutputRequest.Value.FirstOrDefault()?.PageSize.Value;
            _OutputCartable.PageNumber = OutputRequest.Value.FirstOrDefault()?.PageNumber.Value;

            foreach (CartableDTO outputRequestItem in OutputRequest.Value)
            {
                CaseDTO _Case = new()
                {
                    Base = outputRequestItem.Case.Adapt<BaseClassWithDateDTO>(),
                    CaseState = outputRequestItem.CaseState.Adapt<BaseClassWithNameDTO>(),
                    CreatorId = outputRequestItem?.Creator?.Id,
                    RequestorId = outputRequestItem?.Requestor?.Id,
                    ProcessId = outputRequestItem?.Process?.Id
                };

                #region Tasks

                TaskDTO _task = new();

                _task.Base = outputRequestItem?.Task.Adapt<BaseClassWithNameDTO>();

                _task.Form = outputRequestItem?.Form.Adapt<BaseClassWithNameDTO>();

                #region ValidUserActions
                var _taskValidUserActions = outputRequestItem!
                                .ValidUserActions
                                .Select(x => x.Id)
                                .ToList();

                var _validUserActions = await GetConditions(_taskValidUserActions);

                _task?.ValidUserActions?.AddRange(_validUserActions);

                #endregion

                #region Performers

                var _getDetailCasesQuery_Output = (await mediator
                                         .Send(new ListConditionsByTaskQuery(_task?.Base.Id)))
                                         .Value.FirstOrDefault();

                var _performers = await GetConditions
                    (new List<long>() { _getDetailCasesQuery_Output });

                _task?.Performers?.AddRange(_performers);

                #endregion

                #region WorkItem

                WorkItemDTO _gRPC_WorkItem = new();

                _gRPC_WorkItem.Base = outputRequestItem.WorkItem.Adapt<BaseClassWithNameAndDateDTO>();

                _gRPC_WorkItem.User = outputRequestItem.User.Adapt<BaseClassWithNameDTO>();

                _gRPC_WorkItem.WorkItemState = outputRequestItem.WorkItemState.Adapt<BaseClassWithNameDTO>();

                var _workItemId = _gRPC_WorkItem.Base.Id;

                GetWorkItemSpec _getEntitySpec = new
                    (new SimpleClassDTO() { Id = _workItemId.Value }, false);

                var _retriveworkItem = await workItemRepository.FirstOrDefaultAsync(_getEntitySpec);

                Guard.Against.Default(_retriveworkItem);

                var _workItemConditionIds = _retriveworkItem?.WorkItemConditions?
                    .Where(x => x.SecondId.HasValue)
                    .Select(x => x.SecondId!.Value);

                var _workItemConditions = await GetConditions(_workItemConditionIds);

                _task.WorkItems = new();

                if (_workItemConditions is not null)
                {
                    _gRPC_WorkItem?.OccurredUserActions?.AddRange(_workItemConditions);
                }

                _task.WorkItems.Add(_gRPC_WorkItem);

                #endregion

                _Case.Tasks = new();

                _Case.Tasks.Add(_task);

                #endregion

                _OutputCartable.Cases.Add(_Case);
            }
        }
        #endregion

        logger.LogInformation("Ended " + nameof(Cartable));
        logger.LogInformation("{@OutputCartable}", _OutputCartable);

        _OutputCartable.OutputState = new BaseClassWithNameDTO() { Id = 0 };

        return _OutputCartable;
    }

    public async Task<Result<IEnumerable<CartableDTO>>> InboxAsync(CartableDTO cartableDTO)
    {
        cartableDTO.WorkItemState = D_WorkItemState.Inbox.Adapt<SimpleClassDTO>();

        var _GetCartableQuery = await GetCartableAsync(cartableDTO);

        return _GetCartableQuery;
    }

    public async Task<Result<Cartable_Response>> InboxAsync(Cartable_Request request)
    {
        var _response = await GetCartableAsync(request, CartableProperty.Inbox);
        return _response;
    }

    public async Task<Result<IEnumerable<CartableDTO>>> OutboxAsync(CartableDTO cartableDTO)
    {
        cartableDTO.WorkItemState = D_WorkItemState.Sent.Adapt<SimpleClassDTO>();

        var _GetCartableQuery = await GetCartableAsync(cartableDTO);

        return _GetCartableQuery;
    }

    public async Task<Result<Cartable_Response>> OutboxAsync(Cartable_Request request)
    {
        var _response = await GetCartableAsync(request, CartableProperty.Outbox);
        return _response;
    }

    private async Task<IEnumerable<ConditionDTO>> GetConditions(IEnumerable<long> ConditionIds)
    {
        var Actual_Conditions = (await mediator.Send(new ListIncludedConditionsQuery(
            ConditionIds.Select(x => x)))).Value;

        return Actual_Conditions.GetConditions();
    }

}
