using Cheetah.Core.Entities.Dimentions;
using Cheetah.Core.Interfaces;
using Cheetah.Core.Interfaces.Cartable;
using Cheetah.Core.Interfaces.WorkItem;
using Cheetah.Infrastructure.Services;
using Cheetah.UseCases.Services;
using Cheetah.UseCases.Validations;

namespace Cheetah.Infrastructure.Data;

public static class CheetahInitialiserExtensions
{
    public static async Task<WebApplication> InitializeCheetahSettingsAsync(this WebApplicationBuilder? builder)
    {
        builder?.Services.AddExceptionHandler<GlobalExceptionHandler>();
        builder?.Services.AddProblemDetails();
        //builder.Services.addse
        builder.Services.AddValidatorsFromAssemblyContaining(typeof(BaseEntityValidation));

        #region Other services

        builder.Services.AddScoped(typeof(IDbInitializer), typeof(CheetahDbInitialiser));
        builder.Services.AddScoped(typeof(ITableCRUD), typeof(TableCRUD));
        builder.Services.AddScoped(typeof(IWorkItem), typeof(WorkItem));
        builder.Services.AddScoped(typeof(ICartable), typeof(Cartable));
        builder.Services.AddScoped(typeof(ICopyClass), typeof(CopyClass));
        builder.Services.AddScoped(typeof(ISync), typeof(Sync));

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

        builder.Services.AddInfrastructureServices(builder.Configuration, microsoftLogger);

        #endregion

        #region MediatR

        var mediatRAssemblies = new[]
        {
            Assembly.GetAssembly(typeof(D_Tag)), // Core
            Assembly.GetAssembly(typeof(Cartable)), // UseCases
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
            Assembly.GetAssembly(typeof(Cartable)), // UseCases
        };

        IList<IRegister> registers = config.Scan(mediatRAssemblies);

        config.Apply(registers);

        return config;
    }
}