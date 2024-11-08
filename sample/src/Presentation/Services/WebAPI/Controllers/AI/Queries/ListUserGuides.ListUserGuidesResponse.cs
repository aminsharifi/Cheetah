namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Queries;

public class ListUserGuidesResponse
{
    public ListUserGuidesResponse()
    {
        
    }
    public long Id { get; set; }
    public string Subject { get; set; }
    public string Description { get; set; }
    public string Keywords { get; set; }
    public string Body { get; set; }
}