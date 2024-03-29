﻿namespace Cheetah.Domain.Entities.Links;

public partial class L_ProcessScenario
{
    #region Values
    public static readonly L_ProcessScenario SampleProcess_SampleScenario =
        new()
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = nameof(SampleProcess_SampleScenario),
            DisplayName = "فرآیند نمونه-سناریو نمونه",
            FirstId = D_Process.SampleProcess.Id,
            SecondId = F_Scenario.SampleScenario.Id
        };
    #endregion
}