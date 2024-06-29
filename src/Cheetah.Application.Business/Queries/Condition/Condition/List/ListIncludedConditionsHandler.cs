namespace Cheetah.Application.Business.Queries.Condition.Condition.List;

public class ListIncludedConditionsHandler(
    IReadRepository<F_Condition> _conditionRepository,
    IMemoryCache _cache)
    : IQueryHandler<ListIncludedConditionsQuery, Result<IEnumerable<F_Condition>>>
{
    public async Task<Result<IEnumerable<F_Condition>>> Handle(ListIncludedConditionsQuery request, CancellationToken cancellationToken)
    {
        List<F_Condition> f_Conditions = new();

        foreach (var _GetDetailCase in request.input)
        {
            F_Condition _condition = new();
            var _key = nameof(GetConditionSpec) + "-" + _GetDetailCase;
            if (_cache.TryGetValue(_key, out _condition))
            {
                f_Conditions.Add(_condition);
            }
        }
        var _needFetch = request.input.Where(x => !f_Conditions.Select(x => x.Id).Contains(x));
        if (_needFetch.Any())
        {
            var _userSpec = new GetConditionSpec(_needFetch);
            var _processScenarios = await _conditionRepository.ListAsync(_userSpec, cancellationToken);

            f_Conditions.AddRange(_processScenarios);
        }

        return f_Conditions;
    }
}