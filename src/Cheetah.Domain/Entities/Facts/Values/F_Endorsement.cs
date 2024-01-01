namespace Cheetah.Domain.Entities.Facts;
public partial class F_Endorsement
{
    #region Values

    public static readonly F_Endorsement Sample_Scenario__Requestor =
        new F_Endorsement
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = nameof(Sample_Scenario__Requestor),
            DisplayName = "ثبت درخواست",
            RoleId = 100,
            ScenarioId = 1
        };
    public static readonly F_Endorsement Sample_Scenario__RequestorManager =
            new F_Endorsement
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