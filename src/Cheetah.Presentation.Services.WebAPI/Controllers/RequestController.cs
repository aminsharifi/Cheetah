using Cheetah.Application.Business.Case.WorkItem.Specifications;

namespace Cheetah.Presentation.Services.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class RequestController : ControllerBase
{
    private ILogger<RequestController> _logger;
    private ICartable _iCartable;
    private IWorkItem _iWorkItem;
    private ICopyClass _iCopyClass;
    private ISync _iSync;
    private IMediator _mediator;
    private IReadRepository<F_WorkItem> _workItemRepository;
    private IReadRepository<F_Task> _taskRepository;
    private IMapper _mapper;
    private ITableCRUD _simpleClassRepository;
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


        var _outputResult = await _iWorkItem.CreateRequestAsync(request);


        _logger.LogInformation("Ended " + nameof(CreateRequest) + " {@" + nameof(CreateRequest) + "}", _outputResult);

        return _outputResult;
    }

    [HttpPost(nameof(PerformRequest))]
    public async Task<PerformRequest_Response> PerformRequest([FromBody] PerformRequest_Request request)
    {
        _logger.LogInformation("started " + nameof(PerformRequest) + " {@" + nameof(PerformRequest) + "}", request);

        var _outputResult = await _iWorkItem.PerformWorkItemAsync(request);

        _logger.LogInformation("Ended " + nameof(PerformRequest) + " {@" + nameof(PerformRequest) + "}", _outputResult);

        return _outputResult;

    }

    [HttpPost(nameof(GetCases))]
    public async Task<Cartable_Response> GetCases([FromBody] Cartable_Request request)
    {
        _logger.LogInformation("started " + nameof(GetCases) + " {@" + nameof(GetCases) + "}", request);

        var output_Request = await Cartable(request, CartableProperty.All);

        _logger.LogInformation("Ended " + nameof(GetCases) + " {@" + nameof(GetCases) + "}", output_Request);

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
    private async Task<IEnumerable<ConditionDTO>> GetConditions(IEnumerable<long> ConditionIds)
    {
        var Actual_Conditions = (await _mediator.Send(new GetIncludedConditionsQuery(
            ConditionIds.Select(x => x)))).Value;

        return Actual_Conditions.GetConditions();
    }
    private async Task<Cartable_Response> Cartable(Cartable_Request request, CartableProperty? cartableProperty)
    {
        _logger.LogInformation("started " + nameof(Cartable));
        _logger.LogInformation("{@InputCartable}", request);

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
           await _iCartable.InboxAsync(cartableDTO) :
           ((cartableProperty == CartableProperty.Outbox) ?
           await _iCartable.OutboxAsync(cartableDTO) :
           await _iCartable.GetCartableAsync(cartableDTO));

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

                _task.Base = outputRequestItem.Task.Adapt<BaseClassWithNameDTO>();

                #region ValidUserActions
                var _taskValidUserActions = outputRequestItem!
                                .ValidUserActions
                                .Select(x => x.Id)
                                .ToList();

                var _validUserActions = await GetConditions(_taskValidUserActions);

                _task?.ValidUserActions?.AddRange(_validUserActions);

                #endregion

                #region Performers

                var _getDetailCasesQuery_Output = (await _mediator
                                         .Send(new GetConditionsByTaskQuery(_task?.Base.Id)))
                                         .Value.FirstOrDefault();

                var _performers = await GetConditions
                    (new List<long>() { _getDetailCasesQuery_Output });

                _task?.Performers?.AddRange(_performers);

                #endregion

                #region WorkItem

                WorkItemDTO _gRPC_WorkItem = new();

                _gRPC_WorkItem.Base = outputRequestItem.WorkItem.GetBaseClassWithNameAndDate(_mapper);

                _gRPC_WorkItem.User = outputRequestItem.User.GetBaseClassWithName(_mapper);

                _gRPC_WorkItem.WorkItemState = outputRequestItem.WorkItemState.GetBaseClassWithName(_mapper);


                var _workItemId = _gRPC_WorkItem.Base.Id;

                GetWorkItemSpec _getEntitySpec = new
                    (new SimpleClassDTO() { Id = _workItemId.Value }, false);

                var _retriveworkItem = await _workItemRepository.FirstOrDefaultAsync(_getEntitySpec);

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

        _logger.LogInformation("Ended " + nameof(Cartable));
        _logger.LogInformation("{@OutputCartable}", _OutputCartable);

        _OutputCartable.OutputState = new BaseClassWithNameDTO() { Id = 0 };

        return _OutputCartable;
    }

    #endregion
}