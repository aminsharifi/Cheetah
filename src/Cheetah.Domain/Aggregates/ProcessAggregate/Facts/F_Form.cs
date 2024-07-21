using Cheetah.Domain.Common;

namespace Cheetah.Domain.Entities.Facts;

public partial class F_Form : BaseEntity
{
    public F_Form()
    {

    }

    #region Entities    


    #endregion

    #region Collection

    #endregion

    #region Functions

    public F_Form ShallowCopy()
    {
        return (F_Form)MemberwiseClone();
    }

    #endregion
}