using Cheetah.Domain.Aggregates.CaseAggregate.DTOs;

namespace Cheetah.Application.Business.DTOs.Case;

public class UpdateWorkItem_Request
{
    public WorkItemDTO? WorkItem { get; set; }
    public bool? Rebase { get; set; }
}
