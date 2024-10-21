using Cheetah.Core.Aggregates.UserAggregate.Dimentions;

namespace Cheetah.Core.Aggregates.UserAggregate.Specifications;

/// <summary>
/// Get all users with determined conditions
/// </summary>
public class GetManagerByUserIdSpec : SingleResultSpecification<D_User, long?>
{
    public GetManagerByUserIdSpec(long userId)
    {
        //Query
        //    .EnableCache(nameof(GetUserByCaseConditionSpec), PerformerConditions);

        Query
            .Where(x => x.Id == userId);

        Query
            .Where(x => x.EnableRecord);

        Query
            .AsNoTracking();

        Query
            .Select(x => x.ManagerId);
    }
}