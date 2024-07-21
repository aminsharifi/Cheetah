using Cheetah.Domain.Common;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Domain.Aggregates.ProcessAggregate.Links;

public partial class L_FlowCondition : BaseLink
{
    public virtual F_Flow? Flow { get; set; }

    public L_FlowCondition ShallowCopy()
    {
        return (L_FlowCondition)MemberwiseClone();
    }
}