namespace Cheetah.Domain.Entities.Links;

public class L_EndorsementUser : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual F_Endorsement? Endorsement { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual D_User? User { get; set; }

    public L_EndorsementUser ShallowCopy()
    {
        return (L_EndorsementUser)MemberwiseClone();
    }
}