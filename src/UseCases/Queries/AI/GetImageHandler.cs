using Cheetah.Core.Aggregates.AIAggregate.Facts;
using Cheetah.UseCases.DTOs.AI;

namespace Cheetah.UseCases.Queries.Case.Case.Get;

public class GetImageHandler(IReadRepository<F_UploadedFile> uploadedFileRepository) :
    IQueryHandler<GetUserGuideQuery, Result<UserGuideDTO>>
{
    public async ValueTask<Result<UserGuideDTO>> Handle(GetUserGuideQuery request, CancellationToken cancellationToken)
    {
        Guard.Against.Zero(request.Id);

        var _userGuide = await uploadedFileRepository.GetByIdAsync(request.Id);

        return _userGuide.Adapt<UserGuideDTO>()!;
    }
}