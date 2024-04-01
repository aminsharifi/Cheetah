namespace Cheetah.Infrastructure.Persistence.Data;

public static class InitialiserExtensions
{
    public static async Task<WebApplication> InitializeCommonSettingsAsync(this WebApplicationBuilder? builder)
    {
        #region Production
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
        #endregion

        #region Serilog
        builder.Host.UseSerilog((context, configuration) =>
        configuration.ReadFrom.Configuration(context.Configuration));
        #endregion

        #region DB
        var provider = builder.Configuration.GetValue("Provider", "Npgsql");
        var _nameSpace = nameof(Cheetah) + "." +
            nameof(Infrastructure) + "." +
            nameof(Persistence) + ".";
        if (provider is "Npgsql")
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            builder.Services.AddDbContext<ApplicationDbContext>(
                b => b.UseLazyLoadingProxies()
                .UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")
                , x => x.MigrationsAssembly(_nameSpace + "Providers.Npgsql")
                ),
                ServiceLifetime.Transient
                );
        }
        else
        {
            builder.Services.AddDbContext<ApplicationDbContext>(
                b => b.UseLazyLoadingProxies()
                .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
                x => x.MigrationsAssembly(_nameSpace + "Providers.SqlServer")),
                ServiceLifetime.Transient
                );
        }
        #endregion

        #region Identity
        builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
        {
            options.User.RequireUniqueEmail = false;
        })
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultUI()
            .AddDefaultTokenProviders();

        //builder.Services.AddAuthorization(options =>
        // options.AddPolicy(Policies.CanPurge, policy => policy.RequireRole(Roles.Administrator)));
        #endregion

        #region Other services

        builder.Services.AddScoped(typeof(IIdentityService), typeof(IdentityService));
        builder.Services.AddScoped(typeof(IDbInitializer), typeof(DbInitializer));
        builder.Services.AddScoped(typeof(ITableCRUD), typeof(TableCRUD));
        builder.Services.AddScoped(typeof(IWorkItem), typeof(WorkItem));
        builder.Services.AddScoped(typeof(ICartable), typeof(Cartable));
        builder.Services.AddScoped(typeof(ICopyClass), typeof(CopyClass));

        #endregion

        #region MediatR
        var logger = Log.Logger = new LoggerConfiguration()
            .Enrich.FromLogContext()
            .WriteTo.Console()
            .CreateLogger();

        var microsoftLogger = new SerilogLoggerFactory(logger).CreateLogger("Programm");

        builder.Services.AddInfrastructureServices(builder.Configuration, microsoftLogger);

        var mediatRAssemblies = new[]
        {
            Assembly.GetAssembly(typeof(D_Tag)), // Core
            Assembly.GetAssembly(typeof(CreateTagCommand)), // UseCases
        };
        builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(mediatRAssemblies!));
        builder.Services.AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
        builder.Services.AddScoped<IDomainEventDispatcher, MediatRDomainEventDispatcher>();
        #endregion

        #region Build & Config

        var app = builder.Build();
        app.UseSerilogRequestLogging();
        app.UseAuthentication();
        app.UseAuthorization();

        #endregion

        #region DB Initials

        using var scope = app.Services.CreateScope();
        var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
        await dbInitializer.Initialize();

        #endregion

        return app;
    }

}