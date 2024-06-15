namespace Cheetah.Application.Business.Process.TaskCondition.Specifications;

public class GetConditionsByTaskSpec : Specification<L_TaskCondition, long>
{
    public GetConditionsByTaskSpec(long? currentTaskId)
    {
        Query
            .EnableCache(nameof(GetConditionsByTaskSpec), currentTaskId);

        Query
         .Where(x => x.FirstId == currentTaskId)
         .Where(x => x.FirstId.HasValue)
         .AsNoTracking();

        Query.Select(x => x.SecondId!.Value);
    }
}
