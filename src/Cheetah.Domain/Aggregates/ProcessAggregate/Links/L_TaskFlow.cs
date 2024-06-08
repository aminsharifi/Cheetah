namespace Cheetah.Domain.Entities.Links;

public partial class L_TaskFlow : BaseLink
{
    public virtual F_Task? Task { get; set; }

    public virtual F_Flow? Flow { get; set; }

    public L_TaskFlow ShallowCopy()
    {
        return (L_TaskFlow)MemberwiseClone();
    }
}