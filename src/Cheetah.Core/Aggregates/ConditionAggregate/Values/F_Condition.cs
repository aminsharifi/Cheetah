using Cheetah.Core.Entities.Dimentions;

namespace Cheetah.Core.Entities.Facts;
public partial class F_Condition
{
    #region Values

    public static readonly F_Condition Approve =
        (F_Condition)new F_Condition()
        .SetTagId(D_Tag.ReviewState.Id)
        .SetOperandId(D_Operand.Equals.Id)
        .SetValue(nameof(Approve))
        .SetId(20)
        .SetSortIndex(20)
        .SetERPCode(-20)
        .SetName("ReviewState = Approve")
        .SetDisplayName("وضعیت بررسی مساوی Approve است.");

    public static readonly F_Condition Reject =
      (F_Condition)new F_Condition()
      .SetTagId(D_Tag.ReviewState.Id)
      .SetOperandId(D_Operand.Equals.Id)
      .SetValue(nameof(Reject))
      .SetId(21)
      .SetSortIndex(21)
      .SetERPCode(-21)
      .SetName("ReviewState = Reject")
      .SetDisplayName("وضعیت بررسی مساوی Reject است.");

    public static readonly F_Condition Revise =
        (F_Condition)new F_Condition()
        .SetTagId(D_Tag.ReviewState.Id)
        .SetOperandId(D_Operand.Equals.Id)
        .SetValue(nameof(Revise))
        .SetId(22)
        .SetSortIndex(22)
        .SetERPCode(-22)
        .SetName("ReviewState = Revise")
        .SetDisplayName("وضعیت بررسی مساوی Revise است.");

    public static readonly F_Condition SendRequest =
      (F_Condition)new F_Condition()
      .SetTagId(D_Tag.ReviewState.Id)
      .SetOperandId(D_Operand.Equals.Id)
      .SetValue(nameof(SendRequest))
      .SetId(23)
      .SetSortIndex(23)
      .SetERPCode(-23)
      .SetName("ReviewState = SendRequest")
      .SetDisplayName("وضعیت بررسی مساوی SendRequest است.");

    #endregion
}
