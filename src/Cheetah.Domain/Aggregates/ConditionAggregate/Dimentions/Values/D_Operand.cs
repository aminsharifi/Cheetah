namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Operand
{
    #region Values

    public static readonly D_Operand Equals =
        (D_Operand)new D_Operand()
        .SetId(1)
        .SetSortIndex(1)
        .SetERPCode(1)
        .SetName(nameof(Equals))
        .SetDisplayName("مساوی");

    public static readonly D_Operand NotEquals =
     (D_Operand)new D_Operand()
        .SetId(2)
        .SetSortIndex(2)
        .SetERPCode(2)
        .SetName(nameof(NotEquals))
        .SetDisplayName("مخالف");


    public static readonly D_Operand Greater =
        (D_Operand)new D_Operand()
        .SetId(3)
        .SetSortIndex(3)
        .SetERPCode(3)
        .SetName(nameof(Greater))
        .SetDisplayName("بزگتر از");

    public static readonly D_Operand EqualAndGreater =
        (D_Operand)new D_Operand()
        .SetId(4)
        .SetSortIndex(4)
        .SetERPCode(4)
        .SetName(nameof(EqualAndGreater))
        .SetDisplayName("بزرگتر و مساوی");

    public static readonly D_Operand LessThan =
      (D_Operand)new D_Operand()
      .SetId(5)
      .SetSortIndex(5)
      .SetERPCode(5)
      .SetName(nameof(LessThan))
      .SetDisplayName("کوچکتر از");

    public static readonly D_Operand LessThanOrEqual =
        (D_Operand)new D_Operand()
        .SetId(6)
        .SetSortIndex(6)
        .SetERPCode(6)
        .SetName(nameof(LessThanOrEqual))
        .SetDisplayName("کوچکتر و مساوی");

    #endregion
}