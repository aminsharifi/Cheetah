namespace Cheetah.Application.Business.Case.WorkItem.Specifications;

public class GetWorkItemByCaseTaskSpec : Specification<F_WorkItem>
{
    public GetWorkItemByCaseTaskSpec(long? CaseId,long? TaskId) 
    {
        Query
            .Where(x => x.CaseId == CaseId);

        Query
           .Where(x => x.TaskId == TaskId);

        Query
            .Where(x=>x.WorkItemStateId == D_WorkItemState.Inbox.Id);
    }
}