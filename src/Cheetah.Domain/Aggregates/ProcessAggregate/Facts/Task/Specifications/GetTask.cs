using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Domain.Aggregates.ProcessAggregate.Facts.Task.Specifications;

public class GetTask : SingleResultSpecification<F_Task>
{
    public GetTask(long? taskId)
    {
        Query
            .EnableCache(nameof(GetTask), taskId);

        Query
            .Where(x => x.Id == taskId);

        Query
            .AsNoTracking();

        Query
            .Include(x => x.TaskConditions);

        Query
            .Include(x => x.Form);
    }
}