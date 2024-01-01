namespace Cheetah.Domain.Entities.Dimentions;
public partial class D_Position
{
    #region Values

    public static readonly Dimentions.D_Position Expert =
         new Dimentions.D_Position
         {
             Id = 1,
             ERPCode = 1,
             SortIndex = 1,
             Name = nameof(Expert),
             DisplayName = "کارشناس"
         };

    #endregion
}