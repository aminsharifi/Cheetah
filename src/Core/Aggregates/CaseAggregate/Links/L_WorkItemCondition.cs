using Cheetah.Core.Common;
using Cheetah.Core.Entities.Facts;

namespace Cheetah.Core.Aggregates.CaseAggregate.Links;

public partial class L_WorkItemCondition : BaseLink
{
    public L_WorkItemCondition()
    {

    }
    public virtual F_WorkItem? WorkItem { get; set; }


    public L_WorkItemCondition ShallowCopy()
    {
        return (L_WorkItemCondition)MemberwiseClone();
    }
}