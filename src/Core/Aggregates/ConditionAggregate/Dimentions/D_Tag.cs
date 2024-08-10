using Cheetah.Core.Common;

namespace Cheetah.Core.Entities.Dimentions;

public partial class D_Tag : BaseEntity
{
    public D_Tag()
    {

    }

    public D_Tag SetTagTypeId(long? tagTypeId)
    {
        this.TagTypeId = tagTypeId;
        return this;
    }
    public D_Tag SetTagCategoryId(long? tagCategoryId)
    {
        this.TagCategoryId = tagCategoryId;
        return this;
    }
    public D_Tag SetTagType(D_TagType? tagType)
    {
        this.TagType = tagType;
        return this;
    }
    public D_Tag SetTagCategory(D_TagCategory? tagCategory)
    {
        this.TagCategory = tagCategory;
        return this;
    }
    #region Relation

    #region Entity
    public long? TagTypeId { get; private set; }
    public virtual D_TagType? TagType { get; private set; }

    public long? TagCategoryId { get; private set; }
    public virtual D_TagCategory? TagCategory { get; private set; }

    #endregion

    #region Collection

    #endregion

    #endregion
}