namespace Cheetah.Domain.Entities.Facts;
public partial class F_Task : BaseEntity
{
    #region Entity

    public long? RoleId { get; set; }
    public virtual D_Role? Role { get; set; }

    public long? ScenarioId { get; set; }
    public virtual F_Scenario? Scenario { get; set; }

    #region For Variables
    public virtual long? ConditionId { get; set; }
    public virtual F_Condition? Condition { get; set; }
    #endregion

    #endregion

    #region Collections

    [InverseProperty(nameof(L_TaskAction.Task))]
    public virtual ICollection<L_TaskAction>? TaskActions { get; set; } = new HashSet<L_TaskAction>();
    #endregion

    public override void SetName()
    {
        //DisplayName = Scenario?.DisplayName + "," + SortIndex + "," + Role?.DisplayName;
        //Name = Scenario?.Name + "," + SortIndex + "," + Role?.Name;
    }

    #region Functions
    public F_Task ShallowCopy()
    {
        return (F_Task)MemberwiseClone();
    }
    #region Getter
    public bool IsRequestor()
    {
        return RoleId == D_Role.Requestor.Id;
    }
    public bool IsRequestorManager()
    {
        return RoleId == D_Role.RequestorManager.Id;
    }
    #endregion

    #endregion
}