using Cheetah.Data;
using Cheetah_Business.Repository.IRepository;
using Cheetah_DataAccess.Data;
using Cheetah_DataAccess.Parameters;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddBootstrapBlazor();

builder.Services.AddDbContext<ApplicationDbContext>(
    b => b.UseLazyLoadingProxies()
          .UseSqlServer(builder.Configuration.GetConnectionString("CheetahConnection")),
           ServiceLifetime.Transient);

builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddScoped(typeof(IGeneralRepository<>), typeof(GeneralRepository<>));
builder.Services.AddScoped(typeof(IGeneralLinkRepository<>), typeof(GeneralLinkRepository<>));

//builder.Services.AddScoped<IGeneralRepository<D_ParameterList>, P_ParameterListRepository>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

var app = builder.Build();

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

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
