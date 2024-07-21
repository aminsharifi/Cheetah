using Cheetah.Domain.Common;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Domain.Aggregates.ProcessAggregate.Links;

public partial class L_FlowTask : BaseLink
{
    public virtual F_Flow? Flow { get; private set; }

    public virtual F_Task? Task { get; private set; }
    public L_FlowTask SetTask(F_Task? task)
    {
        Task = task;
        return this;
    }

    public L_FlowTask ShallowCopy()
    {
        return (L_FlowTask)MemberwiseClone();
    }
}