namespace Cheetah.Domain.Entities.Facts;

public partial class F_Scenario : BaseEntity
{

    #region Relations

    public virtual ICollection<F_Task>? Tasks { get; set; } = new HashSet<F_Task>();
    public virtual ICollection<L_ProcessScenario>? ProcessScenarios { get; set; } = new HashSet<L_ProcessScenario>();
    public virtual ICollection<L_ScenarioCondition>? ScenarioConditions { get; set; } = new HashSet<L_ScenarioCondition>();

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