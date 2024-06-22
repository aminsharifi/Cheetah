namespace Cheetah.Domain.Entities.Facts;

public partial class F_Scenario
{
    #region Values

    public static F_Scenario SampleScenario = 
        (F_Scenario) new F_Scenario()
        .SetId(1)
        .SetERPCode(1)
        .SetSortIndex(1)
        .SetName(nameof(SampleScenario))
        .SetDisplayName("سناریو نمونه");

    #endregion
}