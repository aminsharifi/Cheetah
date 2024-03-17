using Ardalis.Result;

namespace Cheetah.Infrastructure.Persistence.Identity;

public static class IdentityResultExtensions
{
    public static Result ToApplicationResult(this IdentityResult result)
    {
        return result.Succeeded
            ? Result.Success()
            : Result.Error(result.Errors.Select(e => e.Description).FirstOrDefault());
    }
}
