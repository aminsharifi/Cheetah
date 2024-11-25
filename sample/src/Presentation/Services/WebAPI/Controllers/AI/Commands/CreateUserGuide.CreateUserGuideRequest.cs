using Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands.AI;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class CreateUserGuideRequest
{
    public const string Route = "/AI/Commands/"+nameof(CreateUserGuide);
    public string JsonData { get; set; }
    public string Body { get; set; }
}
