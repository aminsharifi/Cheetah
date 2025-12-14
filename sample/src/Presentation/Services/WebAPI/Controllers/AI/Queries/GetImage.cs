using Cheetah.Core.Aggregates.AIAggregate.Facts;
using Cheetah.Core.Aggregates.CaseAggregate.Specifications;
using Cheetah.Sample.Presentation.Services.WebAPI.Controllers.WorkflowEngine.Queries;

namespace Cheetah.Sample.Presentation.Services.WebAPI.Controllers.AI.Queries;

public class GetImage(ILogger<GetImage> logger, IReadRepository<F_UploadedFile> uploadedFile) : Endpoint<GetImageRequest>
{
    public override void Configure()
    {
        Get(GetImageRequest.Route);
        AllowAnonymous();
    }
    public override async Task HandleAsync(GetImageRequest request, CancellationToken cancellationToken)
    {
        logger.LogInformation("started " + nameof(GetImage) + " {@" + nameof(GetImage) + "}", request);

        var image = await uploadedFile
            .FirstOrDefaultAsync(new GetImageSpec(request.Name), cancellationToken: cancellationToken);

        await Send.BytesAsync(
         bytes: image.Content,
         fileName: image.Name,
         contentType: image.ContentType,
         enableRangeProcessing: true,
         cancellation: cancellationToken);

        //Response = new FileInfo(request.Name).Adapt<GetImageResponse>();
        // File(image.Content, image.ContentType);

        logger.LogInformation("Ended " + nameof(GetImage) + " {@" + nameof(GetImage) + "}", Response);

        return;
    }

}