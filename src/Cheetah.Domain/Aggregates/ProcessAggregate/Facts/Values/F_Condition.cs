namespace Cheetah.Domain.Entities.Facts;
public partial class F_Condition
{
    #region Values
    public static readonly F_Condition Approve =
        new()
        {
            Id = 20,
            ERPCode = 20,
            SortIndex = 20,
            Name = "ReviewState = Approve",
            DisplayName = "وضعیت بررسی مساوی Approve است.",
            TagId = D_Tag.ReviewState.Id,
            OperandId = D_Operand.Equals.Id,
            Value = nameof(Approve)
        };

    public static readonly F_Condition Reject =
        new()
        {
            Id = 21,
            ERPCode = 21,
            SortIndex = 21,
            Name = "ReviewState = Reject",
            DisplayName = "وضعیت بررسی مساوی Reject است.",
            TagId = D_Tag.ReviewState.Id,
            OperandId = D_Operand.Equals.Id,
            Value = nameof(Reject)

        };

    public static readonly F_Condition Revise =
        new()
        {
            Id = 22,
            ERPCode = 22,
            SortIndex = 22,
            Name = "ReviewState = Revise",
            DisplayName = "وضعیت بررسی مساوی Revise است.",
            TagId = D_Tag.ReviewState.Id,
            OperandId = D_Operand.Equals.Id,
            Value = nameof(Revise)
        };

    public static readonly F_Condition SendRequest =
        new()
        {
            Id = 23,
            ERPCode = 23,
            SortIndex = 23,
            Name = "ReviewState = SendRequest",
            DisplayName = "وضعیت بررسی مساوی SendRequest است.",
            TagId = D_Tag.ReviewState.Id,
            OperandId = D_Operand.Equals.Id,
            Value = nameof(SendRequest)
        };
    #endregion
}
