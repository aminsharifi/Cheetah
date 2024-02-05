﻿namespace Cheetah.Domain.Entities.Dimentions;
public partial class D_WorkItemState
{
    #region Values

    public static readonly D_WorkItemState Inbox =
        new()
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = nameof(Inbox),
            DisplayName = "صندوق ورودی"
        };

    public static readonly D_WorkItemState Sent =
        new()
        {
            Id = 2,
            ERPCode = 2,
            SortIndex = 2,
            Name = nameof(Sent),
            DisplayName = "ارسال شده"
        };

    public static readonly D_WorkItemState Exit =
        new()
        {
            Id = 3,
            ERPCode = 3,
            SortIndex = 3,
            Name = nameof(Exit),
            DisplayName = "خارج شده"
        };

    public static readonly D_WorkItemState Future =
        new()
        {
            Id = 4,
            ERPCode = 4,
            SortIndex = 4,
            Name = nameof(Future),
            DisplayName = "آینده"
        };

    #endregion
}