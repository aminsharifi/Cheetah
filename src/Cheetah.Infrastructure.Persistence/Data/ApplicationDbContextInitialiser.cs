using Cheetah.Infrastructure.Persistence.Data.Configurations;
using FluentAssertions.Common;

namespace Cheetah.Infrastructure.Persistence.Data;

public static class InitialiserExtensions
{
    public static async Task<WebApplication> InitializeCommonSettingsAsync(this WebApplicationBuilder? builder)
    {
        if (builder.Environment.IsProduction())
        {
            var _CONSUL = builder.Configuration.GetValue("CONSUL", "True");
            
            if (_CONSUL == "True")
            {
                builder.Host.ConfigureAppConfiguration((_, config) => { config.Sources.Clear(); });

                builder.Configuration.AddConsul(Environment.GetEnvironmentVariable("Key_Consul") ?? string.Empty,
                    options =>
                    {
                        options.ConsulConfigurationOptions =
                            cco =>
                            {
                                cco.Address =
                                    new Uri(Environment.GetEnvironmentVariable("Address_Consul") ?? string.Empty);
                                cco.Token = Environment.GetEnvironmentVariable("Token_Consul");
                            };
                        options.Optional = true;
                        options.PollWaitTime = TimeSpan.FromSeconds(5);
                        options.ReloadOnChange = true;
                    });
            }
        }

        #region Serilog
        builder.Host.UseSerilog((context, configuration) =>
        configuration.ReadFrom.Configuration(context.Configuration));
        #endregion

        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        var provider = builder.Configuration.GetValue("Provider", "Npgsql");

        if (provider is "Npgsql")
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            builder.Services.AddDbContext<ApplicationDbContext>(
                b => b.UseLazyLoadingProxies()
                .UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")
                , x => x.MigrationsAssembly("Cheetah.Infrastructure.Persistence.Providers.Npgsql")
                ),
                ServiceLifetime.Transient
                );
        }
        else
        {
            builder.Services.AddDbContext<ApplicationDbContext>(
                b => b.UseLazyLoadingProxies()
                .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
                x => x.MigrationsAssembly("Cheetah.Infrastructure.Persistence.Providers.SqlServer")),
                ServiceLifetime.Transient
                );
        }
        builder.Services.AddScoped(typeof(IIdentityService), typeof(IdentityService));
        builder.Services.AddScoped(typeof(IDbInitializer), typeof(DbInitializer));
        builder.Services.AddScoped(typeof(ITableCRUD), typeof(TableCRUD));
        builder.Services.AddScoped(typeof(IWorkItem), typeof(WorkItem));
        builder.Services.AddScoped(typeof(ICartable), typeof(Cartable));
        builder.Services.AddScoped(typeof(ICopyClass), typeof(CopyClass));

        builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
        {
            options.User.RequireUniqueEmail = false;
        })
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultUI()
            .AddDefaultTokenProviders();

        builder.Services.AddAuthorization(options =>
         options.AddPolicy(Policies.CanPurge, policy => policy.RequireRole(Roles.Administrator)));

        var app = builder.Build();

        app.UseSerilogRequestLogging();

        app.UseAuthentication();

        app.UseAuthorization();

        //using var Appscope = app.Services.CreateScope();

        //var initialiser = Appscope.ServiceProvider.GetRequiredService<ApplicationDbContextInitialiser>();

        //await initialiser.InitialiseAsync();

        //await initialiser.SeedAsync();

        using var scope = app.Services.CreateScope();

        var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();

        await dbInitializer.Initialize();

        return app;
    }
}

public class ApplicationDbContextInitialiser
{
    private readonly ILogger<ApplicationDbContextInitialiser> _logger;
    private readonly ApplicationDbContext _context;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;

    public ApplicationDbContextInitialiser(ILogger<ApplicationDbContextInitialiser> logger, ApplicationDbContext context, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _logger = logger;
        _context = context;
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public async Task InitialiseAsync()
    {
        try
        {
            await _context.Database.MigrateAsync();

        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while initialising the database.");
            throw;
        }
    }

    public async Task SeedAsync()
    {
        try
        {
            await TrySeedAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An error occurred while seeding the database.");
            throw;
        }
    }

    public async Task TrySeedAsync()
    {
        // Default roles
        var administratorRole = new IdentityRole(Roles.Administrator);

        if (_roleManager.Roles.All(r => r.Name != administratorRole.Name))
        {
            await _roleManager.CreateAsync(administratorRole);
        }

        // Default users
        var administrator = new ApplicationUser { UserName = "administrator@localhost", Email = "administrator@localhost" };

        if (_userManager.Users.All(u => u.UserName != administrator.UserName))
        {
            await _userManager.CreateAsync(administrator, "Administrator1!");
            if (!string.IsNullOrWhiteSpace(administratorRole.Name))
            {
                await _userManager.AddToRolesAsync(administrator, new[] { administratorRole.Name });
            }
        }

        // Default data
        // Seed, if necessary
        if (!_context.D_Tags.Any())
        {
            _context.D_Tags.Add(new D_Tag
            {
                Name = "",
                DisplayName = ""
            });

            await _context.SaveChangesAsync();
        }
    }
}