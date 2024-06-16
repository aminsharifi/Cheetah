using Cheetah.Application.Business.Case.WorkItem.Specifications;

namespace Cheetah.Application.Business.WorkItem.Get;

public class CopyWorkItemHandler(
    IReadRepository<D_User> _userRepository,
    IReadRepository<F_WorkItem> _workItemRepository,
    IReadRepository<F_Condition> _conditionRepository,
    ISender _ISender, IMapper _IMapper) : IQueryHandler<CopyWorkItemQuery, Result<F_WorkItem>>
{
    public async Task<Result<F_WorkItem>> Handle(CopyWorkItemQuery request, CancellationToken cancellationToken)
    {
        var _workItemSpec = new GetWorkItemSpec(request.WorkItem, true);
        F_WorkItem _workItem = await _workItemRepository
            .FirstOrDefaultAsync(_workItemSpec, cancellationToken);

        if (_workItem.LastModified != null && !request.Rebase)
        {
            return Result.Conflict("درخواست پشین پردازش شده است");
            throw new InvalidOperationException();
        }

        _workItem = await CopyWorkItem
             .Apply(iSender: _ISender,
             WorkItemUser: request.WorkItemUser, WorkItemBase: request.WorkItem,
             workItemConditions: request.WorkItemConditions, _userRepository: _userRepository,
             workItem: _workItem, cancellationToken: cancellationToken);

        return _workItem;
    }
}
