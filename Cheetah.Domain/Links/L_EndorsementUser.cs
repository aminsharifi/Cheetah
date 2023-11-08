namespace Cheetah.Domain.Links;

[Index(nameof(FirstId), IsUnique = false, AllDescending = true)]
[Index(nameof(SecondId), IsUnique = false, AllDescending = true)]
public partial class L_EndorsementUser : SimpleLinkClass
{
    [Column(Order = 100)]
    [ForeignKey(nameof(FirstId))]
    public virtual F_Endorsement? Endorsement { get; set; }

    [Column(Order = 101)]
    [ForeignKey(nameof(SecondId))]
    public virtual D_User? User { get; set; }

    public L_EndorsementUser ShallowCopy()
    {
        return (L_EndorsementUser)this.MemberwiseClone();
    }
}