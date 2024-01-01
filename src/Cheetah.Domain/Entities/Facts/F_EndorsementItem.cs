namespace Cheetah.Domain.Entities.Facts;

public class F_EndorsementItem : SimpleClass
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

    #region Values

    public static readonly F_EndorsementItem one =
        new F_EndorsementItem
        {
            Id = 1,
            Name = nameof(one),
            ERPCode = 1,
            SortIndex = 1,
            CaseStateId = 1,
            EndorsementId = 1
        };

    public static readonly F_EndorsementItem two =
        new F_EndorsementItem
        {
            Id = 2,
            Name = nameof(two),
            ERPCode = 2,
            SortIndex = 1,
            CaseStateId = 3,
            EndorsementId = 2
        };

    public static readonly F_EndorsementItem Three =
        new F_EndorsementItem
        {
            Id = 3,
            Name = nameof(Three),
            ERPCode = 3,
            SortIndex = 2,
            CaseStateId = 2,
            EndorsementId = 2
        };

    public static readonly F_EndorsementItem Four =
        new F_EndorsementItem
        {
            Id = 4,
            Name = nameof(Four),
            ERPCode = 4,
            SortIndex = 3,
            CaseStateId = 4,
            EndorsementId = 2
        };

    #endregion

}