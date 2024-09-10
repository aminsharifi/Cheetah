namespace Cheetah.Core.Aggregates.ProcessAggregate.Links.Specifications;

public class GetProcessScenarioSpec : Specification<L_ProcessScenario>
{
    public GetProcessScenarioSpec(long processId)
    {
        //Query
        //    .EnableCache(nameof(GetProcessScenarioSpec), processId);

        Query
            .Include(x => x.Scenario);

        Query
            .AsNoTracking();

        Query
            .Where(x => x.FirstId == processId)
            .Where(x => x.EnableRecord == true);
    }
}