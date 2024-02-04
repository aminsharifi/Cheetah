namespace Cheetah.Domain.Entities.Facts;

public partial class F_TaskItem
{
    #region Values

    public static readonly F_TaskItem one =
        new F_TaskItem
        {
            Id = 1,
            Name = nameof(one),
            ERPCode = 1,
            SortIndex = 1,
            CaseStateId = 1,
            ToTaskId = 1
        };

    public static readonly F_TaskItem two =
        new F_TaskItem
        {
            Id = 2,
            Name = nameof(two),
            ERPCode = 2,
            SortIndex = 1,
            CaseStateId = 3,
            ToTaskId = 2
        };

    public static readonly F_TaskItem Three =
        new F_TaskItem
        {
            Id = 3,
            Name = nameof(Three),
            ERPCode = 3,
            SortIndex = 2,
            CaseStateId = 2,
            ToTaskId = 2
        };

    public static readonly F_TaskItem Four =
        new F_TaskItem
        {
            Id = 4,
            Name = nameof(Four),
            ERPCode = 4,
            SortIndex = 3,
            CaseStateId = 4,
            ToTaskId = 2
        };

    #endregion

}