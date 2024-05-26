namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_TagType
{
    #region Values

    public static readonly D_TagType Numberic = new(id: 1, name: nameof(Numberic),
        displayName: "عددی", sortIndex: 1, eRPCode: 1);

    public static readonly D_TagType Boolean = new(id: 2, name: nameof(D_TagType.Boolean),
        displayName: "دودویی", sortIndex: 2, eRPCode: 2);

    public static readonly D_TagType Date = new(id: 3, name: nameof(D_TagType.Date),
        displayName: "تاریخ", sortIndex: 3, eRPCode: 3);

    public static readonly D_TagType String = new(id: 4, name: nameof(D_TagType.String),
        displayName: "حروف", sortIndex: 4, eRPCode: 4);
    #endregion
}