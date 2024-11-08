using Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands.AI;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class UpdateUserGuideRequest
{
    public const string Route = "/AI/Commands/"+nameof(UpdateUserGuide);
    public long Id { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }
    public string Keywords { get; set; }
    public string Body { get; set; }
}
