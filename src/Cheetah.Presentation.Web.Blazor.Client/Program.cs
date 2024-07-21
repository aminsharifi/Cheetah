using Cheetah.Application.Business.Interfaces;
using Cheetah.Presentation.Web.Blazor.Client;
using Cheetah.Presentation.Web.Blazor.Client.Serivce;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration.GetValue<string>("BaseAPIUrl")) });
//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ITableCRUD, D_ParameterTypeService>();
await builder.Build().RunAsync();
