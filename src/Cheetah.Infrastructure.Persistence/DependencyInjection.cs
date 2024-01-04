namespace Cheetah.Infrastructure.Persistence;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("SQLServer");

        Guard.Against.Null(connectionString, message: "Connection string 'DefaultConnection' not found.");

        services.AddScoped<ISaveChangesInterceptor, BaseEntityInterceptor>();
        services.AddScoped<ISaveChangesInterceptor, DispatchDomainEventsInterceptor>();

        services.AddDbContext<ApplicationDbContext>((sp, options) =>
        {
            options.AddInterceptors(sp.GetServices<ISaveChangesInterceptor>());

#if (UseSQLite)
        options.UseSqlite(connectionString);
#else
            options.UseSqlServer(connectionString);
#endif
        });


        services.AddScoped<IApplicationDbContext>(provider => provider.GetRequiredService<ApplicationDbContext>());
        services.AddTransient<IIdentityService, IdentityService>();

        services.AddScoped<ApplicationDbContextInitialiser>();

#if (UseApiOnly)
    services.AddAuthentication()
        .AddBearerToken(IdentityConstants.BearerScheme);

    services.AddAuthorizationBuilder();

    services
        .AddIdentityCore<ApplicationUser>()
        .AddRoles<IdentityRole>()
        .AddEntityFrameworkStores<ApplicationDbContext>()
        .AddApiEndpoints();
#else
        services
            .AddDefaultIdentity<Cheetah.Infrastructure.Persistence.Identity.ApplicationUser>()
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>();
#endif

        services.AddSingleton(TimeProvider.System);


        services.AddAuthorization(options =>
            options.AddPolicy(Policies.CanPurge, policy => policy.RequireRole(Roles.Administrator)));

        return services;
    }
}
