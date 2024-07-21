using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Domain.Aggregates.ProcessAggregate.Facts.Task.Specifications;

public class GetSortIndexTask : SingleResultSpecification<F_Task, long?>
{
    public GetSortIndexTask(long? TaskId)
    {
        Query
            .EnableCache(nameof(GetSortIndexTask), TaskId);
        Query
            .Where(x => x.Id == TaskId);
        Query
            .AsNoTracking();

        Query
            .Select(x => x.SortIndex);

    }
}
