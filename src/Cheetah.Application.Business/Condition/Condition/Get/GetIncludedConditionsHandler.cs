namespace Cheetah.Application.Business.Condition.Get;

public class GetIncludedConditionsHandler(
    IReadRepository<F_Condition> _conditionRepository)
    : IQueryHandler<GetIncludedConditionsQuery, Result<IEnumerable<F_Condition>>>
{
    public async Task<Result<IEnumerable<F_Condition>>> Handle(GetIncludedConditionsQuery request, CancellationToken cancellationToken)
    {
        var _userSpec = new GetConditionSpec(request.input);
        var _processScenarios = await _conditionRepository.ListAsync(_userSpec, cancellationToken);

        return _processScenarios;
    }
}