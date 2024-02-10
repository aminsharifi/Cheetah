namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_CaseState : BaseEntity
{
    #region Values

    public static D_CaseState Initializing = new()
    {
        Id = 1,
        ERPCode = 1,
        SortIndex = 1,
        Name = nameof(Initializing),
        DisplayName = "مقدار دهی اولیه"
    };

    public static D_CaseState Ongoing = new()
    {
        Id = 2,
        ERPCode = 2,
        SortIndex = 2,
        Name = nameof(Ongoing),
        DisplayName = "در دست بررسی"
    };

    public static readonly D_CaseState Editing = new()
    {
        Id = 3,
        ERPCode = 3,
        SortIndex = 3,
        Name = nameof(Editing),
        DisplayName = "منتظر بازنگری"
    };
    public static readonly D_CaseState Completed = new()
    {
        Id = 4,
        ERPCode = 4,
        SortIndex = 4,
        Name = nameof(Completed),
        DisplayName = "کامل شده"
    };
    public static readonly D_CaseState Rejected = new()
    {
        Id = 5,
        ERPCode = 5,
        SortIndex = 5,
        Name = nameof(Rejected),
        DisplayName = "عدم تایید"
    };
    public static readonly D_CaseState Aborted = new()
    {
        Id = 6,
        ERPCode = 6,
        SortIndex = 6,
        Name = nameof(Aborted),
        DisplayName = "ابطال شده"
    };
    #endregion
}