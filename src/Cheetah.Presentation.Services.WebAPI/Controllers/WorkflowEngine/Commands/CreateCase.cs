using Cheetah.Application.Business.DTOs.Case;
using Cheetah.Application.Business.Interfaces;

namespace Cheetah.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Commands;

public class CreateCase(ILogger<CreateCase> logger, IWorkItem iWorkItem) : Endpoint<CreateCaseRequest, CreateCaseResponse>
{
    public override void Configure()
    {
        Post(CreateCaseRequest.Route);
        AllowAnonymous();
    }
    public override async Task HandleAsync(CreateCaseRequest request, CancellationToken cancellationToken)
    {
        logger.LogInformation("started " + nameof(CreateCase) + " {@" + nameof(CreateCase) + "}", request);

        var _outputResult = await iWorkItem.CreateRequestAsync(request.Adapt<CreateCase_Request>());

        Response = _outputResult.Value.Adapt<CreateCaseResponse>();

        logger.LogInformation("Ended " + nameof(CreateCase) + " {@" + nameof(CreateCase) + "}", _outputResult);

        return;
    }
}
