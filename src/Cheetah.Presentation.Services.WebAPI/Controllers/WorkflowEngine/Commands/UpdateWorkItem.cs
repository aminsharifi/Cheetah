namespace Cheetah.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;


public class UpdateWorkItem(ILogger<UpdateWorkItem> logger, IWorkItem iWorkItem) : Endpoint<UpdateWorkItemRequest, UpdateWorkItemResponse>
{
    public override void Configure()
    {
        Post(UpdateWorkItemRequest.Route);
        AllowAnonymous();
    }
    public override async Task HandleAsync(UpdateWorkItemRequest request, CancellationToken cancellationToken)
    {
        logger.LogInformation("started " + nameof(UpdateWorkItem) + " {@" + nameof(UpdateWorkItem) + "}", request);

        var _outputResult = await iWorkItem.PerformWorkItemAsync(request.Adapt<UpdateWorkItem_Request>());

        Response = _outputResult.Value.Adapt<UpdateWorkItemResponse>();

        logger.LogInformation("Ended " + nameof(UpdateWorkItem) + " {@" + nameof(UpdateWorkItem) + "}", _outputResult);

        return;
    }
}
