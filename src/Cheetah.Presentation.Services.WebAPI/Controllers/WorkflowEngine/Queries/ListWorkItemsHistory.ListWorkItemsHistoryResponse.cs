using Cheetah.Domain.Common.DTOs;

namespace Cheetah.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Queries;

public class ListWorkItemsHistoryResponse
{
    public BaseClassWithDateDTO? Case { get; set; }
    public BaseClassWithNameDTO? Task { get; set; }
    public BaseClassWithNameDTO? Form { get; set; }
    public List<BaseClassWithNameDTO>? Performer { get; set; }
    public BaseClassWithNameDTO? User { get; set; }
    public BaseClassWithNameAndDateDTO? WorkItem { get; set; }
    public BaseClassWithNameDTO? WorkItemState { get; set; }
    public List<BaseClassWithNameDTO>? OccurredUserActions { get; set; }
    public BaseClassWithNameDTO OutputState { get; set; } = default!;
}