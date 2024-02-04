namespace Cheetah.Domain.Entities.Links;

public partial class L_TaskItemTask
{
    #region Values

    public static readonly L_TaskItemTask One =
        new L_TaskItemTask
        {
            Id = 1,
            Name = nameof(One),
            ERPCode = 1,
            SortIndex = 1,
            FirstId = 1,
            SecondId = 2
        };

    public static readonly L_TaskItemTask Two =
        new L_TaskItemTask
        {
            Id = 2,
            Name = nameof(Two),
            ERPCode = 2,
            SortIndex = 2,
            FirstId = 3,
            SecondId = 1
        };

    #endregion
}