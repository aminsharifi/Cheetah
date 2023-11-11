namespace Cheetah.Domain.Links;

[Index(nameof(FirstId), IsUnique = false, AllDescending = true)]
[Index(nameof(SecondId), IsUnique = false, AllDescending = true)]
public partial class L_EndorsementItemEndorsement : SimpleLinkClass
{
    [Column(Order = 100)]
    [ForeignKey(nameof(FirstId))]
    public virtual F_EndorsementItem? EndorsementItem { get; set; }

    [Column(Order = 101)]
    [ForeignKey(nameof(SecondId))]
    public virtual F_Endorsement? Endorsement { get; set; }

    public L_EndorsementItemEndorsement ShallowCopy()
    {
        return (L_EndorsementItemEndorsement)this.MemberwiseClone();
    }
}