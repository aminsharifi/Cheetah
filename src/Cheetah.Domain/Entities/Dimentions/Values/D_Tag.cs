namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Tag
{
    #region Values

    public static readonly Dimentions.D_Tag D_Location =
        new Dimentions.D_Tag
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = nameof(D_Location),
            DisplayName = "مرکز",
            Description = "عددی",
            TagTypeId = 1
        };

    public static readonly Dimentions.D_Tag Approve =
        new Dimentions.D_Tag
        {
            Id = 201,
            ERPCode = 201,
            SortIndex = 201,
            Name = nameof(Approve),
            DisplayName = "تایید",
            Description = "پارامتریک",
            TagTypeId = 2
        };

    public static readonly Dimentions.D_Tag Reject =
        new Dimentions.D_Tag
        {
            Id = 202,
            ERPCode = 202,
            SortIndex = 202,
            Name = nameof(Reject),
            DisplayName = "عدم تایید",
            Description = "پارامتریک",
            TagTypeId = 2
        };

    public static readonly Dimentions.D_Tag Revise =
        new Dimentions.D_Tag
        {
            Id = 203,
            ERPCode = 203,
            SortIndex = 203,
            Name = nameof(Revise),
            DisplayName = "بازنگری",
            Description = "پارامتریک",
            TagTypeId = 2
        };

    public static readonly Dimentions.D_Tag Price =
        new Dimentions.D_Tag
        {
            Id = 301,
            ERPCode = 301,
            SortIndex = 301,
            Name = nameof(Price),
            DisplayName = "مبلغ",
            Description = "عددی",
            TagTypeId = 1
        };

    #endregion
}