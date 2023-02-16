namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Masters;
    using Cheetah_DataAccess.Systems;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("P_ProcessEndorsement", Schema = "Parameters")]
    public partial class P_ProcessEndorsement : BasePSClass
    {
        #region Simple Prop

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
        public bool? PSE_NeedApprove { get; set; }

        [StringLength(50)]
        [Description("زیرفرآیند")]
        public string? PSE_SubRequestTitles { get; set; }

        [StringLength(50)]
        [Description("اقدامات مجاز خروجی")]
        public string? PSE_ValidOutput { get; set; }

        [Description("ارسال به همه")]
        public bool? PSE_SendAll { get; set; }
        public long? PSE_Int_P_FieldType { get; set; }
        public bool? PSE_Bool_P_FieldType { get; set; }
        #endregion

        #region Relation

        #region Entity

        [Description("کارشناس تخصیص پیشفرض")]
        public virtual S_User? PSE_ExpertUser { get; set; }

        [Description("نام فرآیند")]
        public virtual P_RequestTitle? PSE_RequestTitle { get; set; }

        [Description("وضعیت فرآیند")]
        public virtual P_ProcessState? PSE_ProcessState { get; set; }

        [Description("سمت سازمانی")]
        public virtual ICollection<P_PositionOrg>? PSE_PON { get; set; } = new HashSet<P_PositionOrg>();        
        public virtual ICollection<M_ListOfParameter>? PSE_M_ListOfParameter { get; set; } = new HashSet<M_ListOfParameter>();
        #endregion

        #endregion
    }
}
