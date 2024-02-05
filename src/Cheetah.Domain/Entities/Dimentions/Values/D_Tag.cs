namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Tag
{
    #region Values

    public static readonly D_Tag D_Location =
        new()
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = nameof(D_Location),
            DisplayName = "مرکز",
            Description = "عددی",
            TagTypeId = 1
        };

    public static readonly D_Tag Approve =
        new()
        {
            Id = 201,
            ERPCode = 201,
            SortIndex = 2,
            Name = nameof(Approve),
            DisplayName = "تایید",
            Description = "دودویی",
            TagTypeId = 2
        };

    public static readonly D_Tag Reject =
        new()
        {
            Id = 202,
            ERPCode = 202,
            SortIndex = 3,
            Name = nameof(Reject),
            DisplayName = "عدم تایید",
            Description = "دودویی",
            TagTypeId = 2
        };

    public static readonly D_Tag Revise =
        new()
        {
            Id = 203,
            ERPCode = 203,
            SortIndex = 4,
            Name = nameof(Revise),
            DisplayName = "بازنگری",
            Description = "دودویی",
            TagTypeId = 2
        };

    public static readonly D_Tag Price =
        new()
        {
            Id = 301,
            ERPCode = 301,
            SortIndex = 5,
            Name = nameof(Price),
            DisplayName = "مبلغ",
            Description = "عددی",
            TagTypeId = 1
        };

    #endregion
}