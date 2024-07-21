using Cheetah.Domain.Common;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Domain.Aggregates.ProcessAggregate.Links.TaskCondition;

public partial class L_TaskCondition : BaseLink
{
    public virtual F_Task? Task { get; set; }

    public L_TaskCondition ShallowCopy()
    {
        return (L_TaskCondition)MemberwiseClone();
    }
}