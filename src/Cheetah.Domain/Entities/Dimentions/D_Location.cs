namespace Cheetah.Domain.Entities.Dimentions;
public partial class D_Location : BaseEntity
{
    #region Simple Prop

    #endregion

    #region Relations

    #region Entity

    public long? TaskItemId { get; set; }
    public virtual F_TaskItem? TaskItem { get; set; }

    #endregion

    #region Collections

    #endregion

    #endregion
}