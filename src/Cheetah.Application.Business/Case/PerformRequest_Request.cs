using Cheetah.Domain.Aggregates.CaseAggregate.DTOs;

namespace Cheetah.Application.Business.Case;

public class PerformRequest_Request
{
    public WorkItemDTO? WorkItem { get; set; }
    public bool? Rebase { get; set; }
}
