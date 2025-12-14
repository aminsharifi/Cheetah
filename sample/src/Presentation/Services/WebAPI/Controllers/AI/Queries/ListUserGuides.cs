using Cheetah.Core.Aggregates.AIAggregate.Facts;
using Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Queries;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands.AI;

public class ListUserGuides(ILogger<ListUserGuides> logger, IRepository<F_UserGuide> iSender) 
    : EndpointWithoutRequest<IEnumerable<ListUserGuidesResponse>>
{
    public override void Configure()
    {
        Get("/AI/Queries/ListUserGuides");
        AllowAnonymous();
    }
    public override async Task HandleAsync(CancellationToken cancellationToken)
    {
        //logger.LogInformation("started " + nameof(ListUserGuides) + " {@" + nameof(ListUserGuides) + "}", request);

        var _result = await iSender.ListAsync(cancellationToken);

        Response = _result.Select(x=>x.Adapt<ListUserGuidesResponse>());

        logger.LogInformation("Ended " + nameof(ListUserGuides) + " {@" + nameof(ListUserGuides) + "}", Response);

        return;
    }
    
}

