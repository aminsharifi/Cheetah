namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_TagType  
{
    #region Values

    public static readonly Dimentions.D_TagType Numberic =
        new Dimentions.D_TagType
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = nameof(Numberic),
            DisplayName = "عددی"
        };

    public static readonly Dimentions.D_TagType Boolean =
        new Dimentions.D_TagType
        {
            Id = 2,
            ERPCode = 2,
            SortIndex = 2,
            Name = nameof(Boolean),
            DisplayName = "دودویی"
        };

    public static readonly Dimentions.D_TagType Date =
        new Dimentions.D_TagType
        {
            Id = 3,
            ERPCode = 3,
            SortIndex = 3,
            Name = nameof(Date),
            DisplayName = "تاریخ"
        };

    public static readonly Dimentions.D_TagType String =
        new Dimentions.D_TagType
        {
            Id = 4,
            ERPCode = 4,
            SortIndex = 4,
            Name = nameof(String),
            DisplayName = "حروف"
        };
    #endregion
}