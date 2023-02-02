namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("P_RequestTitle", Schema = "Parameters")]
    public partial class P_RequestTitle : BasePSClass
    {
        #region Simple Prob

        #region RT_ConditionOccur
        [StringLength(50)]
        [Description("RT_ConditionOccur")]
        public string? RT_ConditionOccur { get; set; }

        [StringLength(50)]
        [Description("RT_ConditionOccur2")]
        public string? RT_ConditionOccur2 { get; set; }
        [StringLength(50)]
        [Description("RT_ConditionOccur3")]
        public string? RT_ConditionOccur3 { get; set; }

        [StringLength(50)]
        [Description("RT_ConditionOccur4")]
        public string? RT_ConditionOccur4 { get; set; }

        [StringLength(50)]
        [Description("RT_ConditionOccur5")]
        public string? RT_ConditionOccur5 { get; set; }
        #endregion

        #region RT_OutputVar
        [StringLength(50)]
        public string? RT_OutputVar1 { get; set; }

        [StringLength(50)]
        public string? RT_OutputVar2 { get; set; }

        [StringLength(50)]
        public string? RT_OutputVar3 { get; set; }

        [StringLength(50)]
        public string? RT_OutputVar4 { get; set; }

        [StringLength(50)]
        public string? RT_OutputVar5 { get; set; }
        #endregion

        #region Others
        [Description("نمایش جهت پشتیبانی")]
        public bool? RT_ShowSupport { get; set; }

        [Description("فرآیند چک لیستی")]
        public bool? RT_CheckList { get; set; }

        [Description("فرآیند ERP")]
        public bool? RT_ERP { get; set; }

        public bool? RT_AnotherRequester { get; set; }

        [Description("حذف تایید درخواست کننده")]
        public bool? RT_RemoveRequestorApproval { get; set; } 
        #endregion

        #endregion

        #region Relations

        #endregion
    }
}
