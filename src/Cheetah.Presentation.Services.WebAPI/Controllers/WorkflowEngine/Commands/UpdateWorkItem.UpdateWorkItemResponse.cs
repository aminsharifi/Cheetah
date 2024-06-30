namespace Cheetah.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class UpdateWorkItemResponse
{
    public CaseDTO? Case { get; set; }
    public BaseClassWithNameDTO? OutputState { get; set; }
}
