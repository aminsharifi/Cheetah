using Cheetah.Domain.Common;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Domain.Entities.Links;

public partial class L_TaskFlow : BaseLink
{
    public virtual F_Task? Task { get; private set; }

    public virtual F_Flow? Flow { get; private set; }

    public L_TaskFlow SetTask(F_Task? task)
    {
        this.Task = task;
        return this;
    }

    public L_TaskFlow ShallowCopy()
    {
        return (L_TaskFlow)MemberwiseClone();
    }
}