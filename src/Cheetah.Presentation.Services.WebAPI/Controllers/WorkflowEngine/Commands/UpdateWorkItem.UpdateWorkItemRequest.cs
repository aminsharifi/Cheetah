using Cheetah.Core.Aggregates.CaseAggregate.DTOs;

namespace Cheetah.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class UpdateWorkItemRequest
{
    public const string Route = "/WorkflowEngine/Commands/UpdateWorkItem";
    public WorkItemDTO? WorkItem { get; set; }
    public bool? Rebase { get; set; }
}