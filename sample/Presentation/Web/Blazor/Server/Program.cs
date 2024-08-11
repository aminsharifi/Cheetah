using Cheetah.Core.Resx;
using Cheetah.Infrastructure.Data;
using Cheetah.Sample.Presentation.Web.Blazor.Server.Components;
using Cheetah.Sample.Presentation.Web.Blazor.Server.Components.Account;
using Cheetah.Sample.Presentation.Web.Blazor.Server.Helper;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IGlobalization>
    (
    x => new Globalization(nameof(Cheetah) + "." +
    nameof(Cheetah.Sample) +
    "." + nameof(Cheetah.Sample.Presentation) + "." +
    nameof(Cheetah.Sample.Presentation.Web) + "." +
    nameof(Cheetah.Sample.Presentation.Web.Blazor) + "." +
    nameof(Cheetah.Sample.Presentation.Web.Blazor.Server)));

builder.Services.AddScoped<CNavigation>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMudServices();

builder.Services.AddBootstrapBlazor();

builder.Services.AddHttpContextAccessor();

//builder.Services
//  .AddIdentityCore<ApplicationUser>();

#region New Login


builder.Services.AddCascadingAuthenticationState();
builder.Services.AddScoped<IdentityUserAccessor>();
builder.Services.AddScoped<IdentityRedirectManager>();
builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();
/*
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = IdentityConstants.ApplicationScheme;
    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
})
    .AddIdentityCookies();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");


builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddSignInManager()
    .AddDefaultTokenProviders();
*/
#endregion


//builder.Services.AddHttpClient<ITableCRUD, TableCRUD>(client =>
//{
//    client.BaseAddress = new Uri("http://localhost:1991/");
//});

var app = await builder.InitializeCheetahSettingsAsync();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
//app.MapAdditionalIdentityEndpoints();

app.Run();