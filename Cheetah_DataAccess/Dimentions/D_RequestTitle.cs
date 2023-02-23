namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("D_RequestTitle", Schema = "Dimentions")]
    public partial class D_RequestTitle : BaseDimClass
    {
        #region Simple Prob

        #region Others
        [Description("نمایش جهت پشتیبانی")]
        [Column(Order = 100)]
        public Boolean? RT_ShowSupport { get; set; }

        [Description("فرآیند چک لیستی")]
        [Column(Order = 101)]
        public Boolean? RT_CheckList { get; set; }

        [Description("فرآیند ERP")]
        [Column(Order = 102)]
        public Boolean? RT_ERP { get; set; }
        [Column(Order = 103)]
        public Boolean? RT_AnotherRequester { get; set; }

        [Description("حذف تایید درخواست کننده")]
        [Column(Order = 104)]
        public Boolean? RT_RemoveRequestorApproval { get; set; }
        #endregion

        #endregion

        #region Relations
        [Description("نام فرآیند")]
        public virtual ICollection<D_SubRequestTitle>? RT_SubRequestTitles { get; set; } = new HashSet<D_SubRequestTitle>();
        #endregion
    }
}
