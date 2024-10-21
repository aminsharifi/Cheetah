using Cheetah.Core.Interfaces.Cartable.DTOs;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Queries;

public class ListOutboxRequest : CartableRequest
{
    public const string Route = "/WorkflowEngine/Queries/ListOutbox";
}