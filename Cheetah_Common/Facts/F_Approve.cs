using Cheetah_Common.Data;
using Cheetah_Common.Dimentions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Common.Facts
{

    [Table(nameof(F_Approve), Schema = nameof(TableType.Facts))]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class F_Approve : BaseClass<F_Approve>
    {
        [Column(Order = 100)]
        [Description("بررسی کننده")]
        public long? APV_UserInChargeId { get; set; }
        public virtual D_User? APV_UserInCharge { get; set; }

        [Column(Order = 101)]
        public long? APV_EndorsementId { get; set; }
        public virtual F_Endorsement? APV_Endorsement { get; set; }

        [Column(Order = 102)]
        public long? APV_NeedApproveId { get; set; }
        public virtual F_AllApprove? APV_NeedApprove { get; set; }

        [Column(Order = 103)]
        public long? APV_ApproveId { get; set; }
        public virtual F_AllApprove? APV_Approve { get; set; }

        [Description("ضمیمه")]
        public virtual ICollection<F_Attachment>? APV_Attachments { get; set; } = new HashSet<F_Attachment>();
    }
}
