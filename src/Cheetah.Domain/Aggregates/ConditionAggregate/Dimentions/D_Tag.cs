namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Tag : BaseEntity
{
    public D_Tag()
    {

    }
    public D_Tag(String name, String displayName) : base(name, displayName)
    {

    }

    public D_Tag(Int64 id, String name, String displayName, Int64? sortIndex,
        Int64? eRPCode, string description) :
        base(id, name, displayName, sortIndex, eRPCode, description)
    {

    }
    public D_Tag(Int64 id, String name, String displayName, Int64? sortIndex,
      Int64? eRPCode, string description, Boolean enableRecord) :
      base(id: id, name: name, displayName: displayName, sortIndex: sortIndex,
          eRPCode: eRPCode, description: description, enableRecord: enableRecord)
    {

    }
    public D_Tag(Int64 id, String name, String displayName, Int64 sortIndex,
    Int64 eRPCode, string description, long tagTypeId, long tagCategoryId) :
    base(id, name, displayName, sortIndex, eRPCode, description)
    {
        TagTypeId = tagTypeId;
        TagCategoryId = tagCategoryId;
    }

    #region Relation

    #region Entity
    public long? TagTypeId { get; private set; }
    public virtual D_TagType? TagType { get; private set; }

    public void SetTagType(D_TagType? tagType)
    {
        this.TagType = tagType;
    }

    public long? TagCategoryId { get; private set; }
    public virtual D_TagCategory? TagCategory { get; private set; }

    #region PublicProperties
    [NotMapped]
    public long? PublicTagTypeId
    {
        get { return TagTypeId; }
        set { TagTypeId = value; }
    }
    [NotMapped]
    public long? PublicTagCategoryId
    {
        get { return TagCategoryId; }
        set { TagCategoryId = value; }
    }
    #endregion

    public void SetTagCategory(D_TagCategory? tagCategory)
    {
        this.TagCategory = tagCategory;
    }

    #endregion

    #region Collection
    #endregion

    #endregion
}