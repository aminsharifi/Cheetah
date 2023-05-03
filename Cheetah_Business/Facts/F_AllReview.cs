using Cheetah_Business.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Facts
{
    [Table(nameof(F_AllReview), Schema = nameof(TableType.Facts))]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class F_AllReview : BaseClass<F_AllReview>
    {
        //Passed

        #region Simple Prop

        [Column(Order = 100)]
        public virtual long? AAP_Current_ReviewId { get; set; }
        public virtual F_Review? AAP_Current_Review { get; set; }

        [Column(Order = 101)]        
        public virtual long? AAP_Last_ReviewId { get; set; }
        public virtual F_Review? AAP_Last_Review { get; set; }
        #endregion

        #region Collection
        [InverseProperty(nameof(F_Review.APV_NeedReview))]
        public virtual ICollection<F_Review>? AAP_NeedReviews { get; set; } = new HashSet<F_Review>();
        [InverseProperty(nameof(F_Review.APV_Review))]
        public virtual ICollection<F_Review>? AAP_Reviews { get; set; } = new HashSet<F_Review>();
        #endregion
    }
}
