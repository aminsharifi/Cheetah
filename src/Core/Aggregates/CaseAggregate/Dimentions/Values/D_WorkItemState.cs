namespace Cheetah.Core.Aggregates.CaseAggregate.Dimentions;
public partial class D_WorkItemState
{
    #region Values

    public static readonly D_WorkItemState Inbox =
        (D_WorkItemState)new D_WorkItemState()
        .SetId(1)
        .SetSortIndex(1)
        .SetERPCode(-1)
        .SetName(nameof(Inbox))
        .SetDisplayName("صندوق ورودی");

    public static readonly D_WorkItemState Sent =
        (D_WorkItemState)new D_WorkItemState()
        .SetId(2)
        .SetSortIndex(2)
        .SetERPCode(-2)
        .SetName(nameof(Sent))
        .SetDisplayName("ارسال شده");

    public static readonly D_WorkItemState Exit =
        (D_WorkItemState)new D_WorkItemState()
        .SetId(3)
        .SetSortIndex(3)
        .SetERPCode(-3)
        .SetName(nameof(Exit))
        .SetDisplayName("خروج");

    public static readonly D_WorkItemState Future =
        (D_WorkItemState)new D_WorkItemState()
        .SetId(4)
        .SetSortIndex(4)
        .SetERPCode(-4)
        .SetName(nameof(Future))
        .SetDisplayName("آینده");

    #endregion
}