namespace Cheetah.Application.Business.Case.WorkItem.Specifications;

public class GetWorkItemSpec : GetEntitySpec<F_WorkItem>
{
    public GetWorkItemSpec(BaseEntity? input) : base(input?.Id)
    {
        Query
            .Include(x => x.Case);
        Query
            .Include(x => x.WorkItemConditions);
    }
    public GetWorkItemSpec(SimpleClassDTO input, Boolean EnableTrack) : base(input, EnableTrack)
    {
        Query
            .Include(x => x.Case);
        Query
            .Include(x => x.WorkItemConditions);
    }
}