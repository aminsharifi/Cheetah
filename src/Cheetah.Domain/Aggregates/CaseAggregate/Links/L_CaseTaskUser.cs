namespace Cheetah.Domain.Entities.Links;

public partial class L_CaseTaskUser : SimpleLinkClass
{
    public L_CaseTaskUser(long? firstId, long? secondId, long? thirdId) :
        base(firstId: firstId, secondId: secondId, thirdId: thirdId)
    {

    }
    public L_CaseTaskUser(F_Case f_Case, F_Task f_Task, D_User d_User)
    {
        Case = f_Case;
        Task = f_Task;
        User = d_User;
    }
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