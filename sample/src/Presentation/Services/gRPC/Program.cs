using Cheetah.Sample.Infrastructure.Data;
using Cheetah.Sample.Presentation.Services.gRPC.Middleware;
using Cheetah.Sample.Presentation.Services.gRPC.Services;

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



var app = await builder.InitializeSettingsAsync();

// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>();
app.MapGrpcService<RequestService>();
app.UseMiddleware<ExceptionMiddleware>();
app.MapGet("/health", () => Results.Ok());
app.Run();