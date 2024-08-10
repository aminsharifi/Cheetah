using Cheetah.Core.Aggregates.ProcessAggregate.Links.TaskFlow.Specifications;
using Cheetah.Core.Entities.Links;

namespace Cheetah.UseCases.Queries.Process.TaskFlow.List;

public class ListFlowsByTaskHandler(
    IReadRepository<L_TaskFlow> taskFlowRepository) : IQueryHandler<ListFlowsByTaskQuery, Result<IEnumerable<L_TaskFlow>>>
{
    public async Task<Result<IEnumerable<L_TaskFlow>>> Handle(ListFlowsByTaskQuery request, CancellationToken cancellationToken)
    {
        var _getFlowsByTaskSpec = new GetFlowsByTaskSpec(request.currentTaskId);

        var _taskFlows = await taskFlowRepository
            .ListAsync(_getFlowsByTaskSpec, cancellationToken);

        return _taskFlows;
    }
}