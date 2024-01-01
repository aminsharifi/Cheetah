namespace Cheetah.Domain.Entities.Dimentions;
public partial class D_Location : SimpleClass
{
    #region Simple Prop

    #endregion

    #region Relations

    #region Entity

    public long? EndorsementItemId { get; set; }
    public virtual F_EndorsementItem? EndorsementItem { get; set; }

    #endregion

    #region Collections

    #endregion

    #endregion
}