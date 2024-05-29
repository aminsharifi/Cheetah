namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Tag
{
    #region Values  

    public static readonly D_Tag Location = new(id: 4, name: nameof(Location),
        displayName: "موقعیت", sortIndex: 4, eRPCode: 4,
        description: D_TagType.String.DisplayName!,tagTypeId: D_TagType.String.Id,
        tagCategoryId: D_TagCategory.Performer.Id
        ,enableRecord:true);

    public static readonly D_Tag Role = new(id: 5, name: nameof(Role),
        displayName: "نقش", sortIndex: 5, eRPCode: 5,
        description: D_TagType.String.DisplayName!, tagTypeId: D_TagType.String.Id,
        tagCategoryId: D_TagCategory.Performer.Id
        , enableRecord: true);

    public static readonly D_Tag Position = new(id: 6, name: nameof(Position),
        displayName: "سمت", sortIndex: 6, eRPCode: 6,
        description: D_TagType.String.DisplayName!, tagTypeId: D_TagType.String.Id,
        tagCategoryId: D_TagCategory.Performer.Id
        , enableRecord: true);

    public static readonly D_Tag Employees = new(id: 7, name: nameof(Employees),
        displayName: "مدیر این پرسنل", sortIndex: 7, eRPCode: 7,
        description: D_TagType.String.DisplayName!, tagTypeId: D_TagType.String.Id,
        tagCategoryId: D_TagCategory.Performer.Id
        , enableRecord: true);

    public static readonly D_Tag Price = new(id: 8, name: nameof(Price),
        displayName: "مبلغ", sortIndex: 8, eRPCode: 8,
        description: D_TagType.Numberic.DisplayName!, tagTypeId: D_TagType.Numberic.Id,
        tagCategoryId: D_TagCategory.Action.Id
        , enableRecord: true);

    public static readonly D_Tag ReviewState = new(id: 12, name: nameof(ReviewState),
        displayName: "وضعیت بررسی", sortIndex: 12, eRPCode: 12,
        description: D_TagType.String.DisplayName!, tagTypeId: D_TagType.String.Id,
        tagCategoryId: D_TagCategory.Action.Id
        , enableRecord: true);

    public static readonly D_Tag Skill = new(id: 13, name: nameof(Skill),
        displayName: "حرفه", sortIndex: 13, eRPCode: 13,
        description: D_TagType.String.DisplayName!, tagTypeId: D_TagType.String.Id,
        tagCategoryId: D_TagCategory.Performer.Id
        , enableRecord: true);
    #endregion
}