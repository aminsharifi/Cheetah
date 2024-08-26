using Cheetah.Core.Aggregates.CaseAggregate.Facts;
using Cheetah.Core.Aggregates.ConditionAggregate.Facts;
using Cheetah.Core.Aggregates.UserAggregate.Dimentions;
using Cheetah.Core.Interfaces;
using Cheetah.Core.Interfaces.Cartable;
using Cheetah.Core.Interfaces.WorkItem;
using Cheetah.Sample.Presentation.Services.Share.Services;

namespace Cheetah.Sample.Presentation.Services.GraphQL;

public class Mutation
{
    public async Task<F_Case> CreateRequestAsync(
        [Service] ILogger<RequestService> GLogger,
        [Service] ITableCRUD GSimpleClassRepository,
        [Service] ICartable GICartable,
        [Service] IWorkItem GIWorkItem,
        [Service] ICopyClass GICopyClass,
        [Service] ISync GISync,
        [Service] IMediator GMediator,
        [Service] IReadRepository<D_User> _userRepository,
        [Service] IReadRepository<F_Condition> _conditionRepository,
        [Service] IReadRepository<F_WorkItem> _workItemRepository,
        F_Case request
        )
    {
        //  Shared.Services.RequestService G_RequestService = new Shared.Services.RequestService(
        //GLogger, GSimpleClassRepository, GICartable, GIWorkItem, GICopyClass, GISync, GMediator,
        //_userRepository, _conditionRepository, _workItemRepository);
        //  return await G_RequestService.CreateRequest(request);
        return new F_Case();
    }
}