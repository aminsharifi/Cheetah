namespace Cheetah.Core.Aggregates.ProcessAggregate.Links.Specifications;

public class GetConditionsByTaskSpec : Specification<L_TaskCondition, long>
{
    public GetConditionsByTaskSpec(long CurrentTaskId)
    {
        Query
            .EnableCache(nameof(GetConditionsByTaskSpec), CurrentTaskId);

        Query
            .Where(x => x.FirstId == CurrentTaskId)
            .Where(x => x.FirstId.HasValue);

        Query
            .AsNoTracking();

        Query
            .Select(x => x.SecondId!.Value);
    }
}