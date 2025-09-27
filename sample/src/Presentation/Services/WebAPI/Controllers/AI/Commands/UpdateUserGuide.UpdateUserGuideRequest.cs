using Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands.AI;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class UpdateUserGuideRequest
{
    public const string Route = "/AI/Commands/"+nameof(UpdateUserGuide);
    public long Id { get; set; }
    public string JsonData { get; set; }
    public string Body { get; set; }
}
