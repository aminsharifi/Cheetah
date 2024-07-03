namespace Cheetah.Application.Business.Case.WorkItem.Specifications;

public class GetWorkItemByCaseTaskUserSpec : Specification<F_WorkItem>
{
    public GetWorkItemByCaseTaskUserSpec(long? CaseId,long? taskId) 
    {
        Query
            .Where(x => x.CaseId == CaseId);

        Query
           .Where(x => x.TaskId == taskId);

        Query
            .Where(x=>x.WorkItemStateId == D_WorkItemState.Inbox.Id);


    }
}