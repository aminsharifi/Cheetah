using Cheetah.Infrastructure.Data;
using Cheetah.Sample.Infrastructure.Identity;

namespace Cheetah.Sample.Infrastructure.Data;

public static class InitialiserExtensions
{
    public static async Task<WebApplication> InitializeSettingsAsync(this WebApplicationBuilder builder)
    {
        builder = builder.InitializeCheetahSettingsAsync();
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

        #region DB
        var provider = builder.Configuration.GetValue("Provider", "Npgsql");
        var _nameSpace = nameof(Cheetah) + "." +
            nameof(Infrastructure) + ".";
        if (provider is "Npgsql")
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            builder.Services.AddDbContext<ApplicationDbContext>(
                b => b.UseLazyLoadingProxies(true)
                .UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")
                , x => x.MigrationsAssembly(_nameSpace + "Providers.Npgsql")
                ),
                ServiceLifetime.Transient
                );

            builder.Services.AddDbContext<CheetahDbContext>(
               b => b.UseLazyLoadingProxies(true)
               .UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")
               , x => x.MigrationsAssembly(_nameSpace + "Providers.Npgsql")
               ),
               ServiceLifetime.Transient
               );
        }
        else
        {
            builder.Services.AddDbContext<CheetahDbContext>(
            b => b.UseLazyLoadingProxies(true)
            .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
            x => x.MigrationsAssembly(_nameSpace + "Providers.SqlServer")),
            ServiceLifetime.Transient
            );

            builder.Services.AddDbContext<ApplicationDbContext>(
                b => b.UseLazyLoadingProxies(true)
                .UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
                x => x.MigrationsAssembly(_nameSpace + "Providers.SqlServer")),
                ServiceLifetime.Transient
                );
        }
        #endregion

        #region Serilog
        builder.Host.UseSerilog((context, configuration) =>
        configuration.ReadFrom.Configuration(context.Configuration));

        var logger = Log.Logger = new LoggerConfiguration()
            .WriteTo
            .MSSqlServer(
            connectionString: builder.Configuration.GetConnectionString("DefaultConnection"),
            sinkOptions: new MSSqlServerSinkOptions { TableName = "LogEvents" })
            .CreateLogger();

        //var logger = Log.Logger = new LoggerConfiguration()
        //    .Enrich.FromLogContext()
        //    .WriteTo.Console()
        //    .WriteTo.MSSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
        //    sinkOptions: new MSSqlServerSinkOptions { TableName = "LogEvents" })
        //    .CreateLogger();

        var microsoftLogger = new SerilogLoggerFactory(logger).CreateLogger("Programm");

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

        #region Build & Config

        var app = builder.Build();
        app.UseExceptionHandler();
        app.UseSerilogRequestLogging();
        app.UseAuthentication();
        app.UseAuthorization();

        #endregion

        app = await app.CheetahSettingsAsync();

        #region DB Initials

        using var scope = app.Services.CreateScope();
        var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
        await dbInitializer.Initialize();

        #endregion

        return app;
    }
    /*
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
            Assembly.GetAssembly(typeof(Cartable)), // UseCases
        };

        IList<IRegister> registers = config.Scan(mediatRAssemblies);

        config.Apply(registers);

        return config;
    }
    */
}