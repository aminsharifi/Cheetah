using Cheetah.Sample.Presentation.Services.WebAPI.Controllers.AI.Queries;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Queries;

public class GetUserGuideRequest
{
    public const string Route = "/AI/Queries/GetUserGuide/{Id}";
    public long Id { get; set; }

}
