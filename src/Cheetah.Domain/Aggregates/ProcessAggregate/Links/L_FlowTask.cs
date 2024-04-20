namespace Cheetah.Domain.Entities.Links;

public partial class L_FlowTask : SimpleLinkClass
{
    public virtual F_Flow? Flow { get; set; }

    public virtual F_Task? Task { get; set; }

    public L_FlowTask ShallowCopy()
    {
        return (L_FlowTask)MemberwiseClone();
    }
}