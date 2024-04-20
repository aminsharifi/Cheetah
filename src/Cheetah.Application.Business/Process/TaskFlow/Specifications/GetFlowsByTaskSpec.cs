namespace Cheetah.Application.Business.TaskFlow.Specifications;

public class GetFlowsByTaskSpec : Specification<L_TaskFlow>
{
    public GetFlowsByTaskSpec(long? currentTaskId)
    {
        Query
            .EnableCache(nameof(GetFlowsByTaskSpec), currentTaskId);

        Query
         .Where(x => x.FirstId == currentTaskId)
         .Include(x => x.Task)
         .Include(x => x.Flow)
         .AsNoTracking();
    }
}
