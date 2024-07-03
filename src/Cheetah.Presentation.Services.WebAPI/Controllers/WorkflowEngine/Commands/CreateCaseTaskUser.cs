namespace Cheetah.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class CreateCaseTaskUser(ILogger<CreateCaseTaskUser> logger, IWorkItem iWorkItem) : Endpoint<CreateCaseTaskUserRequest, CreateCaseTaskUserResponse>
{
    public override void Configure()
    {
        Post(CreateCaseTaskUserRequest.Route);
        AllowAnonymous();
    }
    public override async Task HandleAsync(CreateCaseTaskUserRequest request, CancellationToken cancellationToken)
    {
        logger.LogInformation("started " + nameof(CreateCaseTaskUser) + " {@" + nameof(CreateCaseTaskUser) + "}", request);

        #region Input

        var _createCaseTaskUser_Request = request.Adapt<CreateCaseTaskUser_Request>();

        #endregion

        var Outputresult = await iWorkItem.SetCaseTaskUserAsync(_createCaseTaskUser_Request);

        Response = Outputresult.Value.Adapt<CreateCaseTaskUserResponse>();

        logger.LogInformation("Ended " + nameof(CreateCaseTaskUser) + " {@" + nameof(CreateCaseTaskUser) + "}", Outputresult);

        return;
    }
}