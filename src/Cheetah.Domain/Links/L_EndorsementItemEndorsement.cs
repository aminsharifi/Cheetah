namespace Cheetah.Domain.Links;

public partial class L_EndorsementItemEndorsement : SimpleLinkClass
{
    [ForeignKey(nameof(FirstId))]
    public virtual F_EndorsementItem? EndorsementItem { get; set; }

    [ForeignKey(nameof(SecondId))]
    public virtual F_Endorsement? Endorsement { get; set; }

    public L_EndorsementItemEndorsement ShallowCopy()
    {
        return (L_EndorsementItemEndorsement)this.MemberwiseClone();
    }
}