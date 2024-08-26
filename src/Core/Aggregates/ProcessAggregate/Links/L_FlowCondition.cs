using Cheetah.Core.Aggregates.ProcessAggregate.Facts;
using Cheetah.Core.Common;

namespace Cheetah.Core.Aggregates.ProcessAggregate.Links;

public partial class L_FlowCondition : BaseLink
{
    public virtual F_Flow? Flow { get; set; }

    public L_FlowCondition ShallowCopy()
    {
        return (L_FlowCondition)MemberwiseClone();
    }
}