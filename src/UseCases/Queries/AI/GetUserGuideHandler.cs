using Cheetah.Core.Aggregates.AIAggregate.Facts;
using Cheetah.UseCases.DTOs.AI;

namespace Cheetah.UseCases.Queries.Case.Case.Get;

public class GetUserGuideHandler(IReadRepository<F_UserGuide> userGuideRepository) :
    IQueryHandler<GetUserGuideQuery, Result<UserGuideDTO>>
{
    public async Task<Result<UserGuideDTO>> Handle(GetUserGuideQuery request, CancellationToken cancellationToken)
    {
        Guard.Against.Zero(request.Id);

        var _userGuide = await userGuideRepository.GetByIdAsync(request.Id);

        return _userGuide.Adapt<UserGuideDTO>()!;
    }
}