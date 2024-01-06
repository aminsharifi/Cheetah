namespace Cheetah.Domain.Entities.Links;

public partial class L_RolePosition
{
    #region Values

    public static readonly L_RolePosition Requestor_Expert =
        new L_RolePosition
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = nameof(Requestor_Expert),
            DisplayName = "درخواست کننده-کارشناس",
            FirstId = 100,
            SecondId = 1
        };

    public static readonly L_RolePosition RequestorManager_Expert =
        new L_RolePosition
        {
            Id = 2,
            ERPCode = 2,
            SortIndex = 2,
            Name = nameof(RequestorManager_Expert),
            DisplayName = "مدیر درخواست کننده-کارشناس",
            FirstId = 101,
            SecondId = 1
        };
    #endregion
}