using Cheetah.Core.Interfaces.WorkItem;
using Cheetah.Core.Interfaces.WorkItem.DTOs;

namespace Cheetah.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class UpdateWorkItemUser(ILogger<UpdateWorkItemUser> logger, IWorkItem iWorkItem) : Endpoint<UpdateWorkItemUserRequest, UpdateWorkItemUserResponse>
{
    public override void Configure()
    {
        Post(UpdateWorkItemUserRequest.Route);
        AllowAnonymous();
    }
    public override async Task HandleAsync(UpdateWorkItemUserRequest request, CancellationToken cancellationToken)
    {
        logger.LogInformation("started " + nameof(UpdateWorkItemUser) + " {@" + nameof(UpdateWorkItemUser) + "}", request);

        #region Input

        var _createCaseTaskUser_Request = request.Adapt<UpdateWorkItemUser_Request>();

        #endregion

        var Outputresult = await iWorkItem.SetCaseTaskUserAsync(_createCaseTaskUser_Request);

        Response = Outputresult.Value.Adapt<UpdateWorkItemUserResponse>();

        logger.LogInformation("Ended " + nameof(UpdateWorkItemUser) + " {@" + nameof(UpdateWorkItemUser) + "}", Outputresult);

        return;
    }
}