namespace Cheetah.Domain.Entities.Facts;

public partial class F_Scenario : BaseEntity
{

    #region Relations

    public virtual ICollection<F_Condition>? Conditions { get; set; } = new HashSet<F_Condition>();

    public virtual ICollection<F_Task>? Tasks { get; set; } = new HashSet<F_Task>();

    public virtual ICollection<L_ProcessScenario>? ProcessScenarios { get; set; } = new HashSet<L_ProcessScenario>();

    #endregion

    public F_Scenario ShallowCopy()
    {
        return (F_Scenario)MemberwiseClone();
    }

    public override void SetName()
    {
        foreach (var item in Conditions)
        {
            item.SetName();
        }
        foreach (var item in Tasks)
        {
            item.SetName();
        }
    }
}