namespace Cheetah.Domain.Entities.Dimentions;

public class D_Operand : SimpleClass
{
    #region Values

    public static readonly D_Operand Equals =
        new D_Operand
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = "=",
            DisplayName = "مساوی"
        };

    public static readonly D_Operand NotEquals =
        new D_Operand
        {
            Id = 2,
            ERPCode = 2,
            SortIndex = 2,
            Name = "!=",
            DisplayName = "مخالف"
        };

    public static readonly D_Operand Greater =
        new D_Operand
        {
            Id = 3,
            ERPCode = 3,
            SortIndex = 3,
            Name = ">",
            DisplayName = "بزگتر از"
        };

    public static readonly D_Operand EqualAndGreater =
        new D_Operand
        {
            Id = 4,
            ERPCode = 4,
            SortIndex = 4,
            Name = ">=",
            DisplayName = "بزرگتر و مساوی"
        };

    public static readonly D_Operand LessThan =
        new D_Operand
        {
            Id = 5,
            ERPCode = 5,
            SortIndex = 5,
            Name = "<",
            DisplayName = " کوچکتر از"
        };

    public static readonly D_Operand LessThanOrEqual =
        new D_Operand
        {
            Id = 6,
            ERPCode = 6,
            SortIndex = 6,
            Name = "<=",
            DisplayName = "کوچکتر و مساوی"
        };
    #endregion

}