namespace Cheetah.Infrastructure.Persistence;

public interface IDbInitializer
{
    Task<Boolean> Initialize();
}
public class DbInitializer : IDbInitializer
{

    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly ApplicationDbContext _db;
    public DbInitializer(UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager,
        ApplicationDbContext db)
    {
        _db = db;
        _roleManager = roleManager;
        _userManager = userManager;
    }

    public async Task<Boolean> Initialize()
    {
        if (_db.Database.GetPendingMigrations().Count() > 0)
        {
            _db.Database.Migrate();
        }
        if (!(await _roleManager.RoleExistsAsync(nameof(RoleProperty.User))))
        {
            await _roleManager.CreateAsync(new IdentityRole(nameof(RoleProperty.Admin)));

            await _roleManager.CreateAsync(new IdentityRole(nameof(RoleProperty.User)));

            ApplicationUser user = new()
            {
                UserName = "Admin",
                Email = "Admin@poshtibanebartar.com",
                EmailConfirmed = true
            };

            await _userManager.CreateAsync(user, "Cheetah@123");

            await _userManager.AddToRoleAsync(user, nameof(RoleProperty.Admin));
        }
        return true;
    }
}