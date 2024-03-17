using Ardalis.Result;

namespace Cheetah.Infrastructure.Persistence.Identity;

public class IdentityService : IIdentityService
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly IUserClaimsPrincipalFactory<ApplicationUser> _userClaimsPrincipalFactory;
    private readonly IAuthorizationService _authorizationService;
    public String AccessToken { get; set; }
    public IdentityService()
    {

    }
    public IdentityService(
        UserManager<ApplicationUser> userManager,
        IUserClaimsPrincipalFactory<ApplicationUser> userClaimsPrincipalFactory,
        IAuthorizationService authorizationService)
    {
        _userManager = userManager;
        _userClaimsPrincipalFactory = userClaimsPrincipalFactory;
        _authorizationService = authorizationService;
    }

    public async Task<string?> GetUserNameAsync(string userId)
    {
        var user = await _userManager.Users.FirstAsync(u => u.Id == userId);

        return user.UserName;
    }

    public async Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password)
    {
        var user = new ApplicationUser
        {
            UserName = userName,
            Email = userName,
        };

        var result = await _userManager.CreateAsync(user, password);

        return (result.ToApplicationResult(), user.Id);
    }

    public async Task<bool> IsInRoleAsync(string userId, string role)
    {
        var user = _userManager.Users.SingleOrDefault(u => u.Id == userId);

        return user != null && await _userManager.IsInRoleAsync(user, role);
    }

    public async Task<bool> AuthorizeAsync(string userId, string policyName)
    {
        var user = _userManager.Users.SingleOrDefault(u => u.Id == userId);

        if (user == null)
        {
            return false;
        }

        var principal = await _userClaimsPrincipalFactory.CreateAsync(user);

        var result = await _authorizationService.AuthorizeAsync(principal, policyName);

        return result.Succeeded;
    }

    public async Task<Result> DeleteUserAsync(string userId)
    {
        var user = _userManager.Users.SingleOrDefault(u => u.Id == userId);

        return user != null ? await DeleteUserAsync(user) : Result.Success();
    }

    public async Task<Result> DeleteUserAsync(ApplicationUser user)
    {
        var result = await _userManager.DeleteAsync(user);

        return result.ToApplicationResult();
    }

    public async Task<string> Authenticate(string email, string password)
    {
        //Your custom logic here (e.g. database query)
        //Mocked for a sake of simplicity
        var roles = new List<string>();

        if (email.Contains("cheetah"))
        {
            roles.Add("Admin");
        }
        if (email.Contains("hr"))
        {
            roles.Add("hr");
        }

        if (email.Contains("dev"))
        {
            roles.Add("dev");
        }

        if (email.Contains("leader"))
        {
            roles.Add("leader");
        }

        if (email.Contains("employee"))
        {
            roles.Add("employee");
        }

        if (roles.Count > 0)
        {
            return GenerateAccessToken(email, Guid.NewGuid().ToString(), roles.ToArray());
        }

        throw new AuthenticationException();
    }

    private string GenerateAccessToken(string email, string userId, string[] roles)
    {
        //var signinKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("MohammadAmin Sharifi"));

        var key = new SymmetricSecurityKey(
            Encoding.UTF8.GetBytes("7D-EKQ99jzXE5cdByhOk_P-Ko_Z-yMoTFVUCe8H6GRk"));

        var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, userId),
                new Claim(ClaimTypes.Name, email)
            };

        claims = claims.Concat(roles.Select(role => new Claim(ClaimTypes.Role, role))).ToList();


        var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

        var token = new JwtSecurityToken(
            "http://192.168.10.189:805",
            "http://192.168.10.189:805",
            claims,
            expires: DateTime.Now.AddDays(90),
            signingCredentials: signingCredentials);
        AccessToken = new JwtSecurityTokenHandler().WriteToken(token);
        return AccessToken;
    }
}
