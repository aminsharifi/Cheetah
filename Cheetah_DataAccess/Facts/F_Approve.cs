namespace Cheetah_DataAccess.Masters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Facts;
    using Cheetah_DataAccess.Parameters;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("F_Approve", Schema ="Facts")]
    
    public partial class F_Approve: BaseDimClass
    {
        [StringLength(50)]
        [Description("نام فرم")]
        [Column(Order = 100)]
        public string? APV_Subject { get; set; }
        [Description("بررسی کننده")]
        [Column(Order = 101)]         
        public virtual F_User? APV_UserInCharge { get; set; }
        [Description("ضمیمه")]
        [Column(Order = 102)]
        public virtual D_ProcessEndorsement? APV_ProcessEndorsement { get; set; }
        [Column(Order = 103)]
        public virtual F_AllApprove? APV_NeedApprove { get; set; }
        [Column(Order = 104)]
        public virtual F_AllApprove? APV_Approve { get; set; }
        public virtual ICollection<F_Attachment>? APV_Attachments { get; set; } = new HashSet<F_Attachment>();
    }
}
