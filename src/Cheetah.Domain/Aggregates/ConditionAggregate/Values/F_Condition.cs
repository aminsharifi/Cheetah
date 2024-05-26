namespace Cheetah.Domain.Entities.Facts;
public partial class F_Condition
{
    #region Values
    public static readonly F_Condition Approve = new(id: 20, name: "ReviewState = Approve",
        displayName: "وضعیت بررسی مساوی Approve است.", sortIndex: 20, eRPCode: 20,
        tagId: D_Tag.ReviewState.Id, operandId: D_Operand.Equals.Id, value: nameof(Approve));

    public static readonly F_Condition Reject = new(id: 21, name: "ReviewState = Reject",
        displayName: "وضعیت بررسی مساوی Reject است.", sortIndex: 21, eRPCode: 21,
        tagId: D_Tag.ReviewState.Id, operandId: D_Operand.Equals.Id, value: nameof(Reject));

    public static readonly F_Condition Revise = new(id: 22, name: "ReviewState = Revise",
        displayName: "وضعیت بررسی مساوی Revise است.", sortIndex: 22, eRPCode: 22,
        tagId: D_Tag.ReviewState.Id, operandId: D_Operand.Equals.Id, value: nameof(Revise));

    public static readonly F_Condition SendRequest = new(id: 23, name: "ReviewState = SendRequest",
        displayName: "وضعیت بررسی مساوی SendRequest است.", sortIndex: 23, eRPCode: 23,
        tagId: D_Tag.ReviewState.Id, operandId: D_Operand.Equals.Id, value: nameof(SendRequest));
    #endregion
}
