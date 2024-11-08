using Cheetah.Core.Aggregates.AIAggregate.Facts;

namespace Cheetah.UseCases.Commands.AI;

public static class DeleteUserGuide
{
    public static async Task<Result<bool>> Handle(IRepository<F_UserGuide> userGuideRepository, long userGuideId)
    {
        var _userGuide = await userGuideRepository.GetByIdAsync(userGuideId);

        if (_userGuide is null)
        {
            return Result.NotFound();
        }

        await userGuideRepository.DeleteAsync(_userGuide, CancellationToken.None);

        return true;
    }
}