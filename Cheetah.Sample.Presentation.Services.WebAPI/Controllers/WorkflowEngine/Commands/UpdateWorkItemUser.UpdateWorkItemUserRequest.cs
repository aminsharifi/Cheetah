using Cheetah.Core.Interfaces.WorkItem.DTOs;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class UpdateWorkItemUserRequest : UpdateWorkItemUser_Request
{
    public const string Route = "/WorkflowEngine/Commands/" + nameof(UpdateWorkItemUser);
}
