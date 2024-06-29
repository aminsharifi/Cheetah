namespace Cheetah.Application.Business.Task.Specifications;

public class GetTasksFromScenarioSpec : Specification<F_Task>
{
    public GetTasksFromScenarioSpec(long? ScenarioId)
    {
        Query
            .EnableCache(nameof(GetTasksFromScenarioSpec), ScenarioId);

        Query
            .Where(x => x.ScenarioId == ScenarioId)
            .Where(x => x.EnableRecord)
            .OrderBy(x => x.SortIndex)
            .AsNoTracking();

        Query.Include(x => x.TaskConditions);
    }
}
