namespace Cheetah.Infrastructure.Persistence;
public interface IIdentityService
{
    Task<string> Authenticate(string email, string password);
}

public class IdentityService : IIdentityService
{
    public String AccessToken { get; set; }
    public IdentityService()
    {

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