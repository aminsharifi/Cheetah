namespace Cheetah.Application.Business.Case.WorkItem;

public static class CopyWorkItem
{
    public static async Task<F_WorkItem> Apply(ISender iSender,
        CopyCaseQuery request, IReadRepository<D_User> _userRepository,
        CancellationToken cancellationToken)
    {
        var _workItemUserSpec = new GetIdEntitySpec<D_User>(request.WorkItemUser);
        var _workItemUserId = await _userRepository.FirstOrDefaultAsync(_workItemUserSpec, cancellationToken);

        F_WorkItem _workItem = new(userId: _workItemUserId);

        _workItem.SetNameAndDisplayName(name: request.WorkItemBase.Name,
            displayName: request.WorkItemBase.DisplayName);

        await Parallel.ForEachAsync(request.WorkItemConditions, async (_condition, _cancellatoin) =>
        {
            var _getCondition = await iSender.Send(new GetConditionIdQuery(_condition));

            _workItem.WorkItemConditions.Add(new(conditionId: _getCondition.Value));
        });

        return _workItem;
    }
}
