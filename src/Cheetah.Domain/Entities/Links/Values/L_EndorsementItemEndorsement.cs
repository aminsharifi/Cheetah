namespace Cheetah.Domain.Entities.Links;

public partial class L_EndorsementItemEndorsement
{
    #region Values

    public static readonly L_EndorsementItemEndorsement One =
        new L_EndorsementItemEndorsement
        {
            Id = 1,
            Name = nameof(One),
            ERPCode = 1,
            SortIndex = 1,
            FirstId = 1,
            SecondId = 2
        };

    public static readonly L_EndorsementItemEndorsement Two =
        new L_EndorsementItemEndorsement
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