using Cheetah_DataAccess.Parameters;

namespace Cheetah_DataAccess.Facts
{
    using Cheetah_DataAccess.Data;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("F_EndorsementPosition", Schema = "Facts")]
    public partial class F_EndorsementPosition : BaseDimClass
    {
        [Column(Order = 100)]
        public virtual D_ProcessEndorsement? UP_ProcessEndorsement { get; set; }
        [Column(Order = 101)]
        public virtual D_Position? UP_PositionOrg { get; set; }
    }
}
