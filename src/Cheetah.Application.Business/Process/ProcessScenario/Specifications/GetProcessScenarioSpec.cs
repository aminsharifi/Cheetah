namespace Cheetah.Application.Business.ProcessScenario.Specifications;

public class GetProcessScenarioSpec : Specification<L_ProcessScenario>
{
    public GetProcessScenarioSpec(long processId)
    {
        Query
            .EnableCache(nameof(GetProcessScenarioSpec), processId);

        Query
            .Where(x => x.FirstId == processId)
            .Where(x => x.EnableRecord == true)
            .AsNoTracking();
    }
}