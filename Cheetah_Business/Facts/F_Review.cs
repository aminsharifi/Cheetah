using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Facts
{
    [Table(nameof(F_Review), Schema = nameof(TableType.Facts))]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class F_Review : BaseClass<F_Review>
    {
        [Column(Order = 100)]
        [Description("بررسی کننده")]
        public long? APV_UserInChargeId { get; set; }
        public virtual D_User? APV_UserInCharge { get; set; }

        [Column(Order = 101)]
        public long? APV_EndorsementId { get; set; }
        public virtual F_Endorsement? APV_Endorsement { get; set; }

        [Column(Order = 102)]
        public long? APV_NeedReviewId { get; set; }
        public virtual F_AllReview? APV_NeedReview { get; set; }

        [Column(Order = 103)]
        public long? APV_ReviewId { get; set; }
        public virtual F_AllReview? APV_Review { get; set; }

        [Description("ضمیمه")]
        public virtual ICollection<F_Attachment>? APV_Attachments { get; set; } = new HashSet<F_Attachment>();
    }
}
