namespace Cheetah.Domain.Dimentions;

public partial class D_Process : SimpleClass
{
    #region Simple Prob

    #region Others
    [Description("نمایش جهت پشتیبانی")]
    [Column(Order = 100)]
    public Boolean? ShowSupport { get; set; } = true;

    [Description("فرآیند ERP")]
    [Column(Order = 101)]
    public Boolean? ERP { get; set; } = true;

    [Description("حذف تایید درخواست کننده")]
    [Column(Order = 102)]
    public Boolean? RemoveRequestorApproval { get; set; } = true;

    #endregion

    #endregion

    #region Relations
    public virtual ICollection<L_ProcessScenario>? ProcessScenario { get; set; } = new HashSet<L_ProcessScenario>();
    #endregion
}