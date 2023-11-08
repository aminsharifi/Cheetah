namespace Cheetah.Domain.Dimentions;
public partial class D_Location : SimpleClass
{
    #region Simple Prop

    #endregion

    #region Relations

    #region Entity
    
    public long? EndorsementItemId { get; set; }
    [ForeignKey(nameof(EndorsementItemId))]
    public virtual F_EndorsementItem? EndorsementItem { get; set; }

    #endregion

    #region Collections
    
    #endregion

    #endregion
}