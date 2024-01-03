var builder = WebApplication.CreateBuilder(args);

if (builder.Environment.IsProduction())
{
    builder.WebHost.ConfigureKestrel(serverOptions =>
    {
        serverOptions.ListenAnyIP(1989, cfg => { cfg.Protocols = HttpProtocols.Http2; });
        serverOptions.ListenAnyIP(1990, cfg => { cfg.Protocols = HttpProtocols.Http1; });
    });
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

#region Serilog
builder.Host.UseSerilog((context, configuration) =>
    configuration.ReadFrom.Configuration(context.Configuration));
#endregion


var provider = builder.Configuration.GetValue("Provider", "Npgsql");

if (provider is "Npgsql")
{
    AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

    builder.Services.AddDbContext<ApplicationDbContext>(
        b => b.UseLazyLoadingProxies()
        .UseNpgsql(builder.Configuration.GetConnectionString("Npgsql")
        , x => x.MigrationsAssembly("Cheetah.Infrastructure.Persistence.Providers.Npgsql")
        ),
        ServiceLifetime.Transient
        );
}
else
{
    builder.Services.AddDbContext<ApplicationDbContext>(
        b => b.UseLazyLoadingProxies()
        .UseSqlServer(builder.Configuration.GetConnectionString("SQLServer"),
        x => x.MigrationsAssembly("Cheetah.Infrastructure.Persistence.Providers.SqlServer")),
        ServiceLifetime.Transient
        );
}

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped(typeof(ITableCRUD), typeof(TableCRUD));
builder.Services.AddScoped(typeof(IWorkItem), typeof(WorkItem));
builder.Services.AddScoped(typeof(ICartable), typeof(Cartable));
builder.Services.AddScoped(typeof(ICopyClass), typeof(CopyClass));

//builder.Services.AddGrpc();

builder.Services.AddGrpc(options =>
{
    {
        options.Interceptors.Add<ServerLoggerInterceptor>();
        options.EnableDetailedErrors = true;
    }
});



builder.Services.AddTransient<ExceptionMiddleware>();
var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapGrpcService<GreeterService>();
app.MapGrpcService<RequestService>();
app.UseSerilogRequestLogging();
app.UseMiddleware<ExceptionMiddleware>();
app.MapGet("/health", () => Results.Ok());
app.Run();