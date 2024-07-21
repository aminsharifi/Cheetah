using Cheetah.Domain.Aggregates.UserAggregate.Links;

namespace Cheetah.Domain.Aggregates.UserAggregate.Specifications;

/// <summary>
/// Get all users with determined conditions
/// </summary>
public class GetUserByConditionSpec : Specification<L_UserCondition, long>
{
    /// <summary>
    /// Get all users with determined conditions
    /// </summary>
    /// <param name="PerformerConditions">Condition's Ids</param>
    public GetUserByConditionSpec(IEnumerable<long> PerformerConditions)
    {
        Query
            .EnableCache(nameof(GetUserByCaseConditionSpec), PerformerConditions);

        Query
            .Where(x => x.SecondId != null && PerformerConditions.Contains(x.SecondId.Value));

        Query
            .Where(x => x.FirstId != null);

        Query
            .Where(x => x.EnableRecord);

        Query
            .AsNoTracking();

        Query
            .Select(x => x.FirstId!.Value);
    }
}
