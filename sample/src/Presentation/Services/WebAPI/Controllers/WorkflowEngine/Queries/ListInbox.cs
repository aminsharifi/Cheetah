using Cheetah.Core.Interfaces.Cartable.DTOs;
using Cheetah.Core.Interfaces.Cartable;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Queries;

public class ListInbox(ILogger<ListInbox> logger, ICartable iCartable) : Endpoint<ListInboxRequest, ListInboxResponse>
{
    public override void Configure()
    {
        Post(ListInboxRequest.Route);
        AllowAnonymous();
    }
    public override async Task HandleAsync(ListInboxRequest request, CancellationToken cancellationToken)
    {
        logger.LogInformation("started " + nameof(ListInbox) + " {@" + nameof(ListInbox) + "}", request);

        var output_Request = await iCartable.InboxAsync(request.Adapt<Cartable_Request>());

        Response = output_Request.Value.Adapt<ListInboxResponse>();

        logger.LogInformation("Ended " + nameof(ListInbox) + " {@" + nameof(ListInbox) + "}", output_Request);

        return;
    }
}