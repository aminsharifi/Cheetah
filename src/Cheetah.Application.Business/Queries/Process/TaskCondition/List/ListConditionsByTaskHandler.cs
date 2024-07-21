using Cheetah.Domain.Aggregates.ProcessAggregate.Links.TaskCondition;
using Cheetah.Domain.Aggregates.ProcessAggregate.Links.TaskCondition.Specifications;

namespace Cheetah.Application.Business.Queries.Process.TaskCondition.List;

public class ListConditionsByTaskHandler(IReadRepository<L_TaskCondition> _taskConditionRepository)
    : IQueryHandler<ListConditionsByTaskQuery, Result<IEnumerable<long>>>
{
    public async Task<Result<IEnumerable<long>>> Handle(ListConditionsByTaskQuery request, CancellationToken cancellationToken)
    {
        var _currentTaskId = Guard.Against.Null(request.currentTaskId);

        var _getFlowsByTaskSpec = new GetConditionsByTaskSpec(_currentTaskId);

        var _taskConditions = await _taskConditionRepository
            .ListAsync(_getFlowsByTaskSpec, cancellationToken);

        return _taskConditions;
    }
}