namespace Cheetah.Application.Business.Task.Specifications;

public class GetTasksFromScenarioSpec : Specification<F_Task>
{
    public GetTasksFromScenarioSpec(long? ScenarioId)
    {
        Query
            .EnableCache(nameof(GetTasksFromScenarioSpec), ScenarioId);

        Query
            .Where(x => x.ScenarioId == ScenarioId)
            .Where(x => x.EnableRecord == true)
            .OrderBy(x => x.SortIndex)
            .AsNoTracking();

        Query
            .Include(x => x.TaskConditions)
            .ThenInclude(x => x.Condition);

        Query
            .Include(x => x.TaskFlows)
            .ThenInclude(x => x.Flow);

        Query
            .Include(x => x.TaskFlows)
            .ThenInclude(x => x.Flow)
            .ThenInclude(x => x.FlowConditions)
            .ThenInclude(x => x.Condition);

        Query
            .Include(x => x.TaskFlows)
            .ThenInclude(x => x.Flow)
            .ThenInclude(x => x.FlowTasks)
            .ThenInclude(x => x.Task);
    }
}
