namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Tag : BaseEntity
{
    public D_Tag()
    {

    }
    public D_Tag(String name, String displayName) : base(name, displayName)
    {

    }

    #region Relation

    #region Entity
    public long? TagTypeId { get; set; }
    public virtual D_TagType? TagType { get; set; }

    #endregion

    #region Collection
    #endregion

    #endregion
}