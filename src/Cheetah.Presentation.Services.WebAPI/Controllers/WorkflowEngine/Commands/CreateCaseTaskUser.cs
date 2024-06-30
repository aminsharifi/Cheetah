namespace Cheetah.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class CreateCaseTaskUser(ILogger<CreateCaseTaskUser> logger) : Endpoint<CreateCaseTaskUserRequest, CreateCaseTaskUserResponse>
{
    public override void Configure()
    {
        Post(CreateCaseTaskUserRequest.Route);
        AllowAnonymous();
    }
    public override async Task HandleAsync(CreateCaseTaskUserRequest request, CancellationToken cancellationToken)
    {
        logger.LogInformation("started " + nameof(CreateCaseTaskUser) + " {@" + nameof(CreateCaseTaskUser) + "}", request);

        //iWorkItem.SetCaseTaskUserAsync()

        //logger.LogInformation("Ended " + nameof(CreateCaseTaskUser) + " {@" + nameof(CreateCaseTaskUser) + "}", _outputResult);

        return;
    }
}