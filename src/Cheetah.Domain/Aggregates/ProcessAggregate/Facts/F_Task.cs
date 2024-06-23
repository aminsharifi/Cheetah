namespace Cheetah.Domain.Entities.Facts;
public partial class F_Task : BaseEntity
{
    public F_Task()
    {

    }
    public F_Task SetScenarioId(Int64? scenarioId)
    {
        this.ScenarioId = scenarioId;
        return this;
    }
    #region Entity

    public long? ScenarioId { get; private set; }
    public virtual F_Scenario? Scenario { get; private set; }
     
    #endregion

    #region Collections
    public virtual ICollection<L_TaskFlow>? TaskFlows { get; set; } = new HashSet<L_TaskFlow>();
    public virtual ICollection<L_TaskCondition>? TaskConditions { get; set; } = new HashSet<L_TaskCondition>();
    public virtual ICollection<L_FlowTask>? FlowTasks { get; set; } = new HashSet<L_FlowTask>();
    #endregion

    public override void SetNaming()
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