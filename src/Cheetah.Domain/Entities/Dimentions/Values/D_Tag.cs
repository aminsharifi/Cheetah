namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Tag
{
    #region Values  

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

    public static readonly D_Tag ReviewState =
    new()
    {
        Id = 12,
        ERPCode = 12,
        SortIndex = 12,
        Name = nameof(ReviewState),
        DisplayName = "وضعیت بررسی",
        Description = D_TagType.String.DisplayName,
        TagTypeId = D_TagType.String.Id
    };

    #endregion
}