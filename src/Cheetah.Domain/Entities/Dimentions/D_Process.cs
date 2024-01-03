using System.Reflection;

namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Process : BaseEntity
{
    #region Simple Prob

    #region Others
    public bool? ShowSupport { get; set; } = true;
    public bool? ERP { get; set; } = true;
    public bool? RemoveRequestorApproval { get; set; } = true;

    #endregion

    #endregion

    #region Relations
    public virtual ICollection<L_ProcessScenario>? ProcessScenario { get; set; } = new HashSet<L_ProcessScenario>();
    #endregion
}