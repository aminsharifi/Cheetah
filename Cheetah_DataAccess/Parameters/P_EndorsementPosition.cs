namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("P_EndorsementPosition", Schema = "Parameters")]
    public partial class P_EndorsementPosition : BasePSClass
    {
        [Column(Order = 100)]
        public virtual P_ProcessEndorsement? UP_ProcessEndorsement { get; set; }
        [Column(Order = 101)]
        public virtual P_PositionOrg? UP_PositionOrg { get; set; }
    }
}
