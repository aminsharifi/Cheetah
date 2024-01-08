namespace Cheetah.Domain.Entities.Links;

public partial class L_CaseEndorsementUser : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual F_Case? Case { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual F_Endorsement? Endorsement { get; set; }

    [ForeignKey(nameof(ThirdId))]
    public virtual D_User? User { get; set; }

    public L_CaseEndorsementUser ShallowCopy()
    {
        return (L_CaseEndorsementUser)MemberwiseClone();
    }
}