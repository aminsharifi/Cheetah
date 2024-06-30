namespace Cheetah.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class CreateCaseTaskUserRequest
{
    public const string Route = "/WorkflowEngine/Commands/CreateCaseTaskUser";
    public BaseClassDTO? Case { get; set; }
    public BaseClassWithNameDTO? Task { get; set; }
    public BaseClassWithNameDTO? User { get; set; }
}
