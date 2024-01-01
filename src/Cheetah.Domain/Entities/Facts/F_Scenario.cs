namespace Cheetah.Domain.Entities.Facts;

public class F_Scenario : SimpleClass
{

    #region Relations

    public virtual ICollection<F_Condition>? Conditions { get; set; } = new HashSet<F_Condition>();

    public virtual ICollection<F_Endorsement>? Endorsements { get; set; } = new HashSet<F_Endorsement>();

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
        foreach (var item in Endorsements)
        {
            item.SetName();
        }
    }

    #region Values

    public static readonly F_Scenario SampleScenario =
         new F_Scenario
         {
             Id = 1,
             ERPCode = 1,
             SortIndex = 1,
             Name = nameof(SampleScenario),
             DisplayName = "سناریو نمونه"
         };
    #endregion
}