using Ardalis.SharedKernel;
using Cheetah.Core.Aggregates.AIAggregate.Facts;
using Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Queries;
using Cheetah.UseCases.DTOs.AI;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.AI.Queries;

public class GetUserGuide(ILogger<GetUserGuide> logger, IRepository<F_UserGuide> iSender)//: Endpoint<GetUserGuideRequest, GetUserGuideResponse>
{/*
    public override void Configure()
    {
        Get(GetUserGuideRequest.Route);
        AllowAnonymous();
    }
    public override async Task HandleAsync(GetUserGuideRequest request, CancellationToken cancellationToken)
    {
        logger.LogInformation("started " + nameof(GetUserGuide) + " {@" + nameof(GetUserGuide) + "}", request);

        var _result = await UseCases.Commands.AI.CreateUserGuide.Handle(iSender, request.Adapt<UserGuideDTO>());

        Response = _result.Adapt<GetUserGuideResponse>();

        logger.LogInformation("Ended " + nameof(GetUserGuide) + " {@" + nameof(GetUserGuide) + "}", Response);

        return;
    }
    */
}