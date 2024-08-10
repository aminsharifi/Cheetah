using Cheetah.Core.Common;
using Cheetah.Core.Entities.Facts;

namespace Cheetah.Core.Aggregates.ProcessAggregate.Links;

public partial class L_FlowCondition : BaseLink
{
    public virtual F_Flow? Flow { get; set; }

    public L_FlowCondition ShallowCopy()
    {
        return (L_FlowCondition)MemberwiseClone();
    }
}