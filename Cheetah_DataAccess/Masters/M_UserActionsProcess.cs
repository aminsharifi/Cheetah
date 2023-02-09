namespace Cheetah_DataAccess.Masters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using System;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("M_UserActionsProcess", Schema = "Masters")]
    public partial class M_UserActionsProcess : BaseClass
    {
        [Description("ارسال نامه به اتوماسیون")]
        public bool? UAP_Automation { get; set; }

        [Description("sender_input")]
        [StringLength(50)]
        public string? UAP_sender_input { get; set; }

        [Description("Receiver_input")]
        [StringLength(50)]
        public string? UAP_Receiver_input { get; set; }

        [Description("Subject_input")]
        [StringLength(255)]
        public string? UAP_Subject_input { get; set; }

        [Description("TextBody_input")]
        [StringLength(2048)]
        public string? UAP_TextBody_input { get; set; }

        [Description("IdentificationCode_input")]
        [StringLength(215)]
        public string? UAP_IdentificationCode_input { get; set; }

        [Description("SendLetterResponse")]
        public bool? UAP_SendLetterResponse { get; set; }

        [Description("SendERP")]
        public bool? UAP_SendERP { get; set; }

        [Description("ارسال رونوشت به ERP")]
        public bool? UAP_SendNotifyERP { get; set; }

        [Description("CreateDate")]
        public DateTime? UAP_CreateDate { get; set; }

        [Description("پیام کوتاه")]
        public bool? UAP_SMS { get; set; }

        [Description("وضعیت تایید فرآیند")]
        public virtual P_ProcessEndorsement? UAP_P_CurrentPE { get; set; }

        [Description("نام فرآیند")]
        public virtual P_RequestTitle? UAP_P_RequestTitle { get; set; }
        
        [Description("نام فرآیند")]
        public virtual P_PositionOrg? UAP_P_PositionOrg { get; set; }
    }
}
