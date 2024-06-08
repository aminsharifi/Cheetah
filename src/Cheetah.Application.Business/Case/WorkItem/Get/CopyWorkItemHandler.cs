using Cheetah.Domain.Common.DTOs;
using Mapster;

namespace Cheetah.Application.Business.WorkItem.Get;

public class CopyWorkItemHandler(
    IReadRepository<D_User> _userRepository,
    IReadRepository<F_WorkItem> _workItemRepository,
    IReadRepository<F_Condition> _conditionRepository,
    ISender _ISender, IMapper _IMapper) : IQueryHandler<CopyWorkItemQuery, Result<F_WorkItem>>
{
    public async Task<Result<F_WorkItem>> Handle(CopyWorkItemQuery request, CancellationToken cancellationToken)
    {
        var _workItemSpec = new GetEntitySpec<F_WorkItem>(request.WorkItem.Adapt<SimpleClassDTO>(), true);
        F_WorkItem _workItem = await _workItemRepository.FirstOrDefaultAsync(_workItemSpec, cancellationToken);

        var _userSpec = new GetIdEntitySpec<D_User>(request.WorkItemUser);
        _workItem!.SetUserId(await _userRepository.FirstOrDefaultAsync(_userSpec, cancellationToken));

        await Parallel.ForEachAsync(request.WorkItemConditions, async (_condition, _cancellatoin) =>
        {
            var _getCondition = await _ISender.Send(new GetConditionIdQuery(_condition.GetCondition(_IMapper)));

            _workItem.WorkItemConditions.Add(new(conditionId: _getCondition.Value));
        });

        return _workItem;
    }
}
