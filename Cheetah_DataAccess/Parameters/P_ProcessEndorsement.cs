namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Systems;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("P_ProcessEndorsement", Schema = "Parameters")]
    public partial class P_ProcessEndorsement : BasePSClass
    {
        #region Simple Prop

        #region Condition        

        #region PSE_Conditional
        [Description("شرطی")]
        public bool? PSE_Conditional { get; set; }
        [Description("شرطی 2")]
        public bool? PSE_Conditional2 { get; set; }
        [Description("شرطی 3")]
        public bool? PSE_Conditional3 { get; set; }

        [Description("شرطی 4")]
        public bool? PSE_Conditional4 { get; set; }

        [Description("شرطی 5")]
        public bool? PSE_Conditional5 { get; set; }
        #endregion

        [Description("شرط دارویی")]
        public bool? PSE_ConditionDrug { get; set; }

        [Description("شرط FMCG")]
        public bool? PSE_ConditionFMCG { get; set; }

        [Description("سهم تامین کننده")]
        public bool? PSE_SupplierSHare { get; set; }

        [Description("سهم شرکت")]
        public bool? PSE_CompanySHare { get; set; }

        #endregion

        #region Notifications
        [Description("ارسال ایمیل")]
        public bool? PSE_Mail { get; set; }
        [Description("ارسال به اتوماسیون")]
        public bool? PSE_Automation { get; set; }
        [Description("ارسال به پیام کوتاه")]
        public bool? PSE_SMS { get; set; }
        [Description("ارسال رونوشت")]
        public bool? PSE_Transcript { get; set; }
        #endregion

        [StringLength(50)]
        [Description("نام فرم")]
        public string? PSE_TaskName { get; set; }

        [StringLength(50)]
        [Description("اقدامات مجاز کاربر")]
        public string? PSE_ValidUserAction { get; set; }

        [Description("ارسال جهت اخذ تایید")]
        public bool? PSE_Active { get; set; }

        [StringLength(50)]
        [Description("زیرفرآیند")]
        public string? PSE_SubRequestTitles { get; set; }

        [StringLength(50)]
        [Description("اقدامات مجاز خروجی")]
        public string? PSE_ValidOutput { get; set; }

        [Description("ارسال به همه")]
        public bool? PSE_SendAll { get; set; }

        #endregion

        #region Relation

        #region Entity

        [StringLength(50)]
        [Description("وضعیت استخدامی")]
        public long? PSE_UserRelationship { get; set; }

        [Description("کارشناس تخصیص پیشفرض")]
        public virtual S_User? PSE_ExpertUser { get; set; }


        [Description("سمت سازمانی")]
        public virtual P_PositionOrg? PSE_PON { get; set; }

        [Description("نام فرآیند")]
        public virtual P_RequestTitle? PSE_RequestTitle { get; set; }


        [Description("وضعیت فرآیند")]
        public virtual P_ProcessState? PSE_ProcessState { get; set; } 
        #endregion
        
        #endregion
    }
}
