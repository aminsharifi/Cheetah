namespace Cheetah.Domain.Entities.Links;

public partial class L_FlowTask : BaseLink
{
    public virtual F_Flow? Flow { get; private set; }

    public virtual F_Task? Task { get; private set; }
    public L_FlowTask SetTask(F_Task? task)
    {
        this.Task = task;
        return this;
    }

    public L_FlowTask ShallowCopy()
    {
        return (L_FlowTask)MemberwiseClone();
    }
}