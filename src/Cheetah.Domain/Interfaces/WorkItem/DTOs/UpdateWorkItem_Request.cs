using Cheetah.Domain.Aggregates.CaseAggregate.DTOs;

namespace Cheetah.Domain.Interfaces.WorkItem.DTOs;

public class UpdateWorkItem_Request
{
    public WorkItemDTO? WorkItem { get; set; }
    public bool? Rebase { get; set; }
}
