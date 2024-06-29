namespace Cheetah.Application.Business.Task.Specifications;

public class GetSortIndexTask : Specification<F_Task, long?>
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
