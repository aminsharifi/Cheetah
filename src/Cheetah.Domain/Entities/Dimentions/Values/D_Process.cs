namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Process
{
    #region Values
    public static readonly D_Process SampleProcess =
          new()
          {
              Id = 1,
              ERPCode = 1,
              SortIndex = 1,
              Name = nameof(SampleProcess),
              DisplayName = "فرآیند نمونه",
          };
    #endregion
}