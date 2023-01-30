namespace Cheetah_DataAccess.Masters
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Cheetah_DataAccess.Systems;

    [Table("M_Approve")]
    public partial class M_Approve: BaseClass
    {
        //Passed

        #region Basic Prop
        [Description("تاریخ دریافت کار")]
        public DateTime? APV_TaskRecieveDate { get; set; }
        [Description("تاریخ ارسال کار")]
        public DateTime? APV_TaskSentDate { get; set; }

        [StringLength(1024)]
        [Description("توضیحات کاربر")]
        public string? APV_UserDescription { get; set; }

        [StringLength(50)]
        [Description("نام فرم")]
        public string? APV_Subject { get; set; }

        [StringLength(50)]
        [Description("شماره فعالیت")]
        public string? APV_Number { get; set; }
        [Description("ضمیمه")]
        public byte? APV_Attachment { get; set; }
        #endregion

        #region Relations

        #region RequestInformation
        public long? APV_idRequestInformation { get; set; }
        [ForeignKey("APV_idRequestInformation")]
        public virtual M_RequestInformation? APV_RequestInformation { get; set; }
        #endregion

        #region APV_UserAction
        public long? APV_idUserAction { get; set; }
        [ForeignKey("APV_idUserAction")]
        public virtual P_UserAction? APV_UserAction { get; set; }
        #endregion

        #region APV_UserInCharge
        public long? APV_idUserInCharge { get; set; }
        [ForeignKey("APV_idUserInCharge")]
        public virtual S_User? APV_UserInCharge { get; set; }
        #endregion

        #endregion
    }
}
