namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_TagCategory
{
    #region Values

    public static readonly D_TagCategory Performer = 
        (D_TagCategory)new D_TagCategory()
        .SetId(1)
        .SetSortIndex(1)
        .SetERPCode(-1)
        .SetName(nameof(Performer))
        .SetDisplayName("Performer");

    public static readonly D_TagCategory Action =
        (D_TagCategory)new D_TagCategory()
        .SetId(2)
        .SetSortIndex(2)
        .SetERPCode(-2)
        .SetName(nameof(Action))
        .SetDisplayName("Action");

    #endregion
}