namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Operand
{
    #region Values

    public static readonly D_Operand Equals =
        new()
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = "=",
            DisplayName = "مساوی"
        };

    public static readonly D_Operand NotEquals =
        new()
        {
            Id = 2,
            ERPCode = 2,
            SortIndex = 2,
            Name = "!=",
            DisplayName = "مخالف"
        };

    public static readonly D_Operand Greater =
        new()
        {
            Id = 3,
            ERPCode = 3,
            SortIndex = 3,
            Name = ">",
            DisplayName = "بزگتر از"
        };

    public static readonly D_Operand EqualAndGreater =
        new()
        {
            Id = 4,
            ERPCode = 4,
            SortIndex = 4,
            Name = ">=",
            DisplayName = "بزرگتر و مساوی"
        };

    public static readonly D_Operand LessThan =
        new()
        {
            Id = 5,
            ERPCode = 5,
            SortIndex = 5,
            Name = "<",
            DisplayName = " کوچکتر از"
        };

    public static readonly D_Operand LessThanOrEqual =
        new()
        {
            Id = 6,
            ERPCode = 6,
            SortIndex = 6,
            Name = "<=",
            DisplayName = "کوچکتر و مساوی"
        };
    #endregion
}