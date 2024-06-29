using Cheetah.Domain.Aggregates.ProcessAggregate.Links.TaskCondition;

namespace Cheetah.Application.Business.Queries.Process.TaskCondition.List;

public class ListConditionsByTaskHandler(IReadRepository<L_TaskCondition> _taskConditionRepository)
    : IQueryHandler<ListConditionsByTaskQuery, Result<IEnumerable<long>>>
{
    public async Task<Result<IEnumerable<long>>> Handle(ListConditionsByTaskQuery request, CancellationToken cancellationToken)
    {
        var _getFlowsByTaskSpec = new GetConditionsByTaskSpec(request.currentTaskId);

        var _taskConditions = await _taskConditionRepository
            .ListAsync(_getFlowsByTaskSpec, cancellationToken);

        return _taskConditions;
    }
}