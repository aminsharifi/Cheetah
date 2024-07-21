using Cheetah.Domain.Aggregates.UserAggregate.Links;

namespace Cheetah.Domain.Aggregates.UserAggregate.Specifications;

public class GetUserByCaseConditionSpec : Specification<L_UserCondition, long?>
{
    public GetUserByCaseConditionSpec(IEnumerable<long?> userFilter, IEnumerable<long?> conditionFilter)
    {
        Query
            .EnableCache(nameof(GetUserByCaseConditionSpec), userFilter + "-" + conditionFilter);

        Query
            .Select(x => x.FirstId);

        Query
            .Where(x => userFilter.Contains(x.FirstId))
            .Where(x => conditionFilter.Contains(x.SecondId))
            .Where(x => x.EnableRecord);

        Query
            .AsNoTracking();
    }
}
