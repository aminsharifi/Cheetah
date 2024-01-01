namespace Cheetah.Domain.Entities.Facts;

public partial class F_EndorsementItem : SimpleClass
{
    #region Entities

    public long? CaseStateId { get; set; }
    public virtual D_CaseState? CaseState { get; set; }

    public long? EndorsementId { get; set; }
    [ForeignKey(nameof(EndorsementId))]
    public virtual F_Endorsement? Endorsement { get; set; }

    #endregion


    #region Collection

    [InverseProperty(nameof(F_Condition.EndorsementItem))]
    public virtual ICollection<F_Condition>? Conditions { get; set; } = new HashSet<F_Condition>();

    [InverseProperty(nameof(L_EndorsementItemEndorsement.EndorsementItem))]
    public virtual ICollection<L_EndorsementItemEndorsement>? Endorsements { get; set; } = new HashSet<L_EndorsementItemEndorsement>();

    #endregion


    #region Functions
    public F_EndorsementItem ShallowCopy()
    {
        return (F_EndorsementItem)MemberwiseClone();
    }

    #endregion

}