namespace Cheetah.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class CreateCaseTaskUserResponse
{
    public BaseClassDTO? Case { get; set; }
    public BaseClassWithNameDTO? Task { get; set; }
    public BaseClassWithNameDTO? User { get; set; }
    public BaseClassWithNameDTO? OutputState { get; set; }
}
