namespace Cheetah.Domain.Entities.Links;

public partial class L_ProcessScenario
{
    #region Values
    public static readonly L_ProcessScenario SampleProcess_SampleScenario =
         new(id: 1, name: nameof(SampleProcess_SampleScenario),
        displayName: "فرآیند نمونه-سناریو نمونه", sortIndex: 1, eRPCode: 1,
        firstId: D_Process.SampleProcess.Id, secondId: F_Scenario.SampleScenario.Id);
    #endregion
}