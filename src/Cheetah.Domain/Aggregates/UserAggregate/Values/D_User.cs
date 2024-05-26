namespace Cheetah.Domain.Entities.Dimentions;
public partial class D_User
{
    #region Values

    public static readonly D_User m_sharifi =
         new(id: 1, name: nameof(m_sharifi).Replace('_', '.'),
             displayName: "محمد شریفی", sortIndex: 1, eRPCode: 1);

    public static readonly D_User a_sharifi =
            new(id: 2, name: nameof(a_sharifi).Replace('_', '.'),
             displayName: "امین شریفی", sortIndex: 2, eRPCode: 2);

    #endregion
}