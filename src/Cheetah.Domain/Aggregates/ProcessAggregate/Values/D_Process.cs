namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Process
{
    #region Values

    public static readonly D_Process SampleProcess =
        (D_Process)new D_Process()
        .SetId(1)
        .SetSortIndex(1)
        .SetERPCode(-1)
        .SetName(nameof(SampleProcess))
        .SetDisplayName("فرآیند نمونه");

    #endregion
}