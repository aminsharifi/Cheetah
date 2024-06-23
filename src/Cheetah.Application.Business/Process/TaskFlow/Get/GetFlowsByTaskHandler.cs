namespace Cheetah.Application.Business.TaskFlow.Get;

public class GetFlowsByTaskHandler(
    IReadRepository<L_TaskFlow> _taskFlowRepository) : IQueryHandler<GetFlowsByTaskQuery, Result<IEnumerable<L_TaskFlow>>>
{
    public async Task<Result<IEnumerable<L_TaskFlow>>> Handle(GetFlowsByTaskQuery request, CancellationToken cancellationToken)
    {
        var _getFlowsByTaskSpec = new GetFlowsByTaskSpec(request.currentTaskId);

        var _taskFlows = await _taskFlowRepository
            .ListAsync(_getFlowsByTaskSpec, cancellationToken);

        return _taskFlows;
    }
}