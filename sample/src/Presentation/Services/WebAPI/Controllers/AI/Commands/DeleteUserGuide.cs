using Ardalis.SharedKernel;
using Cheetah.Core.Aggregates.AIAggregate.Facts;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands.AI;

public class DeleteUserGuide(ILogger<DeleteUserGuide> logger, IRepository<F_UserGuide> userGuideRepository)
    : Endpoint<DeleteUserGuideRequest>
{
    public override void Configure()
    {
        Delete("/AI/Commands/DeleteUserGuide/{Id:long}");
        AllowAnonymous();
    }
    public override async Task HandleAsync(DeleteUserGuideRequest request, CancellationToken cancellationToken)
    {
        logger.LogInformation("started " + nameof(DeleteUserGuide) + " {@" + nameof(DeleteUserGuide) + "}", request);

        //var itemId = Route<long>("id");

        var _result = await UseCases.Commands.AI.DeleteUserGuide.Handle(userGuideRepository, request.Id);

        if (_result.IsSuccess)
        {
            await SendNoContentAsync(cancellationToken);
        }
        else
        {
            await SendNotFoundAsync(cancellationToken);
            return;
        }

        logger.LogInformation("Ended " + nameof(DeleteUserGuide) + " {@" + nameof(DeleteUserGuide) + "}", Response);

        return;
    }

}