using Microsoft.SemanticKernel;
using System.ComponentModel;

namespace Cheetah.Sample.Presentation.Web.Blazor.Server.AI
{
    public class UserGuideItem
    {
        public long Id { get; set; }
        [Description("user guide's subject)")]
        public string Subject { get; set; }
        [Description("user guide's description)")]
        public string Description { get; set; }
        [Description("user guide's keyword)")]
        public string Keywords { get; set; }
        [Description("user guide's body)")]
        public string Body { get; set; }
    }
    public class UserGuideInfo
    {

        [KernelFunction("get_infos_from_userguide")]
        [Description("extract subject, description, and keywords from the user guide's  body")]
        [return: Description("subject, description, and keywords extracted from user guide")]
        public UserGuideItem GetInfosFromUserGuide([Description("user guide's  body")] UserGuideItem userGuideItem)
        {
            return userGuideItem;
        }
    }
}
