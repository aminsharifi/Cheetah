namespace Cheetah.Presentation.Services.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class RequestController : ControllerBase
{
    public Shared.Services.RequestService G_RequestService;
    public RequestController(ILogger<Shared.Services.RequestService> GLogger,       
        ITableCRUD GSimpleClassRepository, ICartable GICartable, IWorkItem GIWorkItem,
        ICopyClass GICopyClass, ISync GISync, IMediator GMediator,
        IReadRepository<D_User> _userRepository,
        IReadRepository<F_Condition> _conditionRepository,
        IReadRepository<F_WorkItem> _workItemRepository
        )
    {
        G_RequestService = new Shared.Services.RequestService(
        GLogger, GSimpleClassRepository, GICartable, GIWorkItem, GICopyClass, GISync, GMediator,
        _userRepository, _conditionRepository, _workItemRepository);
    }   

    [HttpGet(nameof(Health))]
    public Health_Output Health()
    {
        return G_RequestService.Health();
    }

    [HttpPost(nameof(CreateRequest))]
    public async Task<Cheetah_GrpcService.CreateRequest_Output> CreateRequest([FromBody] Cheetah_GrpcService.CreateRequest_Input request)
    {
        return await G_RequestService.CreateRequest(request);
    }


    [HttpPost(nameof(GetCase))]
    public async Task<Cheetah_GrpcService.GetCase_Output> GetCase([FromBody] Cheetah_GrpcService.GetCase_Input request)
    {
        return await G_RequestService.GetCase(request);
    }
    [HttpPost(nameof(Inbox))]
    public async Task<Cheetah_GrpcService.Cartable_Output> Inbox([FromBody] Cheetah_GrpcService.Cartable_Input request)
    {
        return await G_RequestService.Inbox(request);
    }
    [HttpPost(nameof(Outbox))]
    public async Task<Cheetah_GrpcService.Cartable_Output> Outbox([FromBody] Cheetah_GrpcService.Cartable_Input request)
    {
        return await G_RequestService.Outbox(request);
    }
    [HttpPost(nameof(PerformRequest))]
    public async Task<Cheetah_GrpcService.PerformRequest_Output> PerformRequest([FromBody] Cheetah_GrpcService.PerformRequest_Input request)
    {
        return await G_RequestService.PerformRequest(request);
    }
    [HttpPost(nameof(GetAllByName))]
    public async Task<Cheetah_GrpcService.GetAllByName_Output> GetAllByName([FromBody] Cheetah_GrpcService.GetAllByName_Input request)
    {
        return await G_RequestService.GetAllByName(request);
    }
    [HttpPost(nameof(SetCaseTaskUser))]
    public async Task<Cheetah_GrpcService.SetCaseTaskUser_Output> SetCaseTaskUser([FromBody] Cheetah_GrpcService.SetCaseTaskUser_Input request)
    {
        return await G_RequestService.SetCaseTaskUser(request);
    }
    [HttpPost(nameof(SyncEntity))]
    public async Task<Cheetah_GrpcService.SyncEntity_Output> SyncEntity([FromBody] Cheetah_GrpcService.SyncEntity_Input request)
    {
        return await G_RequestService.SyncEntity(request);
    }
    [HttpPost(nameof(SyncLink))]
    public async Task<Cheetah_GrpcService.SyncLink_Output> SyncLink([FromBody] Cheetah_GrpcService.SyncLink_Input request)
    {
        return await G_RequestService.SyncLink(request);
    }
    [HttpPost(nameof(SyncCondition))]
    public async Task<Cheetah_GrpcService.SyncCondition_Output> SyncCondition([FromBody] Cheetah_GrpcService.SyncCondition_Input request)
    {
        return await G_RequestService.SyncCondition(request);
    }
}