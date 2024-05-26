namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Process
{
    #region Values
    public static readonly D_Process SampleProcess = new(id: 1, name: nameof(SampleProcess),
        displayName: "فرآیند نمونه", sortIndex: 1, eRPCode: 1);

    #endregion
}