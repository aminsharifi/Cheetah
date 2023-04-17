using Cheetah_Business.Repository.IRepository;
using Cheetah_Common;
using Cheetah_DataAccess.Data;
using Cheetah_DataAccess.Links;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;

namespace Cheetah.Shared
{
    public class SharedPage : ComponentBase
    {
        #region Parameters

        [Parameter]
        public long Id { get; set; } = 0;

        [Parameter]
        public long? LinkId { get; set; } = 0;

        [Parameter]
        public String Name { get; set; }

        [Parameter]
        public String? reference { get; set; }

        [Parameter]
        public Boolean IsInline { get; set; } = false;

        [Parameter]
        public SimpleClass Record { get; set; }

        [Parameter]
        public IEnumerable<SimpleClass> Records { get; set; } = new List<SimpleClass>();

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
        public Boolean IsUpdatedLink { get; set; } = false;

        [Parameter]
        public RenderFragment? RowTemplate { get; set; }

        [Parameter]
        public EventCallback ParentCallback { get; set; }

        public IEnumerable<KeyValuePair<string, string>> keyValuePair { get; set; } = new List<KeyValuePair<string, string>>();


        #endregion

        #region Injects

        [Inject]
        protected ISimpleClassRepository simpleClassRepository { get; set; }

        [Inject]
        protected NavigationManager _NavigationManager { get; set; }

        [Inject]
        protected CNavigation _CNavigation { get; set; }

        [Inject]
        protected IJSRuntime _JsRuntime { get; set; }
        #endregion
    }
}
