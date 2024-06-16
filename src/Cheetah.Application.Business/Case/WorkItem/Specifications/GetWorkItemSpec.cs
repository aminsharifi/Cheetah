namespace Cheetah.Application.Business.Case.WorkItem.Specifications;

internal class GetWorkItemSpec : GetEntitySpec<F_WorkItem>
{
    public GetWorkItemSpec(BaseEntity? input) : base(input?.Id)
    {
        Query.Include(x => x.Case)
            .ThenInclude(x => x.WorkItems);
    }
    public GetWorkItemSpec(SimpleClassDTO input, Boolean EnableTrack) : base(input, EnableTrack)
    {
        Query.Include(x => x.Case)
            .ThenInclude(x => x.WorkItems);
    }
}