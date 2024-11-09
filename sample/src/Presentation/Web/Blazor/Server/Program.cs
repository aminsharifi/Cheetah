using Cheetah.Core.Resx;
using Cheetah.Sample.Infrastructure.Data;
using Cheetah.Sample.Presentation.Web.Blazor.Server.AI;
using Cheetah.Sample.Presentation.Web.Blazor.Server.Components;
using Cheetah.Sample.Presentation.Web.Blazor.Server.Components.Account;
using Cheetah.Sample.Presentation.Web.Blazor.Server.Helper;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<IGlobalization>
    (
    x => new Globalization(nameof(Cheetah) + "." +
    nameof(Cheetah.Presentation) + "." +
    nameof(Cheetah.Presentation.Web) + "." +
    nameof(Cheetah.Presentation.Web.Blazor) + "." +
    nameof(Cheetah.Presentation.Web.Blazor.Server)));

builder.Services.AddScoped<CNavigation>();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMudServices();

builder.Services.AddBootstrapBlazor();

builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped(sp => new HttpClient {
    BaseAddress = new Uri("http://localhost:802/") });

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

#region Semantic Kernel
var _ai = builder.Configuration.GetSection("AI");
builder
    .Services
    .AddKernel();
// Add a chat completion service:

string apiKey = _ai.GetValue<string>("ApiKey")!;
string modelId = _ai.GetValue<string>("ModelId")!;
Uri endpoint = new Uri(_ai.GetValue<string>("Endpoint")!);

// string modelId = "AI21-Jamba-1.5-Mini";
// string modelId = "Cohere-command-r-08-2024";
#pragma warning disable SKEXP0010

var kernel = Kernel.CreateBuilder()
    .AddOpenAIChatCompletion(modelId: modelId, apiKey: apiKey, endpoint: endpoint)
    .Build();

builder.Services.AddTransient((serviceProvider) =>
{
    return new Kernel(serviceProvider);
});

builder.Services.AddSingleton(sp =>
{
    var chatCompletionService = kernel.GetRequiredService<IChatCompletionService>();
    return chatCompletionService;
});
builder.Services.AddSingleton(sp =>
{
    var userGuideInfo = kernel.GetRequiredService<UserGuideInfo>();
    return userGuideInfo;
});
// Add the plugin to the kernel

kernel.Plugins.AddFromType<UserGuideInfo>("userguide_info");

#endregion

var app = await builder.InitializeSettingsAsync();


app.UseMigrationsEndPoint();

/*
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
*/

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Add additional endpoints required by the Identity /Account Razor components.
//app.MapAdditionalIdentityEndpoints();

app.Run();