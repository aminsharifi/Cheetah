using Cheetah.Core.Aggregates.ProcessAggregate.Facts;
using Cheetah.Core.Common;

namespace Cheetah.Core.Aggregates.ProcessAggregate.Links;

public partial class L_TaskFlow : BaseLink
{
    public virtual F_Task? Task { get; private set; }

    public virtual F_Flow? Flow { get; private set; }

    public L_TaskFlow SetTask(F_Task? task)
    {
        this.Task = task;
        return this;
    }
    public L_TaskFlow SetFlow(F_Flow? flow)
    {
        this.Flow = flow;
        return this;
    }
    public L_TaskFlow ShallowCopy()
    {
        return (L_TaskFlow)MemberwiseClone();
    }
}