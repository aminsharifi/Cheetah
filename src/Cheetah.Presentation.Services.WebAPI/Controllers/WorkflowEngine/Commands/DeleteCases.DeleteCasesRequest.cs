namespace Cheetah.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public record DeleteCasesRequest
{
    public const string Route = "/WorkflowEngine/Commands/DeleteCases/{PassWord}";
    public static string BuildRoute(string passWord) => Route.Replace("{PassWord}", passWord.ToString());

    public string PassWord { get; set; } = default!;
}
