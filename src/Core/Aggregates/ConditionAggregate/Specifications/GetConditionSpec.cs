using Cheetah.Core.Aggregates.ConditionAggregate.Facts;
using Cheetah.Core.Helpers;

namespace Cheetah.Core.Aggregates.ConditionAggregate.Specifications;

public class GetConditionSpec : Specification<F_Condition>
{
    public GetConditionSpec(IEnumerable<long> IncludeIds)
    {
        //Query
        //    .EnableCache(nameof(GetConditionSpec), "+" + IncludeIds.AsString());

        Query
            .Where(x => IncludeIds.Contains(x.Id));

        Query
            .AsNoTracking();
    }
}