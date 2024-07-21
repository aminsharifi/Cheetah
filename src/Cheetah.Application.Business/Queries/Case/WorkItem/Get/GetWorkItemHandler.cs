using Cheetah.Domain.Aggregates.CaseAggregate.Facts.Specifications;
using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Application.Business.Queries.Case.WorkItem.Get;

public class GetWorkItemHandler(
    IReadRepository<D_User> _userRepository,
    IReadRepository<F_WorkItem> _workItemRepository,
    IReadRepository<F_Condition> _conditionRepository,
    ISender _ISender, IMapper _IMapper) : IQueryHandler<GetWorkItemQuery, Result<F_WorkItem>>
{
    public async Task<Result<F_WorkItem>> Handle(GetWorkItemQuery request, CancellationToken cancellationToken)
    {
        var _workItemSpec = new GetWorkItemSpec(request.WorkItem, true);
        F_WorkItem _workItem = await _workItemRepository
            .FirstOrDefaultAsync(_workItemSpec, cancellationToken);

        if (_workItem.LastModified != null && !request.Rebase)
        {
            return Result.Conflict("درخواست پشین پردازش شده است");
            throw new InvalidOperationException();
        }

        _workItem = await GetWorkItem
             .Apply(iSender: _ISender,
             WorkItemUser: request.WorkItemUser, WorkItemBase: request.WorkItem,
             workItemConditions: request.WorkItemConditions, _userRepository: _userRepository,
             workItem: _workItem, cancellationToken: cancellationToken);

        return _workItem;
    }
}
