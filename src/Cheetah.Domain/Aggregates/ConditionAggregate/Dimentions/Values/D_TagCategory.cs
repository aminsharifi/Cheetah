namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_TagCategory
{
    #region Values

    public static readonly D_TagCategory Performer = new(id: 1, name: nameof(Performer),
        displayName: "Performer", sortIndex: 1, eRPCode: 1);

    public static readonly D_TagCategory Action = new(id: 2, name: nameof(D_TagCategory.Action),
        displayName: "Action", sortIndex: 2, eRPCode: 2);

   #endregion
}