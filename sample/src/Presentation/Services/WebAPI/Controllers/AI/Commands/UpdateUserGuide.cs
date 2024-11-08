using Ardalis.SharedKernel;
using Cheetah.Core.Aggregates.AIAggregate.Facts;
using Cheetah.UseCases.DTOs.AI;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands.AI;

public class UpdateUserGuide(ILogger<UpdateUserGuide> logger, IRepository<F_UserGuide> iSender) : Endpoint<UpdateUserGuideRequest, UpdateUserGuideResponse>
{
    public override void Configure()
    {
        Put(UpdateUserGuideRequest.Route);
        AllowAnonymous();
    }
    public override async Task HandleAsync(UpdateUserGuideRequest request, CancellationToken cancellationToken)
    {
        logger.LogInformation("started " + nameof(UpdateUserGuide) + " {@" + nameof(UpdateUserGuide) + "}", request);

        var _result = await UseCases.Commands.AI.UpdateUserGuide.Handle(iSender, request.Adapt<UserGuideDTO>());

        Response = _result.Value.Adapt<UpdateUserGuideResponse>();

        logger.LogInformation("Ended " + nameof(UpdateUserGuide) + " {@" + nameof(UpdateUserGuide) + "}", Response);

        return;
    }
}