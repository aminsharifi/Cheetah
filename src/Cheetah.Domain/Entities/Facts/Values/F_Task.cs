namespace Cheetah.Domain.Entities.Facts;
public partial class F_Task
{
    #region Values

    public static readonly F_Task Sample_Scenario__Requestor =
        new ()
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = nameof(Sample_Scenario__Requestor),
            DisplayName = "ثبت درخواست",
            RoleId = 100,
            ScenarioId = 1
        };
    public static readonly F_Task Sample_Scenario__RequestorManager =
            new()
            {
                Id = 2,
                ERPCode = 2,
                SortIndex = 2,
                Name = nameof(Sample_Scenario__RequestorManager),
                DisplayName = "بررسی درخواست",
                RoleId = 101,
                ScenarioId = 1
            };

    #endregion
}