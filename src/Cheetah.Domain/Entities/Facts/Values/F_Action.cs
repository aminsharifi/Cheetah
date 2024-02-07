namespace Cheetah.Domain.Entities.Facts;

public partial class F_Action
{
    #region Values

    public static readonly F_Action one =
        new()
        {
            Id = 1,
            Name = nameof(one),
            ERPCode = 1,
            SortIndex = 1,
            CaseStateId = 1
        };

    public static readonly F_Action two =
        new()
        {
            Id = 2,
            Name = nameof(two),
            ERPCode = 2,
            SortIndex = 1,
            CaseStateId = 3
        };

    public static readonly F_Action Three =
        new()
        {
            Id = 3,
            Name = nameof(Three),
            ERPCode = 3,
            SortIndex = 2,
            CaseStateId = 2
        };

    public static readonly F_Action Four =
        new()
        {
            Id = 4,
            Name = nameof(Four),
            ERPCode = 4,
            SortIndex = 3,
            CaseStateId = 4
        };

    #endregion

}