using Cheetah.Core.Aggregates.AIAggregate.Facts;
using Cheetah.UseCases.DTOs.AI;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands.AI;

public class CreateUserGuide(ILogger<CreateUserGuide> logger, IRepository<F_UserGuide> userGuideRepository) : Endpoint<CreateUserGuideRequest, CreateUserGuideResponse>
{
    
    public override void Configure()
    {
        Post("AI/Commands/CreateUserGuide");
        AllowAnonymous();
    }
    public override async Task HandleAsync(CreateUserGuideRequest request, CancellationToken cancellationToken)
    {
        logger.LogInformation("started " + nameof(CreateUserGuide) + " {@" + nameof(CreateUserGuide) + "}", request);

        var _result = await UseCases.Commands.AI.CreateUserGuide.Handle(userGuideRepository, request.Adapt<UserGuideDTO>());

        Response = _result.Value.Adapt<CreateUserGuideResponse>();

        logger.LogInformation("Ended " + nameof(CreateUserGuide) + " {@" + nameof(CreateUserGuide) + "}", Response);

        return;
    }
    
}