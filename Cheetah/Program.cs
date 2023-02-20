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

builder.Services.AddScoped<IGeneralRepository<P_ParameterList>, P_ParameterListRepository>();
builder.Services.AddScoped<IGeneralRepository<P_ParameterType>, P_ParameterTypeRepository>();
builder.Services.AddScoped<IGeneralRepository<P_PositionOrg>, P_PositionOrgRepository>();
builder.Services.AddScoped<IGeneralRepository<P_ProcessEndorsement>, P_ProcessEndorsementRepository>();
builder.Services.AddScoped<IGeneralRepository<P_ProcessState>, P_ProcessStateRepository>();
builder.Services.AddScoped<IGeneralRepository<P_RequestTitle>, P_RequestTitleRepository>();
builder.Services.AddScoped<IGeneralRepository<P_RequestType>, P_RequestTypeRepository>();
builder.Services.AddScoped<IGeneralRepository<P_SubRequestTitle>, P_SubRequestTitleRepository>();

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
