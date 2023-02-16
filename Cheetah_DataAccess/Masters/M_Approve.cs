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
        //Passed

        #region Basic Prop

        [StringLength(50)]
        [Description("نام فرم")]
        public string? APV_Subject { get; set; }
        #endregion
        [Description("اقدام کاربر")]
        public virtual P_UserAction? APV_UserAction { get; set; }
        [Description("بررسی کننده")]
        public virtual S_User? APV_UserInCharge { get; set; }
        [Description("ضمیمه")]
        public virtual ICollection<M_Attachment>? APV_M_Attachment { get; set; } = new HashSet<M_Attachment>();
    }
}
