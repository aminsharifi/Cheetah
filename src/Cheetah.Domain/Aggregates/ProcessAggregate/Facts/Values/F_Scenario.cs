namespace Cheetah.Domain.Entities.Facts;

public partial class F_Scenario
{
    #region Values

    public  static F_Scenario SampleScenario = new(id: 1, name: nameof(SampleScenario),
        displayName: "سناریو نمونه", sortIndex: 1, eRPCode: 1);
    #endregion
}