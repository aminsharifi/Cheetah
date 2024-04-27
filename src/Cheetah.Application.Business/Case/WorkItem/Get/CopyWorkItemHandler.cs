﻿namespace Cheetah.Application.Business.WorkItem.Get;

public class CopyWorkItemHandler(
    IReadRepository<D_User> _userRepository,
    IReadRepository<F_Condition> _conditionRepository,
    ISender _ISender) : IQueryHandler<CopyWorkItemQuery, Result<F_WorkItem>>
{
    public async Task<Result<F_WorkItem>> Handle(CopyWorkItemQuery request, CancellationToken cancellationToken)
    {
        Guard.Against.Null(request.WorkItem.WorkItemConditions);

        F_WorkItem _workItem = new();

        if (request.User.Id is not 0)
        {
            _workItem.UserId = request.User.Id;
        }
        else
        {
            var _userSpec = new GetIdEntitySpec<D_User>(request.User);

            _workItem.UserId = await _userRepository.FirstOrDefaultAsync(_userSpec, cancellationToken);
        }

        var _conditions = request.WorkItem.WorkItemConditions
            .Select(x => _conditionRepository
            .FirstOrDefaultAsync(new GetEntitySpec<F_Condition>(x.SecondId)).GetAwaiter().GetResult()
            );

        await Parallel.ForEachAsync(_conditions, async (_condition, cancellation) =>
        {
            var _getCondition = await _ISender.Send(new GetConditionIdQuery(_condition));

            _workItem.WorkItemConditions.Add(new()
            {
                SecondId = _getCondition.Value
            });
        });
        return _workItem;
    }
}