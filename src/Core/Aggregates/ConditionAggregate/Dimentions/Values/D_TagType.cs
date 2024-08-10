namespace Cheetah.Core.Entities.Dimentions;

public partial class D_TagType
{
    #region Values

    public static readonly D_TagType Numberic =
        (D_TagType)new D_TagType()
        .SetId(1)
        .SetSortIndex(1)
        .SetERPCode(-1)
        .SetName(nameof(Numberic))
        .SetDisplayName("عددی");

    public static readonly D_TagType Boolean =
        (D_TagType)new D_TagType()
        .SetId(2)
        .SetSortIndex(2)
        .SetERPCode(-2)
        .SetName(nameof(Boolean))
        .SetDisplayName("دودویی");

    public static readonly D_TagType Date =
        (D_TagType)new D_TagType()
        .SetId(3)
        .SetSortIndex(3)
        .SetERPCode(-3)
        .SetName(nameof(D_TagType.Date))
        .SetDisplayName("دودویی");


    public static readonly D_TagType String =
        (D_TagType)new D_TagType()
        .SetId(4)
        .SetSortIndex(4)
        .SetERPCode(-4)
        .SetName(nameof(D_TagType.String))
        .SetDisplayName("حروف");

    #endregion
}