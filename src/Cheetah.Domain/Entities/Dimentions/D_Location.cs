namespace Cheetah.Domain.Entities.Dimentions;
public class D_Location : SimpleClass
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

    #region Values

    public static readonly D_Location Fars =
        new D_Location
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = nameof(Fars),
            DisplayName = "ÝÇÑÓ"
        };
    #endregion
}