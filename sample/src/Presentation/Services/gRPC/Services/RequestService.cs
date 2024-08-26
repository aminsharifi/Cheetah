using Cheetah.Core.Aggregates.CaseAggregate.Facts;
using Cheetah.Core.Aggregates.ConditionAggregate.Facts;
using Cheetah.Core.Aggregates.UserAggregate.Dimentions;
using Cheetah.Core.Interfaces;
using Cheetah.Core.Interfaces.Cartable;
using Cheetah.Core.Interfaces.WorkItem;
using Cheetah_GrpcService;

namespace Cheetah.Sample.Presentation.Services.gRPC.Services;

public class RequestService : Request.RequestBase
{
    public Share.Services.RequestService G_RequestService;
    public RequestService(ILogger<Share.Services.RequestService> GLogger,
        ITableCRUD GSimpleClassRepository, ICartable GICartable, IWorkItem GIWorkItem,
        ICopyClass GICopyClass, ISync GISync, IMediator GMediator,
        IReadRepository<D_User> _userRepository,
        IReadRepository<F_Condition> _conditionRepository,
        IReadRepository<F_WorkItem> _workItemRepository)
    {
        //G_RequestService = new Presentation.Services.Shared.Services.RequestService(
        //GLogger, GSimpleClassRepository, GICartable, GIWorkItem, GICopyClass, GISync, GMediator,
        //_userRepository, _conditionRepository, _workItemRepository);
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