using Cheetah.Core.Aggregates.AIAggregate.Facts;
using Cheetah.UseCases.DTOs.AI;

namespace Cheetah.UseCases.Commands.AI;

public static class CreateUserGuide
{
    public static async Task<Result<UserGuideDTO>> Handle(IRepository<F_UserGuide> userGuideRepository, UserGuideDTO userGuide)
    {
        var _returnValue = await userGuideRepository.AddAsync(userGuide.Adapt<F_UserGuide>());

        return _returnValue.Adapt<UserGuideDTO>();
    }
}