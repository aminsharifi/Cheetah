using Cheetah.Core.Common;
using Cheetah.Core.Entities.Facts;

namespace Cheetah.Core.Aggregates.ProcessAggregate.Links.TaskCondition;

public partial class L_TaskCondition : BaseLink
{
    public virtual F_Task? Task { get; set; }

    public L_TaskCondition ShallowCopy()
    {
        return (L_TaskCondition)MemberwiseClone();
    }
}