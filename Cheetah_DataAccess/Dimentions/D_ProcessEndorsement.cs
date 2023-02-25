namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Dimentions;
    using Cheetah_DataAccess.Facts;
    using Cheetah_DataAccess.Masters;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("D_ProcessEndorsement", Schema = "Dimentions")]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class D_ProcessEndorsement : BaseClass<D_ProcessEndorsement>
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
        public virtual D_SubRequestTitle? PSE_SubRequestTitle { get; set; }

        [Description("کارشناس تخصیص پیشفرض")]
        [Column(Order = 107)]
        public virtual D_User? PSE_ExpertUser { get; set; }

        [Description("نام فرآیند")]
        [Column(Order = 108)]
        public virtual D_RequestTitle? PSE_RequestTitle { get; set; }

        [Description("وضعیت فرآیند")]
        [Column(Order = 109)]
        public virtual D_ProcessState? PSE_ProcessState { get; set; }

        public virtual ICollection<F_ListOfParameter>? PSE_ListOfParameter { get; set; } = new HashSet<F_ListOfParameter>();
        public virtual ICollection<F_EndorsementPosition>? PSE_EndorsementPosition { get; set; } = new HashSet<F_EndorsementPosition>();
        #endregion

        #endregion
    }
}
