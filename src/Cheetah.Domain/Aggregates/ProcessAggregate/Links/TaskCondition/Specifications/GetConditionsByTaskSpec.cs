using Cheetah.Domain.Aggregates.ProcessAggregate.Links.TaskCondition;

namespace Cheetah.Application.Business.Process.TaskCondition.Specifications;

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