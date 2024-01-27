var builder = WebApplication.CreateBuilder(args);

StaticWebAssetsLoader.UseStaticWebAssets(builder.Environment, builder.Configuration);

builder.Services.AddSingleton<IGlobalization>
    (x => new Globalization(nameof(Cheetah) + "." + nameof(Cheetah.Presentation) + "." +
    nameof(Cheetah.Presentation.Web) + "." +
    nameof(Cheetah.Presentation.Web.Blazor) + "." + nameof(Cheetah.Presentation.Web.Blazor.Server)));

builder.Services.AddScoped<CNavigation>();

if (builder.Environment.IsProduction())
{
    builder.WebHost.ConfigureKestrel(serverOptions =>
    {
        serverOptions.ListenAnyIP(1988, cfg => { cfg.Protocols = HttpProtocols.Http1; });
    });    
}

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddMudServices();
builder.Services.AddBootstrapBlazor();

//builder.Services
//  .AddIdentityCore<ApplicationUser>();

var app = await builder.InitializeCommonSettingsAsync();

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