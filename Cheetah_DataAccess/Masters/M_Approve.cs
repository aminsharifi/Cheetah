namespace Cheetah_DataAccess.Masters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Cheetah_DataAccess.Systems;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("M_Approve", Schema ="Masters")]
    
    public partial class M_Approve: BasePSClass
    {
        [StringLength(50)]
        [Description("نام فرم")]
        [Column(Order = 100)]
        public string? APV_Subject { get; set; }
        [Description("بررسی کننده")]
        [Column(Order = 101)]

        public virtual S_User? APV_UserInCharge { get; set; }
        [Description("ضمیمه")]
        [Column(Order = 102)]
        public virtual P_ProcessEndorsement? APV_P_ProcessEndorsement { get; set; }
        public virtual ICollection<M_Attachment>? APV_M_Attachments { get; set; } = new HashSet<M_Attachment>();
    }
}
