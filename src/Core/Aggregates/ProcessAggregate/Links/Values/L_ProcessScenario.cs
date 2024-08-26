using Cheetah.Core.Aggregates.ProcessAggregate.Dimentions;
using Cheetah.Core.Aggregates.ProcessAggregate.Facts;

namespace Cheetah.Core.Aggregates.ProcessAggregate.Links;

public partial class L_ProcessScenario
{
    #region Values

    public static readonly L_ProcessScenario SampleProcess_SampleScenario =
        (L_ProcessScenario)new L_ProcessScenario()
        .SetFirstId(D_Process.SampleProcess.Id)
        .SetSecondId(F_Scenario.SampleScenario.Id)
        .SetId(1)
        .SetERPCode(-1)
        .SetSortIndex(1)
        .SetName(nameof(SampleProcess_SampleScenario))
        .SetDisplayName("فرآیند نمونه-سناریو نمونه");

    #endregion
}