using Cheetah.Core.Aggregates.UserAggregate.Links;

namespace Cheetah.Core.Aggregates.UserAggregate.Specifications;

/// <summary>
/// Check user that have the same conditions with the case
/// </summary>
public class GetUserByCaseConditionSpec : Specification<L_UserCondition, long>
{
    /// <summary>
    /// Check user that have the same conditions with the case
    /// </summary>
    /// <param name="UserFilter">User's Ids</param>
    /// <param name="ConditionFilter">Condition's Ids</param>
    public GetUserByCaseConditionSpec(IEnumerable<long> UserFilter, IEnumerable<long> ConditionFilter)
    {
        Query
            .EnableCache(nameof(GetUserByCaseConditionSpec), UserFilter + "-" + ConditionFilter);

        Query
            .AsNoTracking();

        Query
            .Where(x => x.FirstId != null && UserFilter.Contains(x.FirstId.Value));

        Query
            .Where(x => x.SecondId != null && ConditionFilter.Contains(x.SecondId.Value));

        Query
            .Where(x => x.EnableRecord);

        Query
            .Select(x => x.FirstId!.Value);
    }
}
