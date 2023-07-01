namespace Cheetah.Services
{
    using Cheetah_Business;
    using Cheetah_DataAccess.Data;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;

    public interface IDbInitializer
    {
        void Initialize();
    }
    public class DbInitializer : IDbInitializer
    {

        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationDbContext _db;
        public DbInitializer(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext db)
        {
            _db = db;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
                if (!_roleManager.RoleExistsAsync(nameof(RoleProperty.User)).GetAwaiter().GetResult())
                {
                    _roleManager.CreateAsync(new IdentityRole(nameof(RoleProperty.Admin))).GetAwaiter().GetResult();

                    _roleManager.CreateAsync(new IdentityRole(nameof(RoleProperty.User))).GetAwaiter().GetResult();

                    IdentityUser user = new()
                    {
                        UserName = "Admin",
                        Email = "Admin@poshtibanebartar.com",
                        EmailConfirmed = true
                    };

                    _userManager.CreateAsync(user, "Cheetah@123").GetAwaiter().GetResult();

                    _userManager.AddToRoleAsync(user, nameof(RoleProperty.Admin)).GetAwaiter().GetResult();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}