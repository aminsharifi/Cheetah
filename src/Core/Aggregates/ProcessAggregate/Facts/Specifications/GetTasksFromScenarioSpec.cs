namespace Cheetah.Core.Aggregates.ProcessAggregate.Facts.Specifications;

public class GetTasksFromScenarioSpec : Specification<F_Task>
{
    public GetTasksFromScenarioSpec(long? ScenarioId)
    {
        Query
            .EnableCache(nameof(GetTasksFromScenarioSpec), ScenarioId);

        Query
            .AsNoTracking();

        Query
            .Where(x => x.ScenarioId == ScenarioId)
            .Where(x => x.EnableRecord);

        Query
            .Include(x => x.TaskConditions);

        Query
            .OrderBy(x => x.SortIndex);
    }
}
