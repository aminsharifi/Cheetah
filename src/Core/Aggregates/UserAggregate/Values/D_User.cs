namespace Cheetah.Core.Entities.Dimentions;
public partial class D_User
{
    #region Values

    //public static readonly D_User m_sharifi =
    //     new(id: 1, name: nameof(m_sharifi).Replace('_', '.'),
    //         displayName: "محمد شریفی", sortIndex: 1, eRPCode: 1);


    public static readonly D_User m_sharifi =
     (D_User)new D_User()
        .SetId(1)
        .SetSortIndex(1)
        .SetERPCode(-1)
        .SetName(nameof(m_sharifi).Replace('_', '.'))
        .SetDisplayName("محمد شریفی");

    public static readonly D_User a_sharifi =
        (D_User)new D_User()
        .SetId(2)
        .SetSortIndex(2)
        .SetERPCode(-2)
        .SetName(nameof(a_sharifi).Replace('_', '.'))
        .SetDisplayName("امین شریفی");

    #endregion
}