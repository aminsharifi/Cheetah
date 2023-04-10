namespace Cheetah_DataAccess.Dimentions
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Facts;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.ComponentModel;
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

        public long? PSE_EndorsementPatternId { get; set; }
        [Description("الگو")]
        [Column(Order = 106)]
        [ForeignKey("PSE_EndorsementPatternId")]
        public virtual D_EndorsementPattern? PSE_EndorsementPattern { get; set; }


        public virtual long? PSE_ExpertUserId { get; set; }
        [Description("کارشناس تخصیص پیشفرض")]
        [Column(Order = 107)]
        [ForeignKey("PSE_ExpertUserId")]
        public virtual D_User? PSE_ExpertUser { get; set; }

        public virtual ICollection<F_ListOfParameter>? PSE_ListOfParameter { get; set; } = new HashSet<F_ListOfParameter>();

        public virtual ICollection<F_Endorsement>? PSE_EndorsementPosition { get; set; } = new HashSet<F_Endorsement>();
        #endregion

        #endregion
    }
}
