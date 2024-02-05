namespace Cheetah.Domain.Entities.Links;

public partial class L_TaskAction : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual F_Task? Task { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual F_Action? Action { get; set; }

    public L_TaskAction ShallowCopy()
    {
        return (L_TaskAction)MemberwiseClone();
    }
}