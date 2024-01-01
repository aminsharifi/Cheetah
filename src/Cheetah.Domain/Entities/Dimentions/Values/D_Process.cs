namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Process
{
    #region Values
    public static readonly Dimentions.D_Process SampleProcess =
          new Dimentions.D_Process
          {
              Id = 1,
              ERPCode = 1,
              SortIndex = 1,
              Name = nameof(SampleProcess),
              DisplayName = "فرآیند نمونه",
          };
    #endregion
}