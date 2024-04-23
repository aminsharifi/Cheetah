namespace Cheetah.Presentation.Services.Shared.Services;

public class RequestService(ILogger<RequestService> logger,
        ITableCRUD simpleClassRepository, ICartable iCartable, IWorkItem iWorkItem,
        ICopyClass iCopyClass, ISync iSync, IMediator _mediator,
        IReadRepository<D_User> _userRepository,
        IReadRepository<F_Condition> _conditionRepository,
        IReadRepository<F_WorkItem> _workItemRepository
        ) : Request.RequestBase
{
    #region Public methods
    public Health_Output Health()
    {
        Health_Output _health_Output = new();
        _health_Output.DisplayName = "Ok!";
        return _health_Output;
    }
    public async Task<CreateRequest_Output> CreateRequest(CreateRequest_Input request)
    {
        logger.LogInformation("started " + nameof(CreateRequest) + " {@" + nameof(CreateRequest) + "}", request);

        #region Input

        F_Case _case = request.Case.GetSimpleClass<F_Case>();
        D_User _creator = request.Creator.GetSimpleClass<D_User>();
        D_User _requestor = request.Requestor.GetSimpleClass<D_User>();
        D_Process _process = request.Process.GetSimpleClass<D_Process>();
        List<F_Condition> _caseConditions = request.Conditions.GetConditions().ToList();
        D_User _workItem = request.WorkItem.User.GetSimpleClass<D_User>();
        var WorkItemConditions = new List<F_Condition>();
        #endregion

        var Outputresult = await iWorkItem.CreateRequestAsync(_case, _creator, _requestor, _process, _caseConditions, _workItem, WorkItemConditions);

        #region Output

        var OutputState = Outputresult.SimpleClassDTO;

        CreateRequest_Output output_Request = new();

        output_Request.OutputState = OutputState.GetBaseClassWithName();

        if (!Outputresult.Result.IsSuccess)
        {
            return output_Request;
        }

        _case = Outputresult.Result.Value;

        var _iCartable = await iCartable.GetCaseAsync(_case, _process);

        var _requests = _iCartable.Value.FirstOrDefault();

        output_Request.Case = await GetCase(_requests, _process, _creator, _requestor);

        #endregion

        logger.LogInformation("Ended " + nameof(CreateRequest) + " {@" + nameof(CreateRequest) + "}", output_Request);

        return output_Request;
    }
    public async Task<GetCase_Output> GetCase(GetCase_Input request)
    {
        logger.LogInformation("started " + nameof(GetCase) + " {@" + nameof(GetCase) + "}", request);

        #region Input
        var _request = request.Case?.GetSimpleClass<F_Case>();
        _request.CaseState = request.CaseState?.GetSimpleClass<D_CaseState>();
        D_Process _process = request.Process?.GetSimpleClass<D_Process>();
        #endregion

        var _requests = await iCartable.GetCaseAsync(_request, _process);

        #region Output

        GetCase_Output output_Request = new();

        if (!_requests.Value.Any())
        {
            output_Request.OutputState = OutputState<Boolean>
                .NotFoundErrorCreateRequest(false)
                .SimpleClassDTO
                .GetBaseClassWithName();

            return output_Request;
        }

        var _selectedRequests = _requests.Value.FirstOrDefault();

        //output_Request.Case = await GetCase(_selectedRequests);

        output_Request.OutputState = OutputState<Boolean>
            .Success(nameof(GetCase), true)
            .SimpleClassDTO.GetBaseClassWithName();

        #endregion

        logger.LogInformation("Ended " + nameof(GetCase) + " {@" + nameof(GetCase) + "}", output_Request);

        return output_Request;
    }
    public async Task<Cartable_Output> Inbox(Cartable_Input request)
    {
        logger.LogInformation("started " + nameof(Inbox) + " {@" + nameof(Inbox) + "}", request);

        var output_Request = await Cartable(request, CartableProperty.Inbox);

        logger.LogInformation("Ended " + nameof(Inbox) + " {@" + nameof(Inbox) + "}", output_Request);

        return output_Request;
    }
    public async Task<Cartable_Output> Outbox(Cartable_Input request)
    {
        logger.LogInformation("started " + nameof(Outbox) + " {@" + nameof(Outbox) + "}", request);

        var output_Request = await Cartable(request, CartableProperty.Outbox);

        logger.LogInformation("Ended " + nameof(Outbox) + " {@" + nameof(Outbox) + "}", output_Request);

        return output_Request;
    }
    public async Task<PerformRequest_Output> PerformRequest(PerformRequest_Input request)
    {
        logger.LogInformation("started " + nameof(PerformRequest) + " {@" + nameof(PerformRequest) + "}", request);

        #region Input

        var _workItem = request.WorkItem.GetWorkItemClass();
        var _user = request.WorkItem.User.GetSimpleClass<D_User>();

        #endregion

        var Outputresult = await iWorkItem.PerformWorkItemAsync(_workItem, _user, request.Rebase);

        #region Output

        var OutputState = Outputresult.SimpleClassDTO;

        PerformRequest_Output output_Request = new();

        output_Request.OutputState = OutputState.GetBaseClassWithName();

        if (!Outputresult.Result.IsSuccess)
        {
            return output_Request;
        }

        var _resultOfCase = Outputresult.Result.Value;

        //output_Request.Case = await GetCase(_resultOfCase);

        output_Request.OutputState = OutputState.GetBaseClassWithName();

        #endregion

        logger.LogInformation("Ended " + nameof(PerformRequest) + " {@" + nameof(PerformRequest) + "}", output_Request);

        return output_Request;
    }
    public async Task<GetAllByName_Output> GetAllByName(GetAllByName_Input request)
    {
        logger.LogInformation("started " + nameof(GetAllByName) + " {@" + nameof(GetAllByName) + "}", request);

        #region Input

        GetAllByName_Output output_Request = new();

        if (String.IsNullOrWhiteSpace(request.TableInput.Name))
        {
            return output_Request;
        }

        output_Request.TableInput = request.TableInput;

        #endregion

        var TableRecords = await simpleClassRepository.GetAllBySimpleClassAsync(output_Request.TableInput.GetSimpleClass<SimpleClassDTO>());

        #region Output

        output_Request.TableInput = TableRecords.Item1.GetBaseClassWithName();

        output_Request.TableOutput.AddRange(TableRecords.Item2.Select(x => x.GetBaseClassWithName()));

        output_Request.OutputState = OutputState<Boolean>.Success(nameof(GetAllByName), true).SimpleClassDTO.GetBaseClassWithName();

        #endregion

        logger.LogInformation("Ended " + nameof(GetAllByName) + " {@" + nameof(GetAllByName) + "}", output_Request);

        return output_Request;
    }
    public async Task<SetCaseTaskUser_Output> SetCaseTaskUser(SetCaseTaskUser_Input request)
    {
        logger.LogInformation("started " + nameof(SetCaseTaskUser) + " {@" + nameof(SetCaseTaskUser) + "}", request);

        #region Input

        L_CaseTaskUser l_CaseTaskUser = new();
        l_CaseTaskUser.Case = request.Case.GetSimpleClass<F_Case>();
        l_CaseTaskUser.Task = request.Task.GetSimpleClass<F_Task>();
        l_CaseTaskUser.User = request.User.GetSimpleClass<D_User>();

        #endregion

        var Outputresult = await iWorkItem.SetCaseTaskUserAsync(l_CaseTaskUser);

        #region Output

        var OutputState = Outputresult.SimpleClassDTO;

        SetCaseTaskUser_Output output_Request = new();

        output_Request.OutputState = OutputState.GetBaseClassWithName();

        if (!Outputresult.Result.IsSuccess)
        {
            return output_Request;
        }

        var _list_CaseTaskUser = Outputresult.Result.Value;

        output_Request.Case = Outputresult.Result.Value.Case.GetBaseClass();
        output_Request.Task = Outputresult.Result.Value.Task.GetBaseClassWithName();
        output_Request.User = Outputresult.Result.Value.User.GetBaseClassWithName();

        #endregion

        logger.LogInformation("Ended " + nameof(SetCaseTaskUser) + " {@" + nameof(SetCaseTaskUser) + "}", output_Request);

        return output_Request;
    }
    public async Task<SyncEntity_Output> SyncEntity(SyncEntity_Input request)
    {
        logger.LogInformation("started " + nameof(SetCaseTaskUser) + " {@" + nameof(SetCaseTaskUser) + "}", request);

        #region Input

        //L_CaseTaskUser l_CaseTaskUser = new();
        var output_Request = request.Base.GetSimpleClass<SimpleClassDTO>();

        #endregion

        var Outputresult = await iSync.SyncEntityAsync(output_Request, request.Records.Select
            (x => x.GetSimpleClass<SimpleClassDTO>()), (CrudOperation)request.Crud.Value);

        #region Output

        var _Result = new SyncEntity_Output();
        _Result.Result = Outputresult.Value.GetBaseClassWithName();
        _Result.OutputState = new GRPC_BaseClassWithName { Id = 0 };

        #endregion

        logger.LogInformation("Ended " + nameof(SetCaseTaskUser) + " {@" + nameof(SetCaseTaskUser) + "}", output_Request);

        return _Result;
    }
    public async Task<SyncLink_Output> SyncLink(SyncLink_Input request)
    {
        logger.LogInformation("started " + nameof(SetCaseTaskUser) + " {@" + nameof(SetCaseTaskUser) + "}", request);

        #region Input


        foreach (var record in request.Records)
        {
            GetIdEntitySpec<D_User> _getIdUserSpec = new(record.First.GetSimpleClass<D_User>());

            record.First.Id = await _userRepository.FirstOrDefaultAsync(_getIdUserSpec);

            GetIdEntitySpec<F_Condition> _getIdConditionSpec = new(record.First.GetSimpleClass<F_Condition>());

            record.First.Id = await _conditionRepository.FirstOrDefaultAsync(_getIdConditionSpec);
        }

        #endregion

        await iSync.SyncLinkAsync(request.Base.GetSimpleClass<SimpleClassDTO>(),
            request.Records
            .Select(x => new SimpleLinkClassDTO()
            {
                FirstId = x.First.Id,
                SecondId = x.Second.Id,
                ERPCode = x.ERPCode,
                EnableRecord = (x.EnableRecord is true)
            }),
            (CrudOperation)request.Crud.Value);

        #region Output

        var _Result = new SyncLink_Output();
        _Result.Result = request.Base;
        _Result.OutputState = new GRPC_BaseClassWithName { Id = 0 };

        #endregion

        logger.LogInformation("Ended " + nameof(SetCaseTaskUser) + " {@" + nameof(SetCaseTaskUser) + "}", _Result);

        return _Result;
    }
    public async Task<SyncCondition_Output> SyncCondition(SyncCondition_Input request)
    {
        logger.LogInformation("started " + nameof(SetCaseTaskUser) + " {@" + nameof(SetCaseTaskUser) + "}", request);

        #region Input

        var _Conditions = request.Records.GetConditions().ToList();

        #endregion

        await iSync.SyncConditionAsync(request.Base.GetSimpleClass<SimpleClassDTO>(), _Conditions, (CrudOperation)request.Crud.Value);

        #region Output

        var _Result = new SyncCondition_Output();
        _Result.Result = request.Base;
        _Result.OutputState = new GRPC_BaseClassWithName { Id = 0 };

        #endregion

        logger.LogInformation("Ended " + nameof(SetCaseTaskUser) + " {@" + nameof(SetCaseTaskUser) + "}", _Result);

        return _Result;
    }

    #endregion

    #region Private methods
    private List<L_CaseCondition> GetCaseCondition(List<F_Condition> Conditions)
    {
        List<L_CaseCondition> _caseConditions = new();

        foreach (var _condition in Conditions)
        {
            L_CaseCondition _CaseCondition = new()
            {
                SecondId = _condition.Id
            };

            _caseConditions.Add(_CaseCondition);
        }
        return _caseConditions;
    }
    private async Task<GRPC_Case> GetCase(F_Case _case, D_Process? Process, D_User? Creator, D_User? Requestor)
    {
        GRPC_Case _gRPC_Case = new()
        {
            Base = _case?.GetBaseClassWithDate(),
            CaseState = _case?.CaseState?.GetBaseClassWithName(),
            Process = Process?.GetBaseClassWithName(),
            Creator = Creator.GetBaseClassWithName(),
            Requestor = Requestor.GetBaseClassWithName()
        };

        #region Tasks

        var _getTasks = await _mediator.Send(new GetTasksFromScenarioQuery(_case.SelectedScenarioId));

        var Tasks = _getTasks.Value.ToList();

        _gRPC_Case.Tasks.AddRange(
            Tasks.Select(x => new GRPC_Task()
            {
                Base = x.GetBaseClassWithName()
            })
            );

        #endregion

        #region L_WorkItem

        foreach (var Task in _gRPC_Case.Tasks)
        {
            Task.WorkItems.AddRange(
            _case?.WorkItems
                .Where(x => x.TaskId == Task.Base.Id)
                .Select(x => new GRPC_WorkItem()
                {
                    Base = x.GetBaseClassWithDate(),
                    WorkItemState = x.WorkItemState?.GetBaseClassWithName()
                })
                );

            F_Task _task = Task.Base.GetSimpleClass<F_Task>();

            foreach (var workItem in Task.WorkItems)
            {
                var _WorkItem = _case?.WorkItems
                    .Where(x => x.Id == workItem.Base.Id)
                    .SingleOrDefault();

                var _conditions = GetConditions(_WorkItem, _task);
                workItem.ValidUserActions.AddRange(_conditions.ValidUserActions);
                workItem.OccurredUserActions.AddRange(_conditions.OccurredUserActions);
            }
        }

        #endregion

        return _gRPC_Case;
    }
    private GRPC_WorkItem GetConditions(F_WorkItem workItem, F_Task Task)
    {
        GRPC_WorkItem gRPC_WorkItem = new();


        #region OccurredUserActions

        /*
        var _occurredUserActions = workItem
            .WorkItemConditions
            .Select(x => x.Condition)
        .GetConditions();


        gRPC_WorkItem.OccurredUserActions.AddRange(_occurredUserActions);
        */

        #endregion

        #region ValidUserActions
        var _validUserActions = Task.TaskFlows
            .SelectMany(x => x.Flow.FlowConditions, (x, y) => y.Condition)
        .GetConditions();

        gRPC_WorkItem.ValidUserActions.AddRange(_validUserActions);
        #endregion


        return gRPC_WorkItem;
    }
    private async Task<Cartable_Output> Cartable(Cartable_Input request, CartableProperty cartableProperty)
    {
        logger.LogInformation("started " + nameof(Cartable));
        logger.LogInformation("{@InputCartable}", request);

        #region Input

        var _assignee = request.Assignee?.GetSimpleClass<SimpleClassDTO>();
        var _process = request.Process?.GetSimpleClass<SimpleClassDTO>();
        var _caseState = request.CaseState?.GetSimpleClass<SimpleClassDTO>();
        var _case = request.Case?.GetSimpleClass<SimpleClassDTO>();
        var _workItem = request.WorkItem?.GetSimpleClass<SimpleClassDTO>();

        var cartableDTO = new CartableDTO()
        {
            User = _assignee,
            Process = _process,
            Case = _case,
            WorkItem = _workItem,
            CaseState = _caseState,
            PageSize = request.PageSize,
            PageNumber = request.PageNumber,
        };

        #endregion

        var OutputRequest = ((cartableProperty == CartableProperty.Inbox) ?
           await iCartable.InboxAsync(cartableDTO) :
           await iCartable.OutboxAsync(cartableDTO));

        #region Output
        Cartable_Output _OutputCartable = new();


        if (OutputRequest.Value.Any())
        {
            _OutputCartable.TotalItems = OutputRequest.Value.FirstOrDefault()?.TotalItems.Value;
            _OutputCartable.PageSize = OutputRequest.Value.FirstOrDefault()?.PageSize.Value;
            _OutputCartable.PageNumber = OutputRequest.Value.FirstOrDefault()?.PageNumber.Value;


            foreach (var outputRequestItem in OutputRequest.Value)
            {
                GRPC_Case _Case = new()
                {
                    Base = outputRequestItem.Case.GetBaseClassWithDate(),
                    CaseState = outputRequestItem.CaseState.GetBaseClassWithName(),
                    Creator = outputRequestItem.Creator.GetBaseClassWithName(),
                    Requestor = outputRequestItem.Requestor.GetBaseClassWithName(),
                    Process = outputRequestItem.Process.GetBaseClassWithName()
                };

                GRPC_Task _task = new();

                _task.Base = outputRequestItem.Task.GetBaseClassWithName();

                GRPC_WorkItem _gRPC_WorkItem = new();

                _gRPC_WorkItem.Base = outputRequestItem.WorkItem.GetBaseClassWithDate();

                _gRPC_WorkItem.User = outputRequestItem.User.GetBaseClassWithName();

                _gRPC_WorkItem.WorkItemState = outputRequestItem.WorkItemState.GetBaseClassWithName();

                var _workItemId = _gRPC_WorkItem.Base.Id;

                GetEntitySpec<F_WorkItem> _getEntitySpec = new(_gRPC_WorkItem.Base.GetSimpleClass<F_WorkItem>());

                var _retriveworkItem = await _workItemRepository.FirstOrDefaultAsync(_getEntitySpec);

                var _f_task = _task.Base.GetSimpleClass<F_Task>();

                var _conditions = GetConditions(_retriveworkItem, _f_task);
                _gRPC_WorkItem.ValidUserActions.AddRange(_conditions.ValidUserActions);
                _gRPC_WorkItem.OccurredUserActions.AddRange(_conditions.OccurredUserActions);


                _task.WorkItems.Add(_gRPC_WorkItem);

                _Case.Tasks.Add(_task);

                _OutputCartable.Cases.Add(_Case);
            }
        }
        #endregion

        logger.LogInformation("Ended " + nameof(Cartable));
        logger.LogInformation("{@OutputCartable}", _OutputCartable);

        _OutputCartable.OutputState = OutputState<Boolean>
            .Success(nameof(Cartable), true)
            .SimpleClassDTO.GetBaseClassWithName();

        return _OutputCartable;
    }
    #endregion
}
