using Cheetah.Core.Aggregates.ConditionAggregate.Dimentions;

namespace Cheetah.Core.Aggregates.ConditionAggregate.Facts;
public partial class F_Condition
{
    #region Values

    public static readonly F_Condition Creator =
        (F_Condition)new F_Condition()
        .SetTagId(D_Tag.Employees.Id)
        .SetOperandId(D_Operand.Equals.Id)
        .SetValue(nameof(Creator))
        .SetId(-10)
        .SetSortIndex(-10)
        .SetERPCode(-10)
        .SetName(nameof(D_Tag.Employees) + " = " + nameof(Creator))
        .SetDisplayName("ایجاد کننده");  

    public static readonly F_Condition Manager =
        (F_Condition)new F_Condition()
        .SetTagId(D_Tag.Employees.Id)
        .SetOperandId(D_Operand.Equals.Id)
        .SetValue(nameof(Manager))
        .SetId(-11)
        .SetSortIndex(-11)
        .SetERPCode(-11)
        .SetName(nameof(D_Tag.Employees) + " = " + nameof(Manager))
        .SetDisplayName("مدیر ایجادکننده");

    public static readonly F_Condition Requestor =
      (F_Condition)new F_Condition()
      .SetTagId(D_Tag.Employees.Id)
      .SetOperandId(D_Operand.Equals.Id)
      .SetValue(nameof(Requestor))
      .SetId(-12)
      .SetSortIndex(-12)
      .SetERPCode(-12)
      .SetName(nameof(D_Tag.Employees) + " = " + nameof(Requestor))
      .SetDisplayName("درخواست کننده");

    public static readonly F_Condition Approve =
        (F_Condition)new F_Condition()
        .SetTagId(D_Tag.ReviewState.Id)
        .SetOperandId(D_Operand.Equals.Id)
        .SetValue(nameof(Approve))
        .SetId(-20)
        .SetSortIndex(-20)
        .SetERPCode(-20)
        .SetName("ReviewState = Approve")
        .SetDisplayName("تایید");

    public static readonly F_Condition Reject =
      (F_Condition)new F_Condition()
      .SetTagId(D_Tag.ReviewState.Id)
      .SetOperandId(D_Operand.Equals.Id)
      .SetValue(nameof(Reject))
      .SetId(-21)
      .SetSortIndex(-21)
      .SetERPCode(-21)
      .SetName("ReviewState = Reject")
      .SetDisplayName("عدم تایید");

    public static readonly F_Condition Revise =
        (F_Condition)new F_Condition()
        .SetTagId(D_Tag.ReviewState.Id)
        .SetOperandId(D_Operand.Equals.Id)
        .SetValue(nameof(Revise))
        .SetId(-22)
        .SetSortIndex(-22)
        .SetERPCode(-22)
        .SetName("ReviewState = Revise")
        .SetDisplayName("بازنگری");

    public static readonly F_Condition SendRequest =
      (F_Condition)new F_Condition()
      .SetTagId(D_Tag.ReviewState.Id)
      .SetOperandId(D_Operand.Equals.Id)
      .SetValue(nameof(SendRequest))
      .SetId(-23)
      .SetSortIndex(-23)
      .SetERPCode(-23)
      .SetName("ReviewState = SendRequest")
      .SetDisplayName("ارسال درخواست");

    #endregion
}
