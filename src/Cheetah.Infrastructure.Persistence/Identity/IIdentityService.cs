using Ardalis.Result;

namespace Cheetah.Infrastructure.Persistence.Identity
{
    public interface IIdentityService
    {
        string AccessToken { get; set; }

        Task<string> Authenticate(string email, string password);
        Task<bool> AuthorizeAsync(string userId, string policyName);
        Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password);
        Task<Result> DeleteUserAsync(ApplicationUser user);
        Task<Result> DeleteUserAsync(string userId);
        Task<string?> GetUserNameAsync(string userId);
        Task<bool> IsInRoleAsync(string userId, string role);
    }
}