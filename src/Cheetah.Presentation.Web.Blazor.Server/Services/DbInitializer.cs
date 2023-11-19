namespace Cheetah.Presentation.Web.Blazor.Server.Services;
public interface IDbInitializer
{
    Task Initialize();
}
public class DbInitializer(UserManager<IdentityUser> _userManager,
        RoleManager<IdentityRole> _roleManager,
        ApplicationDbContext _db) : IDbInitializer
{
    public async Task Initialize()
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
