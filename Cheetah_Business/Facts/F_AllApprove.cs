using Cheetah_Business.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Facts
{
    [Table(nameof(F_AllApprove), Schema = nameof(TableType.Facts))]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class F_AllApprove : BaseClass<F_AllApprove>
    {
        //Passed

        #region Simple Prop

        [Column(Order = 100)]
        public virtual long? AAP_Current_ApproveId { get; set; }
        public virtual F_Approve? AAP_Current_Approve { get; set; }

        [Column(Order = 101)]        
        public virtual long? AAP_Last_ApproveId { get; set; }
        public virtual F_Approve? AAP_Last_Approve { get; set; }
        #endregion

        #region Collection
        [InverseProperty(nameof(F_Approve.APV_NeedApprove))]
        public virtual ICollection<F_Approve>? AAP_NeedApproves { get; set; } = new HashSet<F_Approve>();
        [InverseProperty(nameof(F_Approve.APV_Approve))]
        public virtual ICollection<F_Approve>? AAP_Approves { get; set; } = new HashSet<F_Approve>();
        #endregion
    }
}
