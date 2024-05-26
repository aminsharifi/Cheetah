namespace Cheetah.Domain.Entities.Facts;
public partial class F_Task
{
    #region Values

    public static readonly F_Task Sample_Scenario_Requestor = new(id: 1, name: nameof(Sample_Scenario_Requestor),
        displayName: "ثبت درخواست", sortIndex: 1, eRPCode: 1, scenarioId:1);

    public static readonly F_Task Sample_Scenario_RequestorManager = new(id: 2, name: nameof(Sample_Scenario_RequestorManager),
        displayName: "بررسی درخواست", sortIndex: 2, eRPCode: 2, scenarioId: 1);

    #endregion
}