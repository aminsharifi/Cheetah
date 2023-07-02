using Cheetah.Data;
using Cheetah.Services;
using Cheetah_Business;
using Cheetah_Business.Repository;
using Cheetah_DataAccess.Data;
using Cheetah_DataAccess.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<DbInitialiser>();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
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
        , x => x.MigrationsAssembly("Cheetah_DataAccess_Npgsql")
        ),
        ServiceLifetime.Transient
        );
}
else
{
    builder.Services.AddDbContext<ApplicationDbContext>(
        b => b.UseLazyLoadingProxies()
        .UseSqlServer(builder.Configuration.GetConnectionString("SQLServer"),
        x => x.MigrationsAssembly("Cheetah_DataAccess_SqlServer")),
        ServiceLifetime.Transient
        );
}


//builder.Services.AddDefaultIdentity<ApplicationUser>()
//    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddDefaultTokenProviders().AddDefaultUI()
    .AddEntityFrameworkStores<ApplicationDbContext>();


builder.Services.AddScoped(typeof(ISimpleClassRepository), typeof(SimpleClassRepository));

builder.Services.AddScoped<IDbInitializer, DbInitializer>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

SeedDatabase();

app.UseAuthentication();

app.UseAuthorization();

app.MapBlazorHub();

app.MapFallbackToPage("/_Host");

app.Run();

void SeedDatabase()
{
    using (var scope = app.Services.CreateScope())
    {
        var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
        dbInitializer.Initialize();
    }
}