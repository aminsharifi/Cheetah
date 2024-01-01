namespace Cheetah.Domain.Entities.Facts;

public partial class F_EndorsementItem
{
    #region Values

    public static readonly F_EndorsementItem one =
        new F_EndorsementItem
        {
            Id = 1,
            Name = nameof(one),
            ERPCode = 1,
            SortIndex = 1,
            CaseStateId = 1,
            EndorsementId = 1
        };

    public static readonly F_EndorsementItem two =
        new F_EndorsementItem
        {
            Id = 2,
            Name = nameof(two),
            ERPCode = 2,
            SortIndex = 1,
            CaseStateId = 3,
            EndorsementId = 2
        };

    public static readonly F_EndorsementItem Three =
        new F_EndorsementItem
        {
            Id = 3,
            Name = nameof(Three),
            ERPCode = 3,
            SortIndex = 2,
            CaseStateId = 2,
            EndorsementId = 2
        };

    public static readonly F_EndorsementItem Four =
        new F_EndorsementItem
        {
            Id = 4,
            Name = nameof(Four),
            ERPCode = 4,
            SortIndex = 3,
            CaseStateId = 4,
            EndorsementId = 2
        };

    #endregion

}