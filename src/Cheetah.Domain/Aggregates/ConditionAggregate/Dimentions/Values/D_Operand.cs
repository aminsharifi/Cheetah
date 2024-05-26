namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Operand
{
    #region Values

    public static readonly D_Operand Equals = new(id: 1, name: nameof(Equals),
        displayName: "مساوی", sortIndex: 1, eRPCode: 1);

    public static readonly D_Operand NotEquals = new(id: 2, name: nameof(NotEquals),
        displayName: "مخالف", sortIndex: 2, eRPCode: 2);

    public static readonly D_Operand Greater = new(id: 3, name: nameof(Greater),
        displayName: "بزگتر از", sortIndex: 3, eRPCode: 3);

    public static readonly D_Operand EqualAndGreater = new(id: 4, name: nameof(EqualAndGreater),
        displayName: "بزرگتر و مساوی", sortIndex: 4, eRPCode: 4);

    public static readonly D_Operand LessThan = new(id: 5, name: nameof(LessThan),
        displayName: " کوچکتر از", sortIndex: 5, eRPCode: 5);

    public static readonly D_Operand LessThanOrEqual = new(id: 6, name: nameof(LessThanOrEqual),
        displayName: "کوچکتر و مساوی", sortIndex: 6, eRPCode: 6);

    #endregion
}