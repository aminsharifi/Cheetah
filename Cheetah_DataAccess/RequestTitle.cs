namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class RequestTitle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RequestTitle()
        {
        }


        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idRequestTitles { get; set; }
        public int finalEnt { get; set; }
        public long baCreatedTime { get; set; }
        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion


        #region Simple Prob
        [StringLength(50)]
        [Description("عنوان درخواست")]
        public string RequestTitles_Name { get; set; }

        [Description("نمایش جهت پشتیبانی")]
        public bool? RequestTitles_ShowSupport { get; set; }

        [StringLength(50)]
        [Description("نام فرآیند")]
        public string RequestTitles_ProcessName { get; set; }

        [Description("کد عنوان درخواست")]
        public int? RequestTitles_Code { get; set; }

        [StringLength(50)]
        [Description("RT_ConditionOccur")]
        public string RT_ConditionOccur { get; set; }

        [StringLength(50)]
        [Description("RT_ConditionOccur2")]
        public string RT_ConditionOccur2 { get; set; }

        [Description("فرآیند چک لیستی")]
        public bool? CheckList { get; set; }

        [Description("فرآیند ERP")]
        public bool? ERP { get; set; }

        public bool? RT_AnotherRequester { get; set; }

        [StringLength(50)]
        public string RT_ConditionOccur3 { get; set; }

        [StringLength(50)]
        public string RT_ConditionOccur4 { get; set; }

        [StringLength(50)]
        public string RT_ConditionOccur5 { get; set; }

        [StringLength(50)]
        public string RT_OutputVar1 { get; set; }

        [StringLength(50)]
        public string RT_OutputVar2 { get; set; }

        [StringLength(50)]
        public string RT_OutputVar3 { get; set; }

        [StringLength(50)]
        public string RT_OutputVar4 { get; set; }

        [StringLength(50)]
        public string RT_OutputVar5 { get; set; }

        [Description("حذف تایید درخواست کننده")]
        public bool? RT_RemoveRequestorApproval { get; set; }

        #endregion
        #region Relations

        #endregion
    }
}
