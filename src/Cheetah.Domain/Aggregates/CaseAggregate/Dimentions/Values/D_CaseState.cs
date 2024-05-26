using System.Xml.Linq;

namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_CaseState
{
    #region Values

    public static D_CaseState Initializing = new(id: 1, name: nameof(Initializing),
        displayName: "مقداردهی اولیه", sortIndex: 1, eRPCode: 1);

    public static D_CaseState Ongoing = new(id: 2, name: nameof(Ongoing),
        displayName: "در دست بررسی", sortIndex: 2, eRPCode: 2);

    public static readonly D_CaseState Editing = new(id: 3, name: nameof(Editing),
        displayName: "منتظر بازنگری", sortIndex: 3, eRPCode: 3);

    public static readonly D_CaseState Approved = new(id: 4, name: nameof(Approved),
        displayName: "تایید شده", sortIndex: 4, eRPCode: 4);

    public static readonly D_CaseState Rejected = new(id: 5, name: nameof(Rejected),
        displayName: "عدم تایید", sortIndex: 5, eRPCode: 5);

    public static readonly D_CaseState Aborted = new(id: 6, name: nameof(Aborted),
        displayName: "ابطال شده", sortIndex: 6, eRPCode: 6);
    #endregion
}