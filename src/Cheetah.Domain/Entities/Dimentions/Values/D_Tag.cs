namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Tag
{
    #region Values
    public static readonly D_Tag Approve =
        new()
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = nameof(Approve),
            DisplayName = "تایید",
            Description = D_TagType.Boolean.DisplayName,
            TagTypeId = D_TagType.Boolean.Id
        };

    public static readonly D_Tag Reject =
        new()
        {
            Id = 2,
            ERPCode = 2,
            SortIndex = 2,
            Name = nameof(Reject),
            DisplayName = "عدم تایید",
            Description = D_TagType.Boolean.DisplayName,
            TagTypeId = D_TagType.Boolean.Id
        };

    public static readonly D_Tag Revise =
        new()
        {
            Id = 3,
            ERPCode = 3,
            SortIndex = 3,
            Name = nameof(Revise),
            DisplayName = "بازنگری",
            Description = D_TagType.Boolean.DisplayName,
            TagTypeId = D_TagType.Boolean.Id
        };

    public static readonly D_Tag Location =
        new()
        {
            Id = 4,
            ERPCode = 4,
            SortIndex = 4,
            Name = nameof(Location),
            DisplayName = "موقعیت",
            Description = D_TagType.String.DisplayName,
            TagTypeId = D_TagType.String.Id
        };

    public static readonly D_Tag Role =
        new()
        {
            Id = 5,
            ERPCode = 5,
            SortIndex = 5,
            Name = nameof(Role),
            DisplayName = "نقش",
            Description = D_TagType.String.DisplayName,
            TagTypeId = D_TagType.String.Id
        };

    public static readonly D_Tag Position =
        new()
        {
            Id = 6,
            ERPCode = 6,
            SortIndex = 6,
            Name = nameof(Position),
            DisplayName = "سمت",
            Description = D_TagType.String.DisplayName,
            TagTypeId = D_TagType.String.Id
        };

    public static readonly D_Tag Employees =
        new()
        {
            Id = 7,
            ERPCode = 7,
            SortIndex = 7,
            Name = nameof(Employees),
            DisplayName = "مدیر این پرسنل",
            Description = D_TagType.String.DisplayName,
            TagTypeId = D_TagType.String.Id
        };

    public static readonly D_Tag Price =
        new()
        {
            Id = 8,
            ERPCode = 8,
            SortIndex = 8,
            Name = nameof(Price),
            DisplayName = "مبلغ",
            Description = D_TagType.Numberic.DisplayName,
            TagTypeId = D_TagType.Numberic.Id
        };

    #endregion
}