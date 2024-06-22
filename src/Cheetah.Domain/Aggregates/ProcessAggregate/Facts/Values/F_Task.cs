namespace Cheetah.Domain.Entities.Facts;
public partial class F_Task
{
    #region Values

    public static readonly F_Task Sample_Scenario_Requestor =
        ((F_Task)new F_Task()
        .SetId(1)
        .SetSortIndex(1)
        .SetERPCode(1)
        .SetName(nameof(Sample_Scenario_Requestor))
        .SetDisplayName("ثبت درخواست"))
        .SetScenarioId(1);

    public static readonly F_Task Sample_Scenario_RequestorManager =
     ((F_Task)new F_Task()
     .SetId(2)
     .SetSortIndex(2)
     .SetERPCode(2)
     .SetName(nameof(Sample_Scenario_RequestorManager))
     .SetDisplayName("بررسی درخواست"))
     .SetScenarioId(1);

    #endregion
}