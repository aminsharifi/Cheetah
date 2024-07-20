namespace Cheetah.Application.Business.Condition.Specifications;

public class GetConditionSpec : Specification<F_Condition>
{
    public GetConditionSpec(IEnumerable<long> IncludeIds)
    {
        Query
            .EnableCache(nameof(GetConditionSpec), "+" + IncludeIds.AsString());

        Query
            .Where(x => IncludeIds.Contains(x.Id));

        Query
            .AsNoTracking();
    }
}