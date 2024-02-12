namespace Cheetah.Domain.Entities.Links;

public partial class L_FlowTask : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual F_Flow? Flow { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual F_Task? Task { get; set; }

    public L_FlowTask ShallowCopy()
    {
        return (L_FlowTask)MemberwiseClone();
    }
}