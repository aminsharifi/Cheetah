using Cheetah.Core.Aggregates.AIAggregate.Facts;
using Cheetah.Sample.Presentation.Services.WebAPI.Extensions;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands.AI;

public class DeleteUserGuide(ILogger<DeleteUserGuide> logger, IRepository<F_UserGuide> userGuideRepository)
      : Endpoint<DeleteUserGuideRequest, Results<NoContent, NotFound, ProblemHttpResult>>
{
    public override void Configure()
    {
        Delete("/AI/Commands/DeleteUserGuide/{Id:long}");
        AllowAnonymous();
    }

    public override async Task<Results<NoContent, NotFound, ProblemHttpResult>> ExecuteAsync(
       DeleteUserGuideRequest request, CancellationToken ct)
    {
        logger.LogInformation("started " + nameof(DeleteUserGuide) + " {@" + nameof(DeleteUserGuide) + "}", request);

        var result = await UseCases.Commands.AI.DeleteUserGuide.Handle(userGuideRepository, request.Id);

        logger.LogInformation("Ended " + nameof(DeleteUserGuide) + " {@" + nameof(DeleteUserGuide) + "}", Response);

        return result.ToDeleteResult();
    }
}