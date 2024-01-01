namespace Cheetah.Infrastructure.Persistence;

public interface IDbInitializer
{
    void Initialize(UserManager<IdentityUser> _userManager,
        RoleManager<IdentityRole> _roleManager,
        ApplicationDbContext _context);
}
public class DbInitializer() : IDbInitializer
{
    public async void Initialize(UserManager<IdentityUser> _userManager,
        RoleManager<IdentityRole> _roleManager,
        ApplicationDbContext _context)
    {
        await _context.Database.MigrateAsync();

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
}