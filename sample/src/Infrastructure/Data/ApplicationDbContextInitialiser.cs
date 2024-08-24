using Cheetah.Core.Interfaces;
using Cheetah.Infrastructure.Data;
using Cheetah.Sample.Infrastructure.Identity;
using Cheetah.UseCases.Services;
using Hangfire;
using Serilog;
using Serilog.Extensions.Logging;
using Serilog.Sinks.MSSqlServer;
using Winton.Extensions.Configuration.Consul;

namespace Cheetah.Sample.Infrastructure.Data;

public static class InitialiserExtensions
{
    public static async Task<WebApplication> InitializeSettingsAsync(this WebApplicationBuilder builder)
    {
        var _connection = builder.Configuration.GetConnectionString("DefaultConnection");
        builder.CheetahConfigurationAsync(_connection!);
        GlobalConfiguration.Configuration.UseSqlServerStorage(_connection);
        builder?.Services.AddExceptionHandler<GlobalExceptionHandler>();
        builder?.Services.AddProblemDetails();

        builder.Services.AddScoped(typeof(IDbInitializer), typeof(DbInitializer));

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

        #region DB
        var provider = builder.Configuration.GetValue("Provider", "Npgsql");

        var _nameSpace = "Cheetah.Sample.Infrastructure";
        if (provider is "Npgsql")
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

            builder.Services.AddDbContext<ApplicationDbContext>(
                b => b.UseLazyLoadingProxies(true)
                .UseNpgsql(_connection,
                x => x.MigrationsAssembly(_nameSpace)
                ),
                ServiceLifetime.Transient
                );
        }
        else
        {
            builder.Services.AddDbContext<ApplicationDbContext>(
                b => b.UseLazyLoadingProxies(true)
                .UseSqlServer(_connection,
                x => x.MigrationsAssembly(_nameSpace)
                .EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(30),
                    errorNumbersToAdd: null)),
                ServiceLifetime.Transient
                );
        }
        #endregion

        builder.Services.AddScoped(typeof(ISync), typeof(Sync));

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

        #region DB Initials

        try
        {
            using var scope = app.Services.CreateScope();
            var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
            await dbInitializer.Initialize();
        }
        catch (Exception ex)
        {

            throw;
        }

        #endregion

        return app;
    }
}