using Cheetah.Core.Interfaces.Cartable.DTOs;
using Cheetah.Core.Interfaces.Cartable;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Queries;

public class ListOutbox(ILogger<ListOutbox> logger, ICartable iCartable) : Endpoint<ListOutboxRequest, ListOutboxResponse>
{
    public override void Configure()
    {
        Post(ListOutboxRequest.Route);
        AllowAnonymous();
    }
    public override async Task HandleAsync(ListOutboxRequest request, CancellationToken cancellationToken)
    {
        logger.LogInformation("started " + nameof(ListOutbox) + " {@" + nameof(ListOutbox) + "}", request);

        var output_Request = await iCartable.OutboxAsync(request.Adapt<Cartable_Request>());

        Response = output_Request.Value.Adapt<ListOutboxResponse>();

        logger.LogInformation("Ended " + nameof(ListOutbox) + " {@" + nameof(ListOutbox) + "}", output_Request);

        return;
    }
}