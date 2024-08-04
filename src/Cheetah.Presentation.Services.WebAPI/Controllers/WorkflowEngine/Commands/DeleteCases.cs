using Cheetah.Core.Interfaces.WorkItem;

namespace Cheetah.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class DeleteCases(ILogger<DeleteCases> logger, IWorkItem iWorkItem) : Endpoint<DeleteCasesRequest, bool>
{
    public override void Configure()
    {
        Delete(DeleteCasesRequest.Route);
        AllowAnonymous();
    }

    public override async Task HandleAsync(DeleteCasesRequest request, CancellationToken cancellationToken)
    {
        if (string.Compare(request.PassWord, "Cheetah@123", StringComparison.OrdinalIgnoreCase) != 0)
        {
            Response = false;

            return;
        }
        logger.LogInformation("started " + nameof(DeleteCases) + " {@" + nameof(DeleteCases) + "}", nameof(DeleteCases));

        var _outputResult = await iWorkItem.ClearCasesAsync();

        logger.LogInformation("Ended " + nameof(DeleteCases) + " {@" + nameof(DeleteCases) + "}", _outputResult);

        Response = _outputResult;

        return;
    }
}
