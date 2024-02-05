namespace Cheetah.Domain.Entities.Dimentions;
public partial class D_Position
{
    #region Values

    public static readonly D_Position Expert =
         new()
         {
             Id = 1,
             ERPCode = 1,
             SortIndex = 1,
             Name = nameof(Expert),
             DisplayName = "کارشناس"
         };

    #endregion
}