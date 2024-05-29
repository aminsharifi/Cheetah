namespace Cheetah.Domain.Entities.Facts;
public partial class F_Task : BaseEntity
{
    public F_Task()
    {
        
    }
    public F_Task(Int64 id, String name, String displayName, Int64 sortIndex, Int64 eRPCode) :
        base(id, name, displayName, sortIndex, eRPCode)
    {

    }
    public F_Task(Int64 id, String name, String displayName,
        Int64 sortIndex, Int64 eRPCode,
        long scenarioId) :
       base(id, name, displayName, sortIndex, eRPCode)
    {
        ScenarioId = scenarioId;
    }

    #region Entity

    public long? ScenarioId { get; private set; }
    public virtual F_Scenario? Scenario { get; private set; }   

    #endregion

    #region Collections
    public virtual ICollection<L_TaskFlow>? TaskFlows { get; private set; } = new HashSet<L_TaskFlow>();
    public virtual ICollection<L_TaskCondition>? TaskConditions { get; private set; } = new HashSet<L_TaskCondition>();
    public virtual ICollection<L_FlowTask>? FlowTasks { get; private set; } = new HashSet<L_FlowTask>();
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