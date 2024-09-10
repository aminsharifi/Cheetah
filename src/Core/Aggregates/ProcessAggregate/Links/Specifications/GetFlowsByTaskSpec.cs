namespace Cheetah.Core.Aggregates.ProcessAggregate.Links.Specifications;

public class GetFlowsByTaskSpec : Specification<L_TaskFlow>
{
    public GetFlowsByTaskSpec(long CurrentTaskId)
    {
        //Query
        //    .EnableCache(nameof(GetFlowsByTaskSpec), CurrentTaskId);

        Query
         .Where(x => x.FirstId == CurrentTaskId);

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
