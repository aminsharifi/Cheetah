using Cheetah.Core.Interfaces.WorkItem;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class DeleteProject(ILogger<DeleteProject> logger, IWorkItem iWorkItem) : Endpoint<DeleteProjectRequest, bool>
{
    public override void Configure()
    {
        Delete(DeleteProjectRequest.Route);
        AllowAnonymous();
    }

    public override async Task HandleAsync(DeleteProjectRequest request, CancellationToken cancellationToken)
    {
        if (string.Compare(request.PassWord, "Cheetah@123", StringComparison.OrdinalIgnoreCase) != 0)
        {
            Response = false;
            return;
        }

        logger.LogInformation("started " + nameof(DeleteProject) + " {@" + nameof(DeleteProject) + "}", nameof(DeleteProject));

        var _outputResult = await iWorkItem.ClearProjectAsync();

        logger.LogInformation("Ended " + nameof(DeleteProject) + " {@" + nameof(DeleteProject) + "}", _outputResult);

        Response = _outputResult;
        return;
    }
}