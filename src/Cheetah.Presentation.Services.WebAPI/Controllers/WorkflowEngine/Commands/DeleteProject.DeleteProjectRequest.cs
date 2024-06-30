namespace Cheetah.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class DeleteProjectRequest
{
    public const string Route = "/WorkflowEngine/Commands/DeleteProject/{PassWord}";
    public static string BuildRoute(string passWord) => Route.Replace("{PassWord}", passWord.ToString());

    public string PassWord { get; set; } = default!;
}
