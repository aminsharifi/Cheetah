namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Tag
{
    #region Values  

    public static readonly D_Tag Location =
        (D_Tag)new D_Tag()
        .SetTagTypeId(D_TagType.String.Id)
        .SetTagCategoryId(D_TagCategory.Performer.Id)
        .SetId(4)
        .SetSortIndex(4)
        .SetERPCode(4)
        .SetName(nameof(Location))
        .SetDisplayName("موقعیت")
        .SetDescription(D_TagType.String.DisplayName!)
        .SetEnableRecord(true);

    public static readonly D_Tag Role =
        (D_Tag)new D_Tag()
        .SetTagTypeId(D_TagType.String.Id)
        .SetTagCategoryId(D_TagCategory.Performer.Id)
        .SetId(5)
        .SetSortIndex(5)
        .SetERPCode(5)
        .SetName(nameof(Role))
        .SetDisplayName("نقش")
        .SetDescription(D_TagType.String.DisplayName!)
        .SetEnableRecord(true);



    public static readonly D_Tag Position =
        (D_Tag)new D_Tag()
        .SetTagTypeId(D_TagType.String.Id)
        .SetTagCategoryId(D_TagCategory.Performer.Id)
        .SetId(6)
        .SetSortIndex(6)
        .SetERPCode(6)
        .SetName(nameof(Position))
        .SetDisplayName("سمت")
        .SetDescription(D_TagType.String.DisplayName!)
        .SetEnableRecord(true);

    public static readonly D_Tag Employees =
        (D_Tag)new D_Tag()
        .SetTagTypeId(D_TagType.String.Id)
        .SetTagCategoryId(D_TagCategory.Performer.Id)
        .SetId(7)
        .SetSortIndex(7)
        .SetERPCode(7)
        .SetName(nameof(Employees))
        .SetDisplayName("مدیر این پرسنل")
        .SetDescription(D_TagType.String.DisplayName!)
        .SetEnableRecord(true);

    public static readonly D_Tag Price =
        (D_Tag)new D_Tag()
        .SetTagTypeId(D_TagType.Numberic.Id)
        .SetTagCategoryId(D_TagCategory.Action.Id)
        .SetId(8)
        .SetSortIndex(8)
        .SetERPCode(8)
        .SetName(nameof(Price))
        .SetDisplayName("مبلغ")
        .SetDescription(D_TagType.Numberic.DisplayName!)
        .SetEnableRecord(true);



    public static readonly D_Tag ReviewState =
     (D_Tag)new D_Tag()
     .SetTagTypeId(D_TagType.String.Id)
     .SetTagCategoryId(D_TagCategory.Action.Id)
     .SetId(12)
     .SetSortIndex(12)
     .SetERPCode(12)
     .SetName(nameof(ReviewState))
     .SetDisplayName("وضعیت بررسی")
     .SetDescription(D_TagType.String.DisplayName!)
     .SetEnableRecord(true);


    public static readonly D_Tag Skill =
        (D_Tag)new D_Tag()
        .SetTagTypeId(D_TagType.String.Id)
        .SetTagCategoryId(D_TagCategory.Performer.Id)
        .SetId(13)
        .SetSortIndex(13)
        .SetERPCode(13)
        .SetName(nameof(Skill))
        .SetDisplayName("حرفه")
        .SetDescription(D_TagType.String.DisplayName!)
        .SetEnableRecord(true);

    #endregion
}