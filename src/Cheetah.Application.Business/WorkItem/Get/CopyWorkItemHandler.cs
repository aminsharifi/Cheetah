using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Application.Business.WorkItem.Get;

public class CopyWorkItemHandler(
    IReadRepository<D_User> _userRepository,
    ISender _ISender)
  : IQueryHandler<CopyWorkItemQuery, Result<F_WorkItem>>
{
    public async Task<Result<F_WorkItem>> Handle(CopyWorkItemQuery request, CancellationToken cancellationToken)
    {
        Guard.Against.Null(request.input.WorkItemConditions);

        F_WorkItem _workItem = new();

        if (request.input.UserId is not null or 0)
        {
            _workItem.UserId = request.input.UserId;
        }
        else
        {
            var _userSpec = new GetIdEntitySpec<D_User>(request.input.User);
            _workItem.UserId = await _userRepository.FirstOrDefaultAsync(_userSpec, cancellationToken);
        }

        var _conditions = request.input.WorkItemConditions.Select(x => x.Condition);

        await Parallel.ForEachAsync(_conditions, async (_condition, cancellation) =>
        {
            var _getCondition = await _ISender.Send(new CopyConditionQuery(_condition));

            _workItem.WorkItemConditions.Add(new()
            {
                SecondId = _getCondition.Value.Id
            });
        });
        return _workItem;
    }
}
