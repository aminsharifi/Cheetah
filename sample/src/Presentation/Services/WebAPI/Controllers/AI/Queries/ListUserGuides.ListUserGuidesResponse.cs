namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Queries;

public class ListUserGuidesResponse
{
    public ListUserGuidesResponse()
    {
        
    }
    public long Id { get; set; }
    public string JsonData { get; set; }
    public string Body { get; set; }
    public byte[] VectorBody { get; set; } // Store as VARBINARY
}