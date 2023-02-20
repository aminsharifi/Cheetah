namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("P_RequestTitle", Schema = "Parameters")]
    public partial class P_RequestTitle : BasePSClass
    {
        #region Simple Prob

        #region Others
        [Description("نمایش جهت پشتیبانی")]
        [Column(Order = 100)]
        public bool? RT_ShowSupport { get; set; }

        [Description("فرآیند چک لیستی")]
        [Column(Order = 101)]
        public bool? RT_CheckList { get; set; }

        [Description("فرآیند ERP")]
        [Column(Order = 102)]
        public bool? RT_ERP { get; set; }
        [Column(Order = 103)]
        public bool? RT_AnotherRequester { get; set; }

        [Description("حذف تایید درخواست کننده")]
        [Column(Order = 104)]
        public bool? RT_RemoveRequestorApproval { get; set; }
        #endregion

        #endregion

        #region Relations
        [Description("نام فرآیند")]
        public virtual ICollection<P_SubRequestTitle>? RT_P_SubRequestTitle { get; set; } = new HashSet<P_SubRequestTitle>();
        #endregion
    }
}
