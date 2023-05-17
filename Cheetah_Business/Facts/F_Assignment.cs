using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Facts
{
    [Table(nameof(F_Assignment), Schema = nameof(TableType.Facts))]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class F_Assignment : BaseClass<F_Assignment>
    {
        [Column(Order = 101)]
        public long? PRM_EndorsementId { get; set; }
        public virtual F_Endorsement? PRM_Endorsement { get; set; }

        [Column(Order = 102)]
        public long? PRM_ReviewId { get; set; }
        public virtual F_Review? PRM_Review { get; set; }

        [Column(Order = 103)]
        public long? PRM_RequestId { get; set; }
        [ForeignKey(nameof(PRM_RequestId))]
        public virtual F_Request? PRM_Request { get; set; }

    }
}
