namespace Cheetah.Application.Business.Condition.Specifications;

public class GetConditionSpec : Specification<F_Condition>
{
    public GetConditionSpec(IEnumerable<long> includeId)
    {
        Query
            .EnableCache(nameof(GetConditionSpec), "+" + includeId.AsString());

        Query
            .Where(x => includeId.Contains(x.Id));

        Query
            .AsNoTracking();
    }
}