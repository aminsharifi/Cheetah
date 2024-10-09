using Cheetah.Core.Common;

namespace Cheetah.Core.Aggregates.Common.Dimentions;

public partial class D_Color : BaseEntity
{
    public D_Color()
    {
    }

}
public partial class D_Color
{
    #region Values

    public static readonly D_Color Default =
        (D_Color)new D_Color()
        .SetId(101)
        .SetERPCode(101)
        .SetSortIndex(101)
        .SetName(nameof(Default))
        .SetDisplayName(nameof(Default));

    public static readonly D_Color Primary =
        (D_Color)new D_Color()
        .SetId(102)
        .SetERPCode(102)
        .SetSortIndex(102)
        .SetName(nameof(Primary))
        .SetDisplayName(nameof(Primary));

    public static readonly D_Color Secondary =
        (D_Color)new D_Color()
        .SetId(103)
        .SetERPCode(103)
        .SetSortIndex(103)
        .SetName(nameof(Secondary))
        .SetDisplayName(nameof(Secondary));

    public static readonly D_Color Tertiary =
        (D_Color)new D_Color()
        .SetId(104)
        .SetERPCode(104)
        .SetSortIndex(104)
        .SetName(nameof(Tertiary))
        .SetDisplayName(nameof(Tertiary));

    public static readonly D_Color Info =
        (D_Color)new D_Color()
        .SetId(105)
        .SetERPCode(105)
        .SetSortIndex(105)
        .SetName(nameof(Info))
        .SetDisplayName(nameof(Info));

    public static readonly D_Color Success =
        (D_Color)new D_Color()
        .SetId(106)
        .SetERPCode(106)
        .SetSortIndex(106)
        .SetName(nameof(Success))
        .SetDisplayName(nameof(Success));

    public static readonly D_Color Warning =
        (D_Color)new D_Color()
        .SetId(107)
        .SetERPCode(107)
        .SetSortIndex(107)
        .SetName(nameof(Warning))
        .SetDisplayName(nameof(Warning));

    public static readonly D_Color Error =
        (D_Color)new D_Color()
        .SetId(108)
        .SetERPCode(108)
        .SetSortIndex(108)
        .SetName(nameof(Error))
        .SetDisplayName(nameof(Error));

    public static readonly D_Color Dark =
        (D_Color)new D_Color()
        .SetId(109)
        .SetERPCode(109)
        .SetSortIndex(109)
        .SetName(nameof(Dark))
        .SetDisplayName(nameof(Dark));

    public static readonly D_Color Transparent =
        (D_Color)new D_Color()
        .SetId(110)
        .SetERPCode(110)
        .SetSortIndex(110)
        .SetName(nameof(Transparent))
        .SetDisplayName(nameof(Transparent));

    public static readonly D_Color Inherit =
      (D_Color)new D_Color()
        .SetId(111)
        .SetERPCode(111)
        .SetSortIndex(111)
        .SetName(nameof(Inherit))
        .SetDisplayName(nameof(Inherit));


    public static readonly D_Color Surface =
        (D_Color)new D_Color()
        .SetId(112)
        .SetERPCode(112)
        .SetSortIndex(112)
        .SetName(nameof(Surface))
        .SetDisplayName(nameof(Surface));
    #endregion
}