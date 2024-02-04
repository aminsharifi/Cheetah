namespace Cheetah.Domain.Entities.Facts;

public partial class F_TaskItem : BaseEntity
{
    #region Entities

    public long? CaseStateId { get; set; }
    public virtual D_CaseState? CaseState { get; set; }

    public long? ToTaskId { get; set; }
    [ForeignKey(nameof(ToTaskId))]
    public virtual F_Task? ToTask { get; set; }

    #endregion

    #region Collection

    [InverseProperty(nameof(F_Condition.TaskItem))]
    public virtual ICollection<F_Condition>? Conditions { get; set; } = new HashSet<F_Condition>();

    [InverseProperty(nameof(L_TaskItemTask.TaskItem))]
    public virtual ICollection<L_TaskItemTask>? TaskItemTasks { get; set; } = new HashSet<L_TaskItemTask>();

    #endregion

    #region Functions
    public F_TaskItem ShallowCopy()
    {
        return (F_TaskItem)MemberwiseClone();
    }

    #endregion
}