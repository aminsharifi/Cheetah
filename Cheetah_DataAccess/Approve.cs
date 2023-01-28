namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Approve
    {
        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idApproves { get; set; }

        public int? finalEnt { get; set; }

        public long baCreatedTime { get; set; }

        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion

        #region Basic Prop
        [Description("تاریخ دریافت کار")]
        public DateTime? Approves_TaskRecieveDate { get; set; }
        [Description("تاریخ ارسال کار")]
        public DateTime? Approves_TaskSentDate { get; set; }

        [StringLength(1024)]
        [Description("توضیحات کاربر")]
        public string Approves_UserDescription { get; set; }

        [StringLength(50)]
        [Description("نام فرم")]
        public string Approves_Subject { get; set; }

        [StringLength(50)]
        [Description("شماره فعالیت")]
        public string Approves_Number { get; set; }
        [Description("ضمیمه")]
        public byte? Approves_Attachment { get; set; }
        #endregion

        #region Relations

        #region RequestInformation
        public long? idRequestInformation { get; set; }
        [ForeignKey("idRequestInformation")]
        public virtual RequestInformation? RequestInformation { get; set; }
        #endregion

        #region Approves_UserAction
        public long? idApproves_UserAction { get; set; }
        [ForeignKey("idApproves_UserAction")]
        public virtual UserAction? Approves_UserAction { get; set; }
        #endregion

        #region Approves_UserInCharge
        public long? idApproves_UserInCharge { get; set; }
        [ForeignKey("idApproves_UserInCharge")]
        public virtual WFUSER? Approves_UserInCharge { get; set; }
        #endregion

        #endregion
    }
}
