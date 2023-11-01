using Cheetah.Application.Business.Repository;
using Cheetah.Domain;
using Cheetah.Infrastructure.Persistence;
using Cheetah.Infrastructure.Persistence.Repository;
using Cheetah.Presentation.Web.Blazor.Server.Data;
using Cheetah.Presentation.Web.Blazor.Server.Helper;
using Cheetah.Presentation.Web.Blazor.Server.Services;
using Microsoft.AspNetCore.Hosting.StaticWebAssets;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using Serilog;
using Winton.Extensions.Configuration.Consul;

var builder = WebApplication.CreateBuilder(args);



if (builder.Environment.IsProduction())
{
    builder.WebHost.ConfigureKestrel(serverOptions =>
    {
        serverOptions.ListenAnyIP(1988, cfg => { cfg.Protocols = HttpProtocols.Http1; });
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
builder.Host.UseSerilog((context, configuration) => configuration.ReadFrom.Configuration(context.Configuration));
#endregion

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

builder.Services.AddTransient<DbInitialiser>();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddBootstrapBlazor();

//var DomainName = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;

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


//builder.Services.AddDefaultIdentity<ApplicationUser>()
//    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddDefaultTokenProviders().AddDefaultUI()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddScoped<IDbInitializer, DbInitializer>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddScoped(typeof(ITableCRUD), typeof(TableCRUD));
builder.Services.AddScoped(typeof(ITableCRUD), typeof(TableCRUD));
builder.Services.AddScoped(typeof(IWorkItem), typeof(WorkItem));
builder.Services.AddScoped(typeof(IView), typeof(View));
builder.Services.AddScoped(typeof(ISync), typeof(Sync));
builder.Services.AddScoped(typeof(ICartable), typeof(Cartable));
builder.Services.AddScoped(typeof(ICopyClass), typeof(CopyClass));



builder.Services.AddScoped<CNavigation>();

var app = builder.Build();

using var scope = app.Services.CreateScope();

var services = scope.ServiceProvider;

var initialiser = services.GetRequiredService<DbInitialiser>();

await initialiser.Run();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseSerilogRequestLogging();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

await SeedDatabase();

app.UseAuthentication();

app.UseAuthorization();

app.MapBlazorHub();

app.MapFallbackToPage("/_Host");

app.Run();

async Task SeedDatabase()
{
    using (var scope = app.Services.CreateScope())
    {
        var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
        await dbInitializer.Initialize();
    }
}
