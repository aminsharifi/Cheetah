using Cheetah.Application.Business.Repository;
using Cheetah.Application.Services.gRPC.Middleware;
using Cheetah.Application.Services.gRPC.Services;
using Cheetah.Infrastructure.Persistence;
using Cheetah.Infrastructure.Persistence.Repository;
using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using Serilog;

var builder = WebApplication.CreateBuilder(args);

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
        , x => x.MigrationsAssembly("cheetah_data_access_npgsql")
        ),
        ServiceLifetime.Transient
        );
}
else
{
    builder.Services.AddDbContext<ApplicationDbContext>(
        b => b.UseLazyLoadingProxies()
        .UseSqlServer(builder.Configuration.GetConnectionString("SQLServer"),
        x => x.MigrationsAssembly("cheetah_data_access_sqlserver")),
        ServiceLifetime.Transient
        );
}

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddScoped(typeof(ITableCRUD), typeof(TableCRUD));
builder.Services.AddScoped(typeof(IWorkItem), typeof(WorkItem));
builder.Services.AddScoped(typeof(IView), typeof(View));
builder.Services.AddScoped(typeof(ISync), typeof(Sync));
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
app.Run();