namespace Cheetah.Application.Business.Process.TaskCondition.Get;

public class GetConditionsByTaskHandler(IReadRepository<L_TaskCondition> _taskConditionRepository) 
    : IQueryHandler<GetConditionsByTaskQuery, Result<IEnumerable<long>>>
{
    public async Task<Result<IEnumerable<long>>> Handle(GetConditionsByTaskQuery request, CancellationToken cancellationToken)
    {
        var _getFlowsByTaskSpec = new GetConditionsByTaskSpec(request.currentTaskId);

        var _taskConditions = await _taskConditionRepository
            .ListAsync(_getFlowsByTaskSpec, cancellationToken);

        return _taskConditions;
    }
}