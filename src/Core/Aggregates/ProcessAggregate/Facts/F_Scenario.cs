using Cheetah.Core.Aggregates.ProcessAggregate.Links;
using Cheetah.Core.Common;

namespace Cheetah.Core.Aggregates.ProcessAggregate.Facts;

public partial class F_Scenario : BaseEntity
{
    public F_Scenario()
    {

    }
    #region Relations

    public virtual ICollection<F_Task>? Tasks { get; set; } = new HashSet<F_Task>();
    public virtual ICollection<L_ProcessScenario>? ProcessScenarios { get; set; } = new HashSet<L_ProcessScenario>();
    public virtual ICollection<L_ScenarioCondition>? ScenarioConditions { get; set; } = new HashSet<L_ScenarioCondition>();

    #endregion

    public F_Scenario ShallowCopy()
    {
        return (F_Scenario)MemberwiseClone();
    }

    public override void SetNaming()
    {
        foreach (var item in Tasks)
        {
            item.SetNaming();
        }
    }
}