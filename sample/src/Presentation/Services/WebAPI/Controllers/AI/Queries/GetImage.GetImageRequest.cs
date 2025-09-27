namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Queries;

public class GetImageRequest
{
    public const string Route = "/AI/Queries/GetImage/{Name}";
    public String Name { get; set; }

}
