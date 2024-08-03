using Cheetah.Application.Business.Interfaces;
using Cheetah.Domain.Interfaces.Cartable;
using Cheetah.Domain.Resx;
using Cheetah.Infrastructure.Persistence.Data;

namespace Cheetah.Presentation.Web.Blazor.Server.Helper;

public class MyComponentBase : ComponentBase
{
    [Inject] public IGlobalization globalization { get; set; } = default!;
    [Inject] public ITableCRUD simpleClassRepository { get; set; } = default!;
    [Inject] public ICartable iCartable { get; set; } = default!;
    [Inject] public IDbInitializer _IDbInitializer { get; set; } = default!;
    [Inject] public IJSRuntime _JSRuntime { get; set; } = default!;
    [Inject] public ISnackbar Snackbar { get; set; } = default!;
    [Inject] public IDialogService DialogService { get; set; } = default!;
    [Inject] public NavigationManager _NavigationManager { get; set; } = default!;
    [Inject] public CNavigation _CNavigation { get; set; } = default!;
    [Inject] public ApplicationDbContext _db { get; set; } = default!;

}
