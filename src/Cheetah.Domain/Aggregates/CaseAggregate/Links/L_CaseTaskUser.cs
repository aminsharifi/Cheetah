namespace Cheetah.Domain.Entities.Links;

public partial class L_CaseTaskUser : SimpleLinkClass
{
    public virtual F_Case? Case { get; set; }

    [NotMapped]
    public virtual F_Task? Task { get; set; }

    [NotMapped]
    public virtual D_User? User { get; set; }

    public L_CaseTaskUser ShallowCopy()
    {
        return (L_CaseTaskUser)MemberwiseClone();
    }
}