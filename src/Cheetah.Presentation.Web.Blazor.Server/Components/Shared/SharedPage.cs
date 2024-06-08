using Cheetah.Domain.Common.DTOs;
using Cheetah.Domain.Enums;

namespace Cheetah.Presentation.Web.Blazor.Server.Shared;
public class SharedPage : MyComponentBase
{
    #region Parameters

    [Parameter]
    public long? Id { get; set; } = 0;

    [Parameter]
    public long? LinkId { get; set; } = 0;

    [Parameter]
    public String Name { get; set; }

    [Parameter]
    public Boolean? Sync { get; set; }

    [Parameter]
    public Boolean ReadonlyState { get; set; } = false;

    [Parameter]
    public String Href { get; set; }

    [Parameter]
    public String? reference { get; set; }

    [Parameter]
    public Boolean IsInline { get; set; } = false;

    [Parameter]
    public CrudOperation crudOperation { get; set; }

    [Parameter]
    public SimpleClassDTO Record { get; set; }

    [Parameter]
    public IEnumerable<SimpleClassDTO> Records { get; set; } = new List<SimpleClassDTO>();

    [Parameter]
    public IEnumerable<SimpleClassDTO> AllRecords { get; set; } = new List<SimpleClassDTO>();

    [Parameter]
    public IEnumerable<LinkSatetClass> AllLink { get; set; } = new List<LinkSatetClass>();

    [Parameter]
    public LinkSatetClass LinkRecords { get; set; } = new();


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

    public Dictionary<string, string> keyValuePair { get; set; } = new();

    #endregion  
}
