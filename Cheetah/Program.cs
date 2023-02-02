using Cheetah.Data;
using Cheetah_Business.Repository;
using Cheetah_Business.Repository.IRepository;
using Cheetah_DataAccess.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
 
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddBootstrapBlazor();

//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDbContext<ApplicationDbContext>(x =>
x.UseSqlServer(builder.Configuration.GetConnectionString("CheetahConnection")));

builder.Services.AddScoped<ICopyROLERepository, CopyROLERepository>();

builder.Services.AddScoped<IP_ParameterListRepository, P_ParameterListRepository>();
builder.Services.AddScoped<IP_ParameterTypeRepository, P_ParameterTypeRepository>();
builder.Services.AddScoped<IP_PositionOrgRepository, P_PositionOrgRepository>();
builder.Services.AddScoped<IP_ProcessEndorsementRepository, P_ProcessEndorsementRepository>();
builder.Services.AddScoped<IP_ProcessStateRepository, P_ProcessStateRepository>();
builder.Services.AddScoped<IP_RequestTitleRepository, P_RequestTitleRepository>();
builder.Services.AddScoped<IP_RequestTypeRepository, P_RequestTypeRepository>();
builder.Services.AddScoped<IP_SubRequestTitleRepository, P_SubRequestTitleRepository>();
builder.Services.AddScoped<IP_UserActionGroupRepository, P_UserActionGroupRepository>();
builder.Services.AddScoped<IP_UserActionRepository, P_UserActionRepository>();
builder.Services.AddScoped<IBasePSClassRepository, BasePSClassRepository>();

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
