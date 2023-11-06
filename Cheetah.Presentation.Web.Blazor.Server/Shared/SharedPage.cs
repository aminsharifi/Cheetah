

namespace Cheetah.Presentation.Web.Blazor.Server.Shared;

public class SharedPage : ComponentBase
{
    #region Parameters

    [Parameter]
    public long? Id { get; set; } = 0;

    [Parameter]
    public long? LinkId { get; set; } = 0;

    [Parameter]
    public String Name { get; set; }

    [Parameter]
    public String Href { get; set; }

    [Parameter]
    public String? reference { get; set; }

    [Parameter]
    public Boolean IsInline { get; set; } = false;

    [Parameter]
    public CrudOperation crudOperation { get; set; }

    [Parameter]
    public SimpleClass Record { get; set; }

    [Parameter]
    public IEnumerable<SimpleClass> Records { get; set; } = new List<SimpleClass>();

    [Parameter]
    public IEnumerable<SimpleClass> AllRecords { get; set; } = new List<SimpleClass>();

    [Parameter]
    public IEnumerable<SimpleLinkClass> AllLink { get; set; } = new List<SimpleLinkClass>();

    [Parameter]
    public SimpleLinkClassDTO LinkRecords { get; set; } = new();


    [Parameter]
    public String? FilterTableName { get; set; }

    [Parameter]
    public String? type { get; set; }

    [Parameter]
    public String Title { get; set; } = "ایجاد";

    [Parameter]
    public Boolean IsLoading { get; set; } = true;

    [Parameter]
    public Boolean LoadData { get; set; } = false;

    [Parameter]
    public RenderFragment? HeaderTemplate { get; set; }

    [Parameter]
    public RenderFragment? RowTemplate { get; set; }

    [Parameter]
    public EventCallback ParentCallback { get; set; }

    public Dictionary<string, string> keyValuePair { get; set; } = new Dictionary<string, string>();


    #endregion

    #region Injects

    [Inject]
    protected ITableCRUD simpleClassRepository { get; set; }

    [Inject]
    protected IGlobalization globalization { get; set; }

    [Inject]
    protected ISnackbar Snackbar { get; set; }

    [Inject]
    protected IJSRuntime _JsRuntime { get; set; }

    [Inject]
    protected NavigationManager _NavigationManager { get; set; }

    [Inject]
    protected CNavigation _CNavigation { get; set; }

    [Inject]
    protected ApplicationDbContext _db { get; set; }
    #endregion
}
