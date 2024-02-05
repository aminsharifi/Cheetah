namespace Cheetah.Domain.Entities.Facts;

public partial class F_Action : BaseEntity
{
    #region Entities

    public long? CaseStateId { get; set; }
    public virtual D_CaseState? CaseState { get; set; }

    #endregion

    #region Collection

    [InverseProperty(nameof(F_Condition.Action))]
    public virtual ICollection<F_Condition>? Conditions { get; set; } = new HashSet<F_Condition>();

    [InverseProperty(nameof(L_TaskAction.Action))]
    public virtual ICollection<L_TaskAction>? TaskActions { get; set; } = new HashSet<L_TaskAction>();

    #endregion

    #region Functions
    public F_Action ShallowCopy()
    {
        return (F_Action)MemberwiseClone();
    }

    #endregion
}