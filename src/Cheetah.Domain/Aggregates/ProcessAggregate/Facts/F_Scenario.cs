namespace Cheetah.Domain.Entities.Facts;

public partial class F_Scenario : BaseEntity
{
    public F_Scenario(Int64 id, String name, String displayName, Int64 sortIndex, Int64 eRPCode) :
        base(id, name, displayName, sortIndex, eRPCode)
    {

    }

    #region Relations

    public virtual ICollection<F_Task>? Tasks { get; private set; } = new HashSet<F_Task>();
    public virtual ICollection<L_ProcessScenario>? ProcessScenarios { get; private set; } = new HashSet<L_ProcessScenario>();
    public virtual ICollection<L_ScenarioCondition>? ScenarioConditions { get; private set; } = new HashSet<L_ScenarioCondition>();

    #endregion

    public F_Scenario ShallowCopy()
    {
        return (F_Scenario)MemberwiseClone();
    }

    public override void SetName()
    {
        foreach (var item in Tasks)
        {
            item.SetName();
        }
    }
}