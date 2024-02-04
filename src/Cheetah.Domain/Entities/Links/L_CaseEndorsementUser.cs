namespace Cheetah.Domain.Entities.Links;

public partial class L_CaseTaskUser : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual F_Case? Case { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual F_Task? Task { get; set; }

    [ForeignKey(nameof(ThirdId))]
    public virtual D_User? User { get; set; }

    public L_CaseTaskUser ShallowCopy()
    {
        return (L_CaseTaskUser)MemberwiseClone();
    }
}