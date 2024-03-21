using Ardalis.ListStartupServices;
using Ardalis.SharedKernel;
using Cheetah.Application.Business.Tags.Create;
using Cheetah.Application.Services.gRPC.Middleware;
using Cheetah.Infrastructure.Persistence;
using MediatR;
using Serilog;
using Serilog.Extensions.Logging;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

if (builder.Environment.IsProduction())
{
    builder.WebHost.ConfigureKestrel(serverOptions =>
    {
        serverOptions.ListenAnyIP(1989, cfg => { cfg.Protocols = HttpProtocols.Http2; });
        serverOptions.ListenAnyIP(1990, cfg => { cfg.Protocols = HttpProtocols.Http1; });
    });
}

builder.Services.AddGrpc(options =>
{
    {
        options.Interceptors.Add<ServerLoggerInterceptor>();
        options.EnableDetailedErrors = true;
    }
});

builder.Services.AddTransient<ExceptionMiddleware>();

//AddShowAllServicesSupport();
ConfigureMediatR();

var logger = Log.Logger = new LoggerConfiguration()
  .Enrich.FromLogContext()
  .WriteTo.Console()
  .CreateLogger();

var microsoftLogger = new SerilogLoggerFactory(logger)
    .CreateLogger<Program>();

builder.Services.AddInfrastructureServices(builder.Configuration, microsoftLogger);

var app = await builder.InitializeCommonSettingsAsync();

// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>();
app.MapGrpcService<RequestService>();
app.UseMiddleware<ExceptionMiddleware>();
app.MapGet("/health", () => Results.Ok());
app.Run();

void ConfigureMediatR()
{
    var mediatRAssemblies = new[]
    {
        Assembly.GetAssembly(typeof(D_Tag)), // Core
        Assembly.GetAssembly(typeof(CreateTagCommand)), // UseCases
        
    };
    builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(mediatRAssemblies!));
    builder.Services.AddScoped(typeof(IPipelineBehavior<,>), typeof(LoggingBehavior<,>));
    builder.Services.AddScoped<IDomainEventDispatcher, MediatRDomainEventDispatcher>();
}
void AddShowAllServicesSupport()
{
    // add list services for diagnostic purposes - see https://github.com/ardalis/AspNetCoreStartupServices
    builder.Services.Configure<ServiceConfig>(config =>
    {
        config.Services = new List<ServiceDescriptor>(builder.Services);

        // optional - default path to view services is /listallservices - recommended to choose your own path
        config.Path = "/listservices";
    });
}
