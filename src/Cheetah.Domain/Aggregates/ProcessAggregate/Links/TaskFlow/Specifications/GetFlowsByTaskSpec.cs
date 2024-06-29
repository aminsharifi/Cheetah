namespace Cheetah.Application.Business.TaskFlow.Specifications;

public class GetFlowsByTaskSpec : Specification<L_TaskFlow>
{
    public GetFlowsByTaskSpec(long? currentTaskId)
    {
        Query
            .EnableCache(nameof(GetFlowsByTaskSpec), currentTaskId);

        Query
         .Where(x => x.FirstId == currentTaskId);

        Query
         .Include(x => x.Task);

        Query
            .Include(x => x.Flow)
            .ThenInclude(x => x.FlowConditions);

        Query
            .Include(x => x.Flow)
            .ThenInclude(x => x.FlowTasks)
            .ThenInclude(x => x.Task);

        Query
           .AsNoTracking();
    }
}
