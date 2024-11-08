using Cheetah.Core.Aggregates.AIAggregate.Facts;
using Cheetah.UseCases.DTOs.AI;

namespace Cheetah.UseCases.Commands.AI;

public static class UpdateUserGuide
{
    public static async Task<Result<UserGuideDTO>> Handle(IRepository<F_UserGuide> userGuideRepository, UserGuideDTO userGuide)
    {
        var _userGuide = await userGuideRepository.GetByIdAsync(userGuide.Id);

        if (_userGuide == null)
        {
            return Result.NotFound();
        }

        _userGuide
            .SetSubject(userGuide.Subject)
            .SetDescription(userGuide.Description)
            .SetKeywords(userGuide.Keywords)
            .SetBody(userGuide.Body);

        await userGuideRepository.UpdateAsync(_userGuide, CancellationToken.None);

        return _userGuide.Adapt<UserGuideDTO>();
    }
}