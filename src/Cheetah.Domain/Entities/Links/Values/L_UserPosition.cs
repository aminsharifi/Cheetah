namespace Cheetah.Domain.Entities.Links;

public partial class L_UserPosition
{
    #region Values

    public static readonly L_UserPosition Requestor_Expert =
        new()
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = nameof(Requestor_Expert),
            DisplayName = "محمد شریفی-کارشناس",
            FirstId = 1,
            SecondId = 1
        };

    public static readonly L_UserPosition RequestorManager_Expert =
        new()
        {
            Id = 2,
            ERPCode = 2,
            SortIndex = 2,
            Name = nameof(RequestorManager_Expert),
            DisplayName = "امین شریفی-کارشناس",
            FirstId = 2,
            SecondId = 1
        };
    #endregion
}