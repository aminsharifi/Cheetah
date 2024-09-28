using Cheetah.Core.Common;
using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Enums;
using Cheetah.Sample.Presentation.Web.Blazor.Server.Helper;

namespace Cheetah.Sample.Presentation.Web.Blazor.Server.Components.Shared;
public class SharedPage : MyComponentBase
{
    #region Parameters

    [Parameter]
    public long? Id { get; set; } = 0;

    [Parameter]
    public long? LinkId { get; set; } = 0;

    [Parameter]
    public string Name { get; set; }

    [Parameter]
    public bool? Sync { get; set; }

    [Parameter]
    public bool? Create { get; set; } = false;
    [Parameter]
    public bool? Read { get; set; } = false;
    [Parameter]
    public bool? Update { get; set; } = false;
    [Parameter]
    public bool? Delete { get; set; } = false;

    [Parameter]
    public bool ReadonlyState { get; set; } = false;

    [Parameter]
    public string Href { get; set; }

    [Parameter]
    public string? reference { get; set; }

    [Parameter]
    public bool IsInline { get; set; } = false;

    [Parameter]
    public CrudOperation crudOperation { get; set; }

    [Parameter]
    public BaseEntity Record { get; set; }

    [Parameter]
    public IEnumerable<BaseEntity> Records { get; set; } = new List<BaseEntity>();

    [Parameter]
    public IEnumerable<BaseEntity> AllRecords { get; set; } = new List<BaseEntity>();

    [Parameter]
    public IEnumerable<BaseLink> AllLink { get; set; } = new List<BaseLink>();

    [Parameter]
    public LinkStateClassDTO LinkRecords { get; set; } = new();


    [Parameter]
    public string? FilterTableName { get; set; }

    [Parameter]
    public string? type { get; set; }

    [Parameter]
    public string Title { get; set; } = "ایجاد";

    [Parameter]
    public bool IsLoading { get; set; } = true;

    [Parameter]
    public bool LoadData { get; set; } = false;

    [Parameter]
    public RenderFragment? HeaderTemplate { get; set; }

    [Parameter]
    public RenderFragment? RowTemplate { get; set; }

    [Parameter]
    public EventCallback ParentCallback { get; set; }

    public Dictionary<string, string> keyValuePair { get; set; } = new();

    #endregion  
}
