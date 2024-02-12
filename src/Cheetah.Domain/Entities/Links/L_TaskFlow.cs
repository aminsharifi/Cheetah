namespace Cheetah.Domain.Entities.Links;

public partial class L_TaskFlow : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual F_Task? Task { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual F_Flow? Flow { get; set; }

    public L_TaskFlow ShallowCopy()
    {
        return (L_TaskFlow)MemberwiseClone();
    }
}