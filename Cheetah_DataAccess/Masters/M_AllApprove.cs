namespace Cheetah_DataAccess.Masters
{
    using Cheetah_DataAccess.Data;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("M_AllApprove", Schema = "Masters")]
    [Description("CurrentProcessEndorsements")]
    public partial class M_AllApprove : BaseClass
    {
        //Passed

        #region Simple Prop
        public virtual M_Approve? Current_M_Approve { get; set; }
        public virtual M_Approve? Last_M_Approve { get; set; }
        #endregion

        #region Collection
        public virtual ICollection<M_Approve>? M_Approves { get; set; } = new HashSet<M_Approve>();
        #endregion
    }
}
