namespace Cheetah.Application.Services.gRPC.Services;

public interface IDbInitializer
{
    void Initialize();
}
public class DbInitializer(UserManager<IdentityUser> _userManager,
        RoleManager<IdentityRole> _roleManager,
        ApplicationDbContext _db) : IDbInitializer
{
    public async void Initialize()
    {
        try
        {
            if (_db.Database.GetPendingMigrations().Count() > 0)
            {
                _db.Database.Migrate();
            }
            if (!(await _roleManager.RoleExistsAsync(nameof(RoleProperty.User))))
            {
                await _roleManager.CreateAsync(new IdentityRole(nameof(RoleProperty.Admin)));

                await _roleManager.CreateAsync(new IdentityRole(nameof(RoleProperty.User)));

                IdentityUser user = new()
                {
                    UserName = "Admin",
                    Email = "Admin@poshtibanebartar.com",
                    EmailConfirmed = true
                };

                await _userManager.CreateAsync(user, "Cheetah@123");

                await _userManager.AddToRoleAsync(user, nameof(RoleProperty.Admin));
            }
        }
        catch (Exception ex)
        {

        }
    }
}