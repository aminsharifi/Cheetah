namespace Cheetah_DataAccess.Gizelle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Cheetah_DataAccess.BPMS;

    public partial class Approve
    {
        //Passed
        #region Common Prop
        [Key]
        public long IdRecord { get; set; }
        public long TimeRecord { get; set; } = DateTime.Now.Ticks;
        public Guid GuidRecord { get; set; } = Guid.NewGuid();
        public bool DsblRecord { get; set; } = false;
        #endregion

        #region Basic Prop
        [Description("تاریخ دریافت کار")]
        public DateTime? Approves_TaskRecieveDate { get; set; }
        [Description("تاریخ ارسال کار")]
        public DateTime? Approves_TaskSentDate { get; set; }

        [StringLength(1024)]
        [Description("توضیحات کاربر")]
        public string? Approves_UserDescription { get; set; }

        [StringLength(50)]
        [Description("نام فرم")]
        public string? Approves_Subject { get; set; }

        [StringLength(50)]
        [Description("شماره فعالیت")]
        public string? Approves_Number { get; set; }
        [Description("ضمیمه")]
        public byte? Approves_Attachment { get; set; }
        #endregion

        #region Relations

        #region RequestInformation
        public long? Approves_idRequestInformation { get; set; }
        [ForeignKey("Approves_idRequestInformation")]
        public virtual RequestInformation? Approves_RequestInformation { get; set; }
        #endregion

        #region Approves_UserAction
        public long? Approves_idUserAction { get; set; }
        [ForeignKey("Approves_idUserAction")]
        public virtual UserAction? Approves_UserAction { get; set; }
        #endregion

        #region Approves_UserInCharge
        public long? Approves_idUserInCharge { get; set; }
        [ForeignKey("Approves_idUserInCharge")]
        public virtual WFUser? Approves_UserInCharge { get; set; }
        #endregion

        #endregion
    }
}
