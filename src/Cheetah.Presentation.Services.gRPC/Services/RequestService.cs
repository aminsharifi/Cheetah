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

        G_RequestService = new Presentation.Services.Shared.Services.RequestService(db,
        logger, simpleClassRepository, iCartable, iWorkItem, iCopyClass, iSync, _mediator);
    }

    #region Public methods
    public override async Task<CreateRequest_Output> CreateRequest(CreateRequest_Input request, ServerCallContext context)
    {
        return await G_RequestService.CreateRequest(request);
    }
    public override async Task<GetCase_Output> GetCase(GetCase_Input request, ServerCallContext context)
    {        
        return await G_RequestService.GetCase(request);
    }
    public override async Task<Cartable_Output> Inbox(Cartable_Input request, ServerCallContext context)
    {
        return await G_RequestService.Inbox(request);
    }
    public override async Task<Cartable_Output> Outbox(Cartable_Input request, ServerCallContext context)
    {
        return await G_RequestService.Outbox(request);
    }
    public override async Task<PerformRequest_Output> PerformRequest(PerformRequest_Input request, ServerCallContext context)
    {
        return await G_RequestService.PerformRequest(request);
    }
    public override async Task<GetAllByName_Output> GetAllByName(GetAllByName_Input request, ServerCallContext context)
    {
        return await G_RequestService.GetAllByName(request);
    }
    public override async Task<SetCaseTaskUser_Output> SetCaseTaskUser(SetCaseTaskUser_Input request, ServerCallContext context)
    {
        return await G_RequestService.SetCaseTaskUser(request);
    }
    public override async Task<SyncEntity_Output> SyncEntity(SyncEntity_Input request, ServerCallContext context)
    {
        return await G_RequestService.SyncEntity(request);
    }
    public override async Task<SyncLink_Output> SyncLink(SyncLink_Input request, ServerCallContext context)
    {
        return await G_RequestService.SyncLink(request);
    }
    public override async Task<SyncCondition_Output> SyncCondition(SyncCondition_Input request, ServerCallContext context)
    {
        return await G_RequestService.SyncCondition(request);
    }
    #endregion
      
}