using Cheetah.Core.Aggregates.ProcessAggregate.Facts;
using Cheetah.Core.Common;

namespace Cheetah.Core.Aggregates.ProcessAggregate.Links;

public partial class L_TaskCondition : BaseLink
{
    public virtual F_Task? Task { get; set; }

    public L_TaskCondition ShallowCopy()
    {
        return (L_TaskCondition)MemberwiseClone();
    }
}