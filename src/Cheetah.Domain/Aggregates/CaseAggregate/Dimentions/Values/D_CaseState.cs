namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_CaseState
{
    #region Values

    public static readonly D_CaseState Initializing =
        (D_CaseState)new D_CaseState()
        .SetId(1)
        .SetSortIndex(1)
        .SetERPCode(-1)
        .SetName(nameof(Initializing))
        .SetDisplayName("مقداردهی اولیه");

    public static readonly D_CaseState Ongoing =
        (D_CaseState)new D_CaseState()
        .SetId(2)
        .SetSortIndex(2)
        .SetERPCode(-2)
        .SetName(nameof(Ongoing))
        .SetDisplayName("در دست بررسی");

    public static readonly D_CaseState Editing =
        (D_CaseState)new D_CaseState()
        .SetId(3)
        .SetSortIndex(3)
        .SetERPCode(-3)
        .SetName(nameof(Editing))
        .SetDisplayName("منتظر بازنگری");

    public static readonly D_CaseState Approved =
        (D_CaseState)new D_CaseState()
        .SetId(4)
        .SetSortIndex(4)
        .SetERPCode(-4)
        .SetName(nameof(Approved))
        .SetDisplayName("تایید شده");

    public static readonly D_CaseState Rejected =
        (D_CaseState)new D_CaseState()
        .SetId(5)
        .SetSortIndex(5)
        .SetERPCode(-5)
        .SetName(nameof(Rejected))
        .SetDisplayName("عدم تایید");

    public static readonly D_CaseState Aborted =
        (D_CaseState)new D_CaseState()
        .SetId(6)
        .SetSortIndex(6)
        .SetERPCode(-6)
        .SetName(nameof(Aborted))
        .SetDisplayName("ابطال شده");

    #endregion
}