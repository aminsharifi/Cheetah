namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_TagCategory
{
    #region Values

    public static readonly D_TagCategory Performer =
        new()
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = nameof(Performer),
            DisplayName = "Performer"
        };

    public static readonly D_TagCategory Action =
        new()
        {
            Id = 2,
            ERPCode = 2,
            SortIndex = 2,
            Name = nameof(Action),
            DisplayName = "Action"
        };

   #endregion
}