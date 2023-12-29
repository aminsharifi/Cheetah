namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Tag : SimpleClass
{
    #region Relation

    #region Entity
    public long? TagTypeId { get; set; }
    public virtual D_TagType? TagType { get; set; }

    #endregion

    #region Collection
    #endregion

    #endregion
}