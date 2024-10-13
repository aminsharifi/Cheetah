using Cheetah.Core.Enums;
using Cheetah.Sample.Infrastructure.Identity;
using System.Linq.Expressions;

namespace Cheetah.Sample.Infrastructure.Data;

public interface IDbInitializer
{
    Task<bool> Initialize();
}
public class DbInitializer : IDbInitializer
{
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    public readonly ApplicationDbContext _db;

    public DbInitializer(UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager,
        ApplicationDbContext db)
    {
        _db = db;
        _roleManager = roleManager;
        _userManager = userManager;
    }

    public async Task<bool> Initialize()
    {

        //if (await _userManager?.Users?.AnyAsync(x=>x.UserName == "Delete"))
        //{
        //    await _db.Database.EnsureCreatedAsync();
        //}

        var _database = _db.Database;

        var _pending = _database.GetPendingMigrations();

        var _cnt = _pending.Count();

        if (_cnt > 0)
        {
           _db.Database.Migrate();
        }
        try
        {
            if (!await _roleManager.RoleExistsAsync(nameof(RoleProperty.User)))
            {
                await _roleManager.CreateAsync(new IdentityRole(nameof(RoleProperty.User)));
            }

            if (!await _roleManager.RoleExistsAsync(nameof(RoleProperty.Admin)))
            {
                await _roleManager.CreateAsync(new IdentityRole(nameof(RoleProperty.Admin)));

                ApplicationUser user = new()
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


        return true;
    }
}