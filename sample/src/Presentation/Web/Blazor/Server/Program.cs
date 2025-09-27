using Cheetah.Core.Resx;
using Cheetah.Sample.Infrastructure.Data;
using Cheetah.Sample.Presentation.Web.Blazor.Server.Components;
using Cheetah.Sample.Presentation.Web.Blazor.Server.Components.Account;
using Cheetah.Sample.Presentation.Web.Blazor.Server.Helper;
using KristofferStrube.Blazor.MediaCaptureStreams;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;

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

// Adding IMediaDevicesService to service collection.
builder.Services.AddMediaDevicesService();

builder.Services.AddSignalR(options =>
{
    options.MaximumReceiveMessageSize = 902400; // Set maximum message size to 900 KB (adjust as needed)
    //options.ClientTimeoutInterval = TimeSpan.FromMinutes(3);
    //options.KeepAliveInterval = TimeSpan.FromMinutes(3);
    options.EnableDetailedErrors = true; // Optional: Enable detailed errors for debugging
});

builder.Services.AddMudServices();

builder.Services.AddBootstrapBlazor();

builder.Services.AddHttpContextAccessor();

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("http://localhost:802/")
    //BaseAddress = new Uri("https://localhost:7277")
});

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

// Add a chat completion service:

string apiKey = _ai.GetValue<string>("ApiKey")!;
string modelId = _ai.GetValue<string>("ModelId")!;
string embeddingModelId = _ai.GetValue<string>("EmbeddingModelId")!;
var _endpoint = _ai.GetValue<string>("Endpoint");
var _embeddingEndpoint = _ai.GetValue<string>("EmbeddingEndpoint");

// string modelId = "AI21-Jamba-1.5-Mini";
// string modelId = "Cohere-command-r-08-2024";
#pragma warning disable SKEXP0010

var kernel = Kernel.CreateBuilder();


if (!String.IsNullOrEmpty(_endpoint))
{
    Uri endpoint = new Uri(_endpoint);
    kernel.AddOpenAIChatCompletion(modelId: modelId, apiKey: apiKey, endpoint: endpoint);

    kernel.AddOpenAITextEmbeddingGeneration(modelId: embeddingModelId, apiKey: apiKey,
        httpClient: new HttpClient { BaseAddress = endpoint });
}
else
{

    //var proxy = new WebProxy("192.168.100.31:808")
    //{
    //    Credentials = new NetworkCredential("a", "a")
    //};

    //var httpClientHandler = new HttpClientHandler
    //{
    //    Proxy = proxy,
    //    UseProxy = true,
    //};

    //var httpClient = new HttpClient(httpClientHandler);
    //kernel.AddOpenAIChatCompletion(modelId: modelId, apiKey: apiKey, httpClient: httpClient);
    //kernel.AddOpenAITextEmbeddingGeneration(modelId: embeddingModelId, apiKey: apiKey, httpClient: httpClient);
    kernel.AddOpenAIChatCompletion(modelId: modelId, apiKey: apiKey);
    kernel.AddOpenAITextEmbeddingGeneration(modelId: embeddingModelId, apiKey: apiKey);
}

var _kernelBuild = kernel.AddInMemoryVectorStore().Build();

builder.Services.AddTransient(serviceProvider =>
{
    return _kernelBuild;
});

builder.Services.AddTransient(sp =>
{
    var chatCompletionService = _kernelBuild.GetRequiredService<IChatCompletionService>();
    return chatCompletionService;
});
//builder.Services.AddSingleton(sp =>
//{
//    var userGuideInfo = kernel.GetRequiredService<UserGuideInfo>();
//    return userGuideInfo;
//});
// Add the plugin to the kernel

//kernel.Plugins.AddFromType<UserGuideInfo>("userguide_info");

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