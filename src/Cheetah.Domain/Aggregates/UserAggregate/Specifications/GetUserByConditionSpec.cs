using Cheetah.Domain.Aggregates.UserAggregate.Links;

namespace Cheetah.Domain.Aggregates.UserAggregate.Specifications;

public class GetUserByConditionSpec : Specification<L_UserCondition, long?>
{
    public GetUserByConditionSpec(IEnumerable<long?> performerConditions)
    {
        Query
            .EnableCache(nameof(GetUserByCaseConditionSpec), performerConditions);

        Query
            .Select(x => x.FirstId);

        Query
            .Where(x => performerConditions.Contains(x.SecondId))
            .Where(x => x.EnableRecord);

        Query
            .AsNoTracking();
    }
}
