namespace Cheetah.Core.Aggregates.ProcessAggregate.Facts.Specifications;

public class GetSortIndexTask : SingleResultSpecification<F_Task, long?>
{
    public GetSortIndexTask(long? TaskId)
    {
        //Query
        //    .EnableCache(nameof(GetSortIndexTask), TaskId);
        Query
            .Where(x => x.Id == TaskId);
        Query
            .AsNoTracking();

        Query
            .Select(x => x.SortIndex);

    }
}
