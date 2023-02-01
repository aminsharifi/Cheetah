namespace Cheetah_DataAccess.Masters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("M_UserActionsProcess")]
    public partial class M_UserActionsProcess : BaseClass
    {
        #region Simple Prob
        

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
        #endregion

        #region Relations

        #region Entity

        #region CurrentProcessEndorsement
        [Description("وضعیت تایید فرآیند")]
        public long? UAP_idCurrentPE { get; set; }
        [ForeignKey("UAP_idCurrentPE")]
        [Description("وضعیت تایید فرآیند")]
        public virtual P_ProcessEndorsement? UAP_CurrentPE { get; set; }
        #endregion

        #region UAP_RequestTitle
        [Description("کد فرآیند")]
        public long? UAP_idRequestTitle { get; set; }
        [ForeignKey("UAP_idRequestTitle")]
        public virtual P_RequestTitle? UAP_RequestTitle { get; set; } 
        #endregion

        #region RequestInformation
        [Description("اطلاعات عمومی درخواست")]
        public long? idRequestInformation { get; set; }

        [ForeignKey("idRequestInformation")]
        [Description("اطلاعات عمومی درخواست")]
        public virtual M_RequestInformation? UAP_RequestInformation { get; set; }
        #endregion

        #endregion

        #region Collection

        #endregion

        #endregion
    }
}
