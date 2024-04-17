namespace Cheetah.Application.Services.gRPC.Services;

public class RequestService : Request.RequestBase
{
    public Presentation.Services.Shared.Services.RequestService G_RequestService;
    public ILogger<Presentation.Services.Shared.Services.RequestService> logger;
    public ApplicationDbContext db;
    public ITableCRUD simpleClassRepository;
    public ICartable iCartable;
    public IWorkItem iWorkItem;
    public ICopyClass iCopyClass;
    public ISync iSync;
    public IMediator _mediator;
    public RequestService(ILogger<Presentation.Services.Shared.Services.RequestService> GLogger,
        ApplicationDbContext GDb,
        ITableCRUD GSimpleClassRepository, ICartable GICartable, IWorkItem GIWorkItem,
        ICopyClass GICopyClass, ISync GISync, IMediator GMediator)
    {
        logger = GLogger;
        db = GDb;
        simpleClassRepository = GSimpleClassRepository;
        iCartable = GICartable;
        iWorkItem = GIWorkItem;
        iCopyClass = GICopyClass;
        iSync = GISync;
        _mediator = GMediator;

        G_RequestService = new Presentation.Services.Shared.Services.RequestService(
        logger, simpleClassRepository, iCartable, iWorkItem, iCopyClass, iSync, _mediator);
    }

    #region Public methods
    public override async Task<CreateRequest_Output> CreateRequest(CreateRequest_Input request, ServerCallContext context)
    {
        return await G_RequestService.CreateRequest(request);
    }
    public override async Task<GetCase_Output> GetCase(GetCase_Input request, ServerCallContext context)
    {
        logger.LogInformation("started " + nameof(GetCase) + " {@" + nameof(GetCase) + "}", request);

        #region Input
        var _request = request.Case?.GetSimpleClass<F_Case>();
        _request.CaseState = request.CaseState?.GetSimpleClass<D_CaseState>();
        _request.Process = request.Process?.GetSimpleClass<D_Process>();
        #endregion

        var _requests = await iCartable.GetCaseAsync(_request);

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

        output_Request.Case = G_RequestService.GetCase(_selectedRequests);

        output_Request.OutputState = OutputState<Boolean>
            .Success(nameof(GetCase), true)
            .SimpleClassDTO.GetBaseClassWithName();

        #endregion

        logger.LogInformation("Ended " + nameof(GetCase) + " {@" + nameof(GetCase) + "}", output_Request);

        return output_Request;
    }
    public override async Task<Cartable_Output> Inbox(Cartable_Input request, ServerCallContext context)
    {
        logger.LogInformation("started " + nameof(Inbox) + " {@" + nameof(Inbox) + "}", request);

        var output_Request = await Cartable(request, CartableProperty.Inbox);

        logger.LogInformation("Ended " + nameof(Inbox) + " {@" + nameof(Inbox) + "}", output_Request);

        return output_Request;
    }
    public override async Task<Cartable_Output> Outbox(Cartable_Input request, ServerCallContext context)
    {
        logger.LogInformation("started " + nameof(Outbox) + " {@" + nameof(Outbox) + "}", request);

        var output_Request = await Cartable(request, CartableProperty.Outbox);

        logger.LogInformation("Ended " + nameof(Outbox) + " {@" + nameof(Outbox) + "}", output_Request);

        return output_Request;
    }
    public override async Task<PerformRequest_Output> PerformRequest(PerformRequest_Input request, ServerCallContext context)
    {
        logger.LogInformation("started " + nameof(PerformRequest) + " {@" + nameof(PerformRequest) + "}", request);

        #region Input

        var f_WorkItem = request.WorkItem.GetWorkItemClass();

        #endregion

        var Outputresult = await iWorkItem.PerformWorkItemAsync(f_WorkItem, request.Rebase);

        #region Output

        var OutputState = Outputresult.SimpleClassDTO;

        PerformRequest_Output output_Request = new();

        output_Request.OutputState = OutputState.GetBaseClassWithName();

        if (!Outputresult.Result.IsSuccess)
        {
            return output_Request;
        }

        var _resultOfCase = Outputresult.Result.Value;

        output_Request.Case = G_RequestService.GetCase(_resultOfCase);

        output_Request.OutputState = OutputState.GetBaseClassWithName();

        #endregion

        logger.LogInformation("Ended " + nameof(PerformRequest) + " {@" + nameof(PerformRequest) + "}", output_Request);

        return output_Request;
    }
    public override async Task<GetAllByName_Output> GetAllByName(GetAllByName_Input request, ServerCallContext context)
    {

        var result = await _mediator.Send(new CreateTagCommand(Name: "Tag3", DisplayName: "تگ 3"));

        var result2 = await _mediator.Send(new GetTagIdQuery(new D_Tag() { Name = "Role" }));

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
    public override async Task<SetCaseTaskUser_Output> SetCaseTaskUser(SetCaseTaskUser_Input request, ServerCallContext context)
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
    public override async Task<SyncEntity_Output> SyncEntity(SyncEntity_Input request, ServerCallContext context)
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
    public override async Task<SyncLink_Output> SyncLink(SyncLink_Input request, ServerCallContext context)
    {
        logger.LogInformation("started " + nameof(SetCaseTaskUser) + " {@" + nameof(SetCaseTaskUser) + "}", request);

        #region Input

        foreach (var record in request.Records)
        {
            record.First.Id = await db.D_Users
                .Where(x => x.ERPCode == record.First.ERPCode)
                .AsNoTracking()
                .Select(x => x.Id)
                .FirstAsync();

            record.Second.Id = await db.F_Conditions
                .Where(x => x.ERPCode == record.Second.ERPCode)
                .AsNoTracking()
                .Select(x => x.Id)
                .FirstAsync();
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
    public override async Task<SyncCondition_Output> SyncCondition(SyncCondition_Input request, ServerCallContext context)
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

                var _retriveworkItem = await db
                .F_WorkItems
                   .Where(x => x.Id == _workItemId)
                   .AsNoTracking()
                   .SingleAsync();

                var _conditions = G_RequestService.GetConditions(_retriveworkItem);
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