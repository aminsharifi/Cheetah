using Hangfire;

namespace Cheetah.Infrastructure.Persistence.Data;

public static class InitialiserExtensions
{
    public static async Task<WebApplication> InitializeCommonSettingsAsync(this WebApplicationBuilder? builder)
    {
        builder?.Services.AddExceptionHandler<GlobalExceptionHandler>();
        builder?.Services.AddProblemDetails();


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
        #region Hangfire

        GlobalConfiguration.Configuration
           .UseSqlServerStorage(builder.Configuration.GetConnectionString("DefaultConnection"));

        #endregion
        #region Serilog
        builder.Host.UseSerilog((context, configuration) =>
        configuration.ReadFrom.Configuration(context.Configuration));
        #endregion

        //builder.Services.addse
        builder.Services.AddValidatorsFromAssemblyContaining(typeof(BaseEntityValidation));

        #region DB
        var provider = builder.Configuration.GetValue("Provider", "Npgsql");
        var _nameSpace = nameof(Cheetah) + "." +
            nameof(Infrastructure) + "." +
            nameof(Persistence) + ".";
        if (provider is "Npgsql")
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            builder.Services.AddDbContext<ApplicationDbContext>(
                b => b.UseLazyLoadingProxies(false)
                .UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")
                , x => x.MigrationsAssembly(_nameSpace + "Providers.Npgsql")
                ),
                ServiceLifetime.Transient
                );
        }
        else
        {
            builder.Services.AddDbContext<ApplicationDbContext>(
                b => b.UseLazyLoadingProxies(false)
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
            .AddDefaultTokenProviders()
            .AddSignInManager();


        //builder.Services.AddAuthorization(options =>
        // options.AddPolicy(Policies.CanPurge, policy => policy.RequireRole(Roles.Administrator)));


        #region New Login

        #endregion


        #endregion

        #region Other services

        builder.Services.AddScoped(typeof(IDbInitializer), typeof(DbInitializer));
        builder.Services.AddScoped(typeof(ITableCRUD), typeof(TableCRUD));
        builder.Services.AddScoped(typeof(IWorkItem), typeof(WorkItem));
        builder.Services.AddScoped(typeof(ICartable), typeof(Cartable));
        builder.Services.AddScoped(typeof(ICopyClass), typeof(CopyClass));
        builder.Services.AddScoped(typeof(ISync), typeof(Sync));

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
            Assembly.GetAssembly(typeof(GetDetailCasesHandler)), // UseCases
        };
        builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(mediatRAssemblies!));
        builder.Services.AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
        builder.Services.AddScoped<IDomainEventDispatcher, MediatRDomainEventDispatcher>();
        #endregion

        #region Mapster
        var mapperConfig = new Mapper(GetConfiguredMappingConfig());
        builder.Services.AddSingleton<IMapper>(mapperConfig);
        #endregion

        #region Build & Config

        var app = builder.Build();
        app.UseExceptionHandler();
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

    /// <summary>
    /// Mapster(Mapper) global configuration settings
    /// To learn more about Mapster,
    /// see https://github.com/MapsterMapper/Mapster
    /// </summary>
    /// <returns></returns>
    public static TypeAdapterConfig GetConfiguredMappingConfig()
    {
        var config = TypeAdapterConfig.GlobalSettings;

        var mediatRAssemblies = new[]
       {
            Assembly.GetAssembly(typeof(D_Tag)), // Core
            Assembly.GetAssembly(typeof(GetDetailCasesHandler)), // UseCases
        };

        IList<IRegister> registers = config.Scan(mediatRAssemblies);

        config.Apply(registers);

        return config;
    }
}