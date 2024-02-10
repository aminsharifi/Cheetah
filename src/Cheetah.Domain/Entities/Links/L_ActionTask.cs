namespace Cheetah.Domain.Entities.Links;

public partial class L_ActionTask : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual F_Action? Action { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual F_Task? Task { get; set; }

    public L_ActionTask ShallowCopy()
    {
        return (L_ActionTask)MemberwiseClone();
    }
}