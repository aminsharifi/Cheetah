namespace Cheetah.Presentation.Services.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class RequestController : ControllerBase
{
    public ILogger<RequestController> _logger;
    public ICartable _iCartable;
    public IWorkItem _iWorkItem;
    public ICopyClass _iCopyClass;
    public ISync _iSync;
    public IMediator _mediator;
    public IReadRepository<F_WorkItem> _workItemRepository;
    public IReadRepository<F_Task> _taskRepository;
    public IMapper _mapper;
    public ITableCRUD _simpleClassRepository;
    public RequestController(
        ITableCRUD SimpleClassRepository,
        ILogger<RequestController> GLogger,
        ICartable GICartable, IWorkItem GIWorkItem,
        ICopyClass GICopyClass, ISync GISync, IMediator GMediator,
        IReadRepository<F_WorkItem> WorkItemRepository, IMapper GMapper,
        IReadRepository<F_Task> GtaskRepository
        )
    {
        _simpleClassRepository = SimpleClassRepository;
        _taskRepository = GtaskRepository;
        _logger = GLogger;
        _iCartable = GICartable;
        _iWorkItem = GIWorkItem;
        _iCopyClass = GICopyClass;
        _iSync = GISync;
        _mediator = GMediator;
        _workItemRepository = WorkItemRepository;
        _mapper = GMapper;
    }

    [HttpPost(nameof(CreateRequest))]
    public async Task<CreateRequest_Response> CreateRequest([FromBody] CreateRequest_Request request)
    {
        _logger.LogInformation("started " + nameof(CreateRequest) + " {@" + nameof(CreateRequest) + "}", request);

        #region Input

        SimpleClassDTO _case = request.Case.Adapt<SimpleClassDTO>();
        SimpleClassDTO _creator = request.Creator.Adapt<SimpleClassDTO>();
        SimpleClassDTO _requestor = request.Requestor.Adapt<SimpleClassDTO>();
        SimpleClassDTO _process = request.Process.Adapt<SimpleClassDTO>();
        List<ConditionDTO> _caseConditions = request?.Conditions;
        List<ConditionDTO> _workItemConditions = request.WorkItem.OccurredUserActions;
        SimpleClassDTO _workItemUser = request.WorkItem.User.Adapt<SimpleClassDTO>();
        SimpleClassDTO _workItemBase = request.WorkItem.Base.Adapt<SimpleClassDTO>();

        #endregion

        var _outputResult = await _iWorkItem.CreateRequestAsync
            (Request: _case, Creator: _creator, Requestor: _requestor,
            Process: _process, CaseConditions: _caseConditions, WorkItemUser: _workItemUser,
            WorkItemConditions: _workItemConditions, WorkItemBase: _workItemBase);

        #region Output

        CreateRequest_Response output_Request = new();

        if (_outputResult.IsSuccess is false)
        {
            output_Request.OutputState = new BaseClassWithNameDTO()
            {
                Id = 1,
                Name = _outputResult.Status.ToString(),
                DisplayName = $"شماره رهگیری {_outputResult.Errors.First()} تکراری است"
            };

            return output_Request;
        }

        output_Request.OutputState = new BaseClassWithNameDTO() { Id = 0 };

        long _createdCaseId = _outputResult.Value;

        GetCase_Request _getCase_Input = new()
        {
            Case = new BaseClassDTO()
            {
                Id = _createdCaseId
            }
        };

        GetCase_Response _getCase_Output = await GetCase(_getCase_Input);

        output_Request.Case = _getCase_Output.Case;

        #endregion

        _logger.LogInformation("Ended " + nameof(CreateRequest) + " {@" + nameof(CreateRequest) + "}", output_Request);

        return output_Request;
    }
    [HttpPost(nameof(GetCase))]
    public async Task<GetCase_Response> GetCase([FromBody] GetCase_Request request)
    {
        _logger.LogInformation("started " + nameof(GetCase) + " {@" + nameof(GetCase) + "}", request);

        #region Input
        SimpleClassDTO _request = request.Case?.Adapt<SimpleClassDTO>();
        SimpleClassDTO _process = request.Process?.Adapt<SimpleClassDTO>();
        #endregion

        var _requests = await _iCartable.GetCaseAsync(_request, _process);

        #region Output

        GetCase_Response output_Request = new();

        if (!_requests.IsSuccess)
        {
            output_Request.OutputState = new BaseClassWithNameDTO() { Id = 1 };

            return output_Request;
        }

        output_Request.OutputState = new BaseClassWithNameDTO() { Id = 0 };

        var _selectedRequests = _requests.Value.FirstOrDefault();

        if (_selectedRequests is null)
        {
            output_Request.OutputState = new BaseClassWithNameDTO()
            {
                Id = 1,
                Name = ResultStatus.NotFound.ToString(),
                DisplayName = $"چنین درخواستی یافت نشد"
            };

            return output_Request;
        }

        output_Request.Case = await GetCase(_selectedRequests);

        #endregion

        _logger.LogInformation("Ended " + nameof(GetCase) + " {@" + nameof(GetCase) + "}", output_Request);

        return output_Request;
    }
    [HttpPost(nameof(Inbox))]
    public async Task<Cartable_Response> Inbox([FromBody] Cartable_Request request)
    {
        _logger.LogInformation("started " + nameof(Inbox) + " {@" + nameof(Inbox) + "}", request);

        var output_Request = await Cartable(request, CartableProperty.Inbox);

        _logger.LogInformation("Ended " + nameof(Inbox) + " {@" + nameof(Inbox) + "}", output_Request);

        return output_Request;

    }
    [HttpPost(nameof(Outbox))]
    public async Task<Cartable_Response> Outbox([FromBody] Cartable_Request request)
    {
        _logger.LogInformation("started " + nameof(Outbox) + " {@" + nameof(Outbox) + "}", request);

        var output_Request = await Cartable(request, CartableProperty.Outbox);

        _logger.LogInformation("Ended " + nameof(Outbox) + " {@" + nameof(Outbox) + "}", output_Request);

        return output_Request;
    }
    [HttpPost(nameof(PerformRequest))]
    public async Task<PerformRequest_Response> PerformRequest([FromBody] PerformRequest_Request request)
    {
        _logger.LogInformation("started " + nameof(PerformRequest) + " {@" + nameof(PerformRequest) + "}", request);

        #region Input

        SimpleClassDTO _workItem = request.WorkItem.Base.Adapt<SimpleClassDTO>();
        SimpleClassDTO _workItemUser = request.WorkItem.User.Adapt<SimpleClassDTO>();
        List<ConditionDTO> _workItemConditions = request.WorkItem.OccurredUserActions;
        Boolean _rebase = request.Rebase ?? false;
        #endregion

        var Outputresult = await _iWorkItem.PerformWorkItemAsync
            (WorkItem: _workItem, WorkItemUser: _workItemUser,
            WorkItemConditions: _workItemConditions, Rebase: _rebase);

        #region Output

        PerformRequest_Response output_Request = new();

        if (!Outputresult.IsSuccess)
        {
            output_Request.OutputState = new BaseClassWithNameDTO() { Id = 1 };
            return output_Request;
        }

        output_Request.OutputState = new BaseClassWithNameDTO() { Id = 0 };

        long _createdCaseId = Outputresult.Value;

        GetCase_Request _getCase_Input = new()
        {
            Case = new BaseClassDTO()
            {
                Id = _createdCaseId
            }
        };

        GetCase_Response _getCase_Output = await GetCase(_getCase_Input);

        output_Request.Case = _getCase_Output.Case;

        #endregion

        _logger.LogInformation("Ended " + nameof(PerformRequest) + " {@" + nameof(PerformRequest) + "}", output_Request);

        return output_Request;

    }
    [HttpPost(nameof(GetAllByName))]
    public async Task<GetAllByName_Response> GetAllByName([FromBody] GetAllByName_Request request)
    {
        _logger.LogInformation("started " + nameof(GetAllByName) + " {@" + nameof(GetAllByName) + "}", request);

        #region Input

        GetAllByName_Response output_Request = new();

        if (String.IsNullOrWhiteSpace(request.TableInput.Name))
        {
            return output_Request;
        }

        output_Request.TableInput = request.TableInput;

        #endregion

        var TableRecords = await _simpleClassRepository
            .GetAllBySimpleClassAsync(
            output_Request.TableInput.Adapt<SimpleClassDTO>());

        #region Output

        output_Request.TableInput = TableRecords.Item1.Adapt<BaseClassWithNameDTO>();

        output_Request.TableOutput
            .AddRange(TableRecords.Item2
            .Select(x => x.Adapt<BaseClassWithNameDTO>()));

        output_Request.OutputState = new BaseClassWithNameDTO() { Id = 0 };

        #endregion

        _logger.LogInformation("Ended " + nameof(GetAllByName) + " {@" + nameof(GetAllByName) + "}", output_Request);

        return output_Request;

    }
    [HttpPost(nameof(SetCaseTaskUser))]
    public async Task<SetCaseTaskUser_Response> SetCaseTaskUser([FromBody] SetCaseTaskUser_Request request)
    {
        return await SetCaseTaskUser(request);
    }
    [HttpPost(nameof(SyncEntity))]
    public async Task<SyncEntity_Response> SyncEntity([FromBody] SyncEntity_Request request)
    {
        return await SyncEntity(request);
    }
    [HttpPost(nameof(SyncLink))]
    public async Task<SyncLink_Response> SyncLink([FromBody] SyncLink_Request request)
    {
        return await SyncLink(request);
    }
    [HttpPost(nameof(SyncCondition))]
    public async Task<SyncCondition_Response> SyncCondition([FromBody] SyncCondition_Request request)
    {
        return await SyncCondition(request);
    }
    #region Private methods
    private async Task<CaseDTO> GetCase(F_Case _selectedRequests)
    {
        CaseDTO _gRPC_Case = new();

        _gRPC_Case.Base = _selectedRequests.Adapt<BaseClassWithDateDTO>();
        _gRPC_Case.CaseState = _selectedRequests.CaseState.Adapt<BaseClassWithNameDTO>();
        _gRPC_Case.RequestorId = _selectedRequests.RequestorId;
        _gRPC_Case.CreatorId = _selectedRequests.CreatorId;
        _gRPC_Case.ProcessId = _selectedRequests.ProcessId;

        _gRPC_Case.Tasks = new();

        var _distincTaskIds = _selectedRequests.WorkItems.Select(x => x.TaskId).Distinct();

        var _getTasks = await _mediator.Send(new GetTasksFromScenarioQuery(_selectedRequests.SelectedScenarioId));

        var _Tasks = _getTasks.Value.ToList();

        foreach (var _Task in _Tasks)
        {
            TaskDTO _gRPC_Task = new() { Base = _Task.Adapt<BaseClassWithNameDTO>() };

            var _taskFlowConditionsIds = _Task.TaskFlows
                .SelectMany(parent => parent.Flow.FlowConditions, (parent, child) => child.SecondId)
                .Where(x => x.HasValue)
                .Select(x => x.Value);


            var _taskFlowConditions = await GetConditions(_taskFlowConditionsIds);

            _gRPC_Task.ValidUserActions = new();

            _gRPC_Task.ValidUserActions.AddRange(_taskFlowConditions);

            #region Performers

            var _taskConditionsIds = _Task.TaskConditions
                .Select(x => x.SecondId.Value);

            var _taskConditions = await GetConditions(_taskConditionsIds);

            _gRPC_Task.Performers = new();

            _gRPC_Task.Performers.AddRange(_taskConditions);

            #endregion

            _gRPC_Task.WorkItems = new();
            foreach (var WorkItem in _selectedRequests.WorkItems.Where(x => x.TaskId == _Task.Id))
            {
                WorkItemDTO _gRPC_WorkItem = new();
                _gRPC_WorkItem.Base = WorkItem.Adapt<BaseClassWithNameAndDateDTO>();
                _gRPC_WorkItem.WorkItemState = WorkItem.WorkItemState.Adapt<BaseClassWithNameDTO>();
                _gRPC_WorkItem.User = new BaseClassWithNameDTO() { Id = WorkItem.UserId };
                _gRPC_WorkItem.OccurredUserActions = new();

                var _workItemConditionsIds = WorkItem.WorkItemConditions
                    .Select(x => x.SecondId.Value);

                var _workItemConditions = await GetConditions(_workItemConditionsIds);

                _gRPC_WorkItem.OccurredUserActions.AddRange(_workItemConditions);

                _gRPC_Task.WorkItems.Add(_gRPC_WorkItem);
            }
            _gRPC_Case.Tasks.Add(_gRPC_Task);
        }
        return _gRPC_Case;
    }
    private async Task<IEnumerable<ConditionDTO>> GetConditions(IEnumerable<long> ConditionIds)
    {
        var Actual_Conditions = (await _mediator.Send(new GetIncludedConditionsQuery(
            ConditionIds.Select(x => x)))).Value;

        return Actual_Conditions.GetConditions(_mapper);
    }
    private async Task<Cartable_Response> Cartable(Cartable_Request request, CartableProperty cartableProperty)
    {
        _logger.LogInformation("started " + nameof(Cartable));
        _logger.LogInformation("{@InputCartable}", request);

        #region Input

        var _assignee = request.Assignee?.Adapt<SimpleClassDTO>();
        var _process = request.Process?.Adapt<SimpleClassDTO>();
        var _caseState = request.CaseState?.Adapt<SimpleClassDTO>();
        var _caseStateList = request.CaseStateList?
            .Select(caseState => caseState.Adapt<SimpleClassDTO>());
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

        var OutputRequest = ((cartableProperty == CartableProperty.Inbox) ?
           await _iCartable.InboxAsync(cartableDTO) :
           await _iCartable.OutboxAsync(cartableDTO));

        #region Output
        Cartable_Response _OutputCartable = new();

        _OutputCartable.Cases = new();

        if (OutputRequest.Value.Any())
        {
            _OutputCartable.TotalItems = OutputRequest.Value.FirstOrDefault()?.TotalItems.Value;
            _OutputCartable.PageSize = OutputRequest.Value.FirstOrDefault()?.PageSize.Value;
            _OutputCartable.PageNumber = OutputRequest.Value.FirstOrDefault()?.PageNumber.Value;

            foreach (var outputRequestItem in OutputRequest.Value)
            {
                CaseDTO _Case = new()
                {
                    Base = outputRequestItem.Case.Adapt<BaseClassWithDateDTO>(),
                    CaseState = outputRequestItem.CaseState.Adapt<BaseClassWithNameDTO>(),
                    CreatorId = outputRequestItem.Creator.Id,
                    RequestorId = outputRequestItem.Requestor.Id,
                    ProcessId = outputRequestItem.Process.Id
                };

                TaskDTO _task = new();

                _task.ValidUserActions = new();

                var _taskValidUserActions = outputRequestItem
                    .ValidUserActions
                    .Select(x => x.Id)
                    .ToList();

                var _validUserActions = await GetConditions(_taskValidUserActions);

                _task.ValidUserActions.AddRange(_validUserActions);







                _task.Base = outputRequestItem.Task.GetBaseClassWithName(_mapper);

                var _f_task = _task.Base.GetSimpleClass<F_Task>(_mapper);

                WorkItemDTO _gRPC_WorkItem = new();

                _gRPC_WorkItem.Base = outputRequestItem.WorkItem.GetBaseClassWithNameAndDate(_mapper);

                _gRPC_WorkItem.User = outputRequestItem.User.GetBaseClassWithName(_mapper);

                _gRPC_WorkItem.WorkItemState = outputRequestItem.WorkItemState.GetBaseClassWithName(_mapper);

                var _workItemId = _gRPC_WorkItem.Base.Id;

                GetEntitySpec<F_WorkItem> _getEntitySpec = new(_workItemId);

                var _retriveworkItem = await _workItemRepository.FirstOrDefaultAsync(_getEntitySpec);

                var _workItemConditionIds = _retriveworkItem
                    .WorkItemConditions
                    .Where(x => x.SecondId.HasValue)
                    .Select(x => x.SecondId.Value);

                var _workItemConditions = await GetConditions(_workItemConditionIds);

                _task.WorkItems = new();

                if (_workItemConditions is not null)
                {
                    _gRPC_WorkItem.OccurredUserActions = new();
                    _gRPC_WorkItem.OccurredUserActions.AddRange(_workItemConditions);
                }

                _task.WorkItems.Add(_gRPC_WorkItem);

                _Case.Tasks = new();

                _Case.Tasks.Add(_task);

                _OutputCartable.Cases.Add(_Case);
            }
        }
        #endregion

        _logger.LogInformation("Ended " + nameof(Cartable));
        _logger.LogInformation("{@OutputCartable}", _OutputCartable);

        _OutputCartable.OutputState = new BaseClassWithNameDTO() { Id = 0 };

        return _OutputCartable;
    }
    #endregion
}