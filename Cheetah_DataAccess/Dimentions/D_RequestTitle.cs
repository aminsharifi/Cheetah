namespace Cheetah_DataAccess.Dimentions
{
    using Cheetah_DataAccess.Data;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("D_RequestTitle", Schema = "Dimentions")]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class D_RequestTitle : BaseClass<D_RequestTitle>
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

        public long RT_EndorsementPatternId { get; set; }
        [Description("حذف تایید درخواست کننده")]
        [Column(Order = 105)]
        [ForeignKey("RT_EndorsementPatternId")]
        public virtual D_EndorsementPattern RT_EndorsementPattern { get; set; }

        #endregion

        #endregion

        #region Relations

        #endregion
    }
}
