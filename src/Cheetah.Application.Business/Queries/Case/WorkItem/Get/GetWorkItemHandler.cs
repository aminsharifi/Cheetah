﻿using Cheetah.Application.Business.Queries.Condition.Get;
using Cheetah.Domain.Aggregates.CaseAggregate.Facts.Specifications;
using Cheetah.Domain.Aggregates.CaseAggregate.Links;
using Cheetah.Domain.Common.Specifications;
using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Application.Business.Queries.Case.WorkItem.Get;

public class GetWorkItemHandler(
    IReadRepository<D_User> userRepository,
    IReadRepository<F_WorkItem> workItemRepository,
    ISender iSender) : IQueryHandler<GetWorkItemQuery, Result<F_WorkItem>>
{
    public async Task<Result<F_WorkItem>> Handle(GetWorkItemQuery request, CancellationToken cancellationToken)
    {
        var _workItemSpec = new GetWorkItemSpec(request.WorkItem, true);

        F_WorkItem? _workItem = await workItemRepository
            .FirstOrDefaultAsync(_workItemSpec, cancellationToken);

        Guard.Against.Null(_workItem);

        if (_workItem!.LastModified != null && !request.Rebase)
        {
            return Result.Conflict("درخواست پشین پردازش شده است");
            throw new InvalidOperationException();
        }

        var _workItemUserSpec = new GetIdEntitySpec<D_User>(request.WorkItemUser);
        var _workItemUserId = await userRepository.FirstOrDefaultAsync(_workItemUserSpec, cancellationToken);

        _workItem
            .SetUserId(_workItemUserId);

        _workItem
            .SetName(request.WorkItem.Name)
            .SetDisplayName(request.WorkItem.DisplayName);

        _workItem.WorkItemConditions?.Clear();

        await Parallel.ForEachAsync(request.WorkItemConditions, async (_condition, _cancellatoin) =>
        {
            var _getCondition = await iSender.Send(new GetConditionIdQuery(_condition));

            _workItem.WorkItemConditions?
            .Add((L_WorkItemCondition)new L_WorkItemCondition().SetSecondId(_getCondition.Value));
        });

        return _workItem;
    }
}
