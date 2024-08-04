using Cheetah.Core.Entities.Dimentions;
using Cheetah.Core.Entities.Facts;

namespace Cheetah.Core.Aggregates.CaseAggregate.Facts.Specifications;

public class GetWorkItemByCaseTaskSpec : Specification<F_WorkItem>
{
    public GetWorkItemByCaseTaskSpec(long? CaseId, long? TaskId)
    {
        Query
            .Where(x => x.CaseId == CaseId);

        Query
           .Where(x => x.TaskId == TaskId);

        Query
            .Where(x => x.WorkItemStateId == D_WorkItemState.Inbox.Id);
    }
}