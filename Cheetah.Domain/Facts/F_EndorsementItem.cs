namespace Cheetah.Domain.Facts;

public partial class F_EndorsementItem : SimpleClass
{
    [Column(Order = 102)]
    public long? CaseStateId { get; set; }
    public virtual D_CaseState? CaseState { get; set; }

    [Column(Order = 103)]
    public long? EndorsementId { get; set; }
    [ForeignKey(nameof(EndorsementId))]
    public virtual F_Endorsement? Endorsement { get; set; }

    [InverseProperty(nameof(F_Condition.EndorsementItem))]
    public virtual ICollection<F_Condition>? Conditions { get; set; } = new HashSet<F_Condition>();

    [InverseProperty(nameof(L_EndorsementItemEndorsement.EndorsementItem))]
    public virtual ICollection<L_EndorsementItemEndorsement>? Endorsements { get; set; } = new HashSet<L_EndorsementItemEndorsement>();

    #region Functions
    public F_EndorsementItem ShallowCopy()
    {
        return (F_EndorsementItem)this.MemberwiseClone();
    }

    #endregion

}