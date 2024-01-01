namespace Cheetah.Domain.Entities.Dimentions;
public partial class D_User
{
    #region Values

    public static readonly Dimentions.D_User m_sharifi =
        new Dimentions.D_User
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = nameof(m_sharifi).Replace('_', '.'),
            DisplayName = "محمد شریفی"
        };

    public static readonly Dimentions.D_User a_sharifi =
        new Dimentions.D_User
        {
            Id = 2,
            ERPCode = 2,
            SortIndex = 2,
            Name = nameof(a_sharifi).Replace('_', '.'),
            DisplayName = "امین شریفی"
        };

    #endregion
}