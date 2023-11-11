namespace Cheetah.Domain.Dimentions;

public partial class D_Tag : SimpleClass
{
    #region Relation

    #region Entity
    public long? TagTypeId { get; set; }
    [ForeignKey(nameof(TagTypeId))]
    public virtual D_TagType? TagType { get; set; }

    #endregion

    #region Collection
    #endregion

    #endregion
}