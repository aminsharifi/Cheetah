namespace Cheetah.Application.Business.Queries.Process.TaskFlow.List;

public class ListFlowsByTaskHandler(
    IReadRepository<L_TaskFlow> _taskFlowRepository) : IQueryHandler<ListFlowsByTaskQuery, Result<IEnumerable<L_TaskFlow>>>
{
    public async Task<Result<IEnumerable<L_TaskFlow>>> Handle(ListFlowsByTaskQuery request, CancellationToken cancellationToken)
    {
        var _getFlowsByTaskSpec = new GetFlowsByTaskSpec(request.currentTaskId);

        var _taskFlows = await _taskFlowRepository
            .ListAsync(_getFlowsByTaskSpec, cancellationToken);

        return _taskFlows;
    }
}