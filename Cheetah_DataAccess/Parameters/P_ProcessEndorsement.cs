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
        [Column(Order = 100)]
        public bool? PSE_Mail { get; set; }
        [Description("ارسال به اتوماسیون")]
        [Column(Order = 101)]
        public bool? PSE_Automation { get; set; }
        [Description("ارسال به پیام کوتاه")]
        [Column(Order = 102)]
        public bool? PSE_SMS { get; set; }
        [Description("ارسال رونوشت")]
        [Column(Order = 103)]
        public bool? PSE_Transcript { get; set; }
        #endregion
        [Description("ارسال جهت اخذ تایید")]
        [Column(Order = 104)]
        public bool? PSE_NeedApprove { get; set; }

        [Description("ارسال به همه")]
        [Column(Order = 105)]
        public bool? PSE_SendAll { get; set; }
        #endregion

        #region Relation

        #region Entity

        [StringLength(50)]
        [Description("زیرفرآیند")]
        [Column(Order = 106)]
        public virtual P_SubRequestTitle? PSE_SubRequestTitle { get; set; }

        [Description("کارشناس تخصیص پیشفرض")]
        [Column(Order = 107)]
        public virtual S_User? PSE_ExpertUser { get; set; }

        [Description("نام فرآیند")]
        [Column(Order = 108)]
        public virtual P_RequestTitle? PSE_RequestTitle { get; set; }

        [Description("وضعیت فرآیند")]
        [Column(Order = 109)]
        public virtual P_ProcessState? PSE_ProcessState { get; set; }

        [Description("سمت سازمانی")]
        public virtual ICollection<P_PositionOrg>? PSE_PON { get; set; } = new HashSet<P_PositionOrg>();
        public virtual ICollection<M_ListOfParameter>? PSE_M_ListOfParameter { get; set; } = new HashSet<M_ListOfParameter>();
        public virtual ICollection<P_EndorsementPosition>? PSE_P_EndorsementPosition { get; set; } = new HashSet<P_EndorsementPosition>();
        #endregion

        #endregion
    }
}
