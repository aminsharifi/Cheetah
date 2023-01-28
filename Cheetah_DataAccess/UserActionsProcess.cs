namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UserActionsProcess")]
    public partial class UserActionsProcess
    {
        public UserActionsProcess()
        {

        }

        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idUserActionsProcess { get; set; }
        public int finalEnt { get; set; }
        public long baCreatedTime { get; set; }
        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion

        #region Simple Prob
        [Description("کد فرآیند")]
        public int? RequestTitles_Code { get; set; }
        
        [Description("ارسال نامه به اتوماسیون")]
        public bool? Automation { get; set; }
        
        [Description("sender_input")][StringLength(50)]
        public string sender_input { get; set; }

        [Description("Receiver_input")][StringLength(50)]
        public string Receiver_input { get; set; }
        
        [Description("Subject_input")][StringLength(255)]
        public string Subject_input { get; set; }
        
        [Description("TextBody_input")][StringLength(2048)]
        public string TextBody_input { get; set; }
        
        [Description("IdentificationCode_input")][StringLength(215)]
        public string IdentificationCode_input { get; set; }

        [Description("SendLetterResponse")]
        public bool? SendLetterResponse { get; set; }

        [Description("SendERP")]
        public bool? SendERP { get; set; }

        [Description("ارسال رونوشت به ERP")]
        public bool? SendNotifyERP { get; set; }

        [Description("CreateDate")]
        public DateTime? CreateDate { get; set; }

        [Description("پیام کوتاه")]
        public bool? SMS { get; set; }
        #endregion

        #region Relations

        #region Entity

        #region CurrentProcessEndorsement
        [Description("وضعیت تایید فرآیند")]
        public long? idCurrentProcessEndorsement { get; set; }
        [ForeignKey("idRequestInformation")][Description("وضعیت تایید فرآیند")]
        public virtual ProcessEndorsement currentProcessEndorsement { get; set; }
        #endregion

        #region RequestInformation
        [Description("اطلاعات عمومی درخواست")]
        public long? idRequestInformation { get; set; }

        [ForeignKey("idRequestInformation")][Description("اطلاعات عمومی درخواست")]
        public virtual RequestInformation requestInformation { get; set; }
        #endregion

        #endregion

        #region Collection

        #endregion

        #endregion
    }
}
