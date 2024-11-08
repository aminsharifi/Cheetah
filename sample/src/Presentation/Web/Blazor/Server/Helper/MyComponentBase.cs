using Cheetah.Core.Interfaces;
using Cheetah.Core.Interfaces.Cartable;
using Cheetah.Core.Resx;
using Cheetah.Infrastructure.Data;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel;
using System.Configuration;

namespace Cheetah.Sample.Presentation.Web.Blazor.Server.Helper;

public class MyComponentBase : ComponentBase
{
    [Inject] public IGlobalization globalization { get; set; } = default!;
    [Inject] public ITableCRUD simpleClassRepository { get; set; } = default!;
    [Inject] public ICartable iCartable { get; set; } = default!;
    [Inject] public ICheetahDbInitialiser _IDbInitializer { get; set; } = default!;
    [Inject] public IJSRuntime _JSRuntime { get; set; } = default!;
    [Inject] public IChatCompletionService ChatCompletionService { get; set; }
    [Inject] public Kernel _kernel { get; set; }
    [Inject] public IConfiguration Configuration { get; set; }
    [Inject] public HttpClient httpClient { get; set; } = default!;
    [Inject] public ISnackbar Snackbar { get; set; } = default!;
    [Inject] public IDialogService DialogService { get; set; } = default!;
    [Inject] public NavigationManager _NavigationManager { get; set; } = default!;
    [Inject] public CNavigation _CNavigation { get; set; } = default!;
    [Inject] public CheetahDbContext _db { get; set; } = default!;

}
