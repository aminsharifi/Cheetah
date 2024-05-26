namespace Cheetah.Domain.Entities.Dimentions;
public partial class D_WorkItemState
{
    #region Values

    public static readonly D_WorkItemState Inbox = new(id: 1, name: nameof(Inbox),
        displayName: "صندوق ورودی", sortIndex: 1, eRPCode: 1);

    public static readonly D_WorkItemState Sent = new(id: 2, name: nameof(Sent),
        displayName: "ارسال شده", sortIndex: 2, eRPCode: 2);

    public static readonly D_WorkItemState Exit = new(id: 3, name: nameof(Exit),
        displayName: "عدم تایید", sortIndex: 3, eRPCode: 3);

    public static readonly D_WorkItemState Future = new(id: 4, name: nameof(Future),
        displayName: "آینده", sortIndex: 4, eRPCode: 4);

    #endregion
}