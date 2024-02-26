namespace Cheetah.Domain.Entities.Facts;
public partial class F_Task : BaseEntity
{
    #region Entity

    public long? ScenarioId { get; set; }
    public virtual F_Scenario? Scenario { get; set; }   

    #endregion

    #region Collections
    public virtual ICollection<L_TaskFlow>? L_TaskFlows { get; set; } = new HashSet<L_TaskFlow>();
    public virtual ICollection<L_TaskCondition>? L_TaskConditions { get; set; } = new HashSet<L_TaskCondition>();    
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

    #endregion
}