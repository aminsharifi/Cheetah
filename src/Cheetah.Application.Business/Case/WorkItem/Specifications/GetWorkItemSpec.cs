namespace Cheetah.Application.Business.Case.WorkItem.Specifications;

internal class GetWorkItemSpec : GetEntitySpec<F_WorkItem>
{
    public GetWorkItemSpec(BaseEntity? input) : base(input)
    {
        Query.Include(x => x.Case)
            .ThenInclude(x => x.WorkItems);
    }
}
