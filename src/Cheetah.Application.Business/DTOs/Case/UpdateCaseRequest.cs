namespace Cheetah.Application.Business.DTOs.Case;

public class UpdateCaseRequest
{
    public WorkItemDTO? WorkItem { get; set; }
    public bool? Rebase { get; set; }
}
