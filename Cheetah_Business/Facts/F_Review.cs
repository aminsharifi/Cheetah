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
        public long? APV_PerformerId { get; set; }
        public virtual D_User? APV_Performer { get; set; }

        [Column(Order = 101)]
        public long? APV_AssignmentId { get; set; }
        [ForeignKey(nameof(APV_AssignmentId))]
        public virtual F_Assignment? APV_Assignment { get; set; }

        [Column(Order = 102)]
        public long? APV_RequestId { get; set; }
        public virtual F_Request? APV_Request { get; set; }


        [Column(Order = 104)]
        public long? APV_TagId { get; set; }
        public virtual D_Tag? APV_Tag { get; set; }
        

        [Description("ضمیمه")]
        public virtual ICollection<F_Attachment>? APV_Attachments { get; set; } = new HashSet<F_Attachment>();
    }
}
