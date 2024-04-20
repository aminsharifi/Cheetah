namespace Cheetah.Domain.Entities.Facts;
public partial class F_Task
{
    #region Values

    public static readonly F_Task Sample_Scenario_Requestor =
        new()
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = nameof(Sample_Scenario_Requestor),
            DisplayName = "ثبت درخواست",
            ScenarioId = 1
        };
    public static readonly F_Task Sample_Scenario_RequestorManager =
            new()
            {
                Id = 2,
                ERPCode = 2,
                SortIndex = 2,
                Name = nameof(Sample_Scenario_RequestorManager),
                DisplayName = "بررسی درخواست",
                ScenarioId = 1
            };

    #endregion
}