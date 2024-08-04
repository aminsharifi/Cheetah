using Cheetah.Core.Aggregates.CaseAggregate.DTOs;

namespace Cheetah.Core.Interfaces.WorkItem.DTOs;

public class UpdateWorkItem_Request
{
    public WorkItemDTO? WorkItem { get; set; }
    public bool? Rebase { get; set; }
}
