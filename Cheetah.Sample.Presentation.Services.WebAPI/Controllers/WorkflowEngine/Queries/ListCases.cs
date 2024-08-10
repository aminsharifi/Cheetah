using Cheetah.Core.Enums;
using Cheetah.Core.Interfaces.Cartable;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Queries;

public class ListCases(ILogger<ListCases> logger, ICartable iCartable)
    : Endpoint<ListCasesRequest, ListCasesResponse>
{
    public override void Configure()
    {
        Post(ListCasesRequest.Route);
        AllowAnonymous();
    }
    public override async Task HandleAsync(ListCasesRequest request, CancellationToken cancellationToken)
    {
        logger.LogInformation("started " + nameof(ListCases) + " {@" + nameof(ListCases) + "}", request);

        var output_Request = await iCartable.GetCartableAsync(request, CartableProperty.All);

        Response = output_Request.Value.Adapt<ListCasesResponse>();

        logger.LogInformation("Ended " + nameof(ListCases) + " {@" + nameof(ListCases) + "}", output_Request);

        return;
    }
}