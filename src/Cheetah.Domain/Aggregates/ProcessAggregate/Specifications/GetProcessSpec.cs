namespace Cheetah.Application.Business.ProcessScenario.Specifications;

public class GetProcessSpec : Specification<D_Process>
{
    public GetProcessSpec(IEnumerable<long?> processIds)
    {
        Query
            .EnableCache(nameof(GetProcessSpec), "+" + processIds.AsString());

        Query
            .Where(x => processIds.Contains(x.Id));

        Query
            .AsNoTracking();
    }
}