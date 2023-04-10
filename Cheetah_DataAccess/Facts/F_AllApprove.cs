namespace Cheetah_DataAccess.Facts
{
    using Cheetah_DataAccess.Data;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("F_AllApprove", Schema = "Facts")]
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
        public virtual F_Approve? AAP_Current_Approve { get; set; }
        [Column(Order = 101)]
        public virtual F_Approve? AAP_Last_Approve { get; set; }
        #endregion

        #region Collection
        [InverseProperty("APV_NeedApprove")]
        public virtual ICollection<F_Approve>? AAP_NeedApproves { get; set; } = new HashSet<F_Approve>();
        [InverseProperty("APV_Approve")]
        public virtual ICollection<F_Approve>? AAP_Approves { get; set; } = new HashSet<F_Approve>();
        #endregion
    }
}
