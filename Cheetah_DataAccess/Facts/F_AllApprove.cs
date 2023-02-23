namespace Cheetah_DataAccess.Masters
{
    using Cheetah_DataAccess.Data;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("F_AllApprove", Schema = "Facts")]
    public partial class F_AllApprove : BaseClass
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
