namespace Cheetah.Domain.Dimentions;

public partial class D_Process : SimpleClass
{
    #region Simple Prob

    #region Others
    public Boolean? ShowSupport { get; set; } = true;
    public Boolean? ERP { get; set; } = true;
    public Boolean? RemoveRequestorApproval { get; set; } = true;

    #endregion

    #endregion

    #region Relations
    public virtual ICollection<L_ProcessScenario>? ProcessScenario { get; set; } = new HashSet<L_ProcessScenario>();
    #endregion
}