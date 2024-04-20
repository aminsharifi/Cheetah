namespace Cheetah.Domain.Entities.Facts;

public partial class F_Scenario
{
    #region Values

    public  static F_Scenario SampleScenario =
         new ()
         {
             Id = 1,
             ERPCode = 1,
             SortIndex = 1,
             Name = nameof(SampleScenario),
             DisplayName = "سناریو نمونه"
         };
    #endregion
}