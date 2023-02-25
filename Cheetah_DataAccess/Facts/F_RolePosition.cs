using Cheetah_DataAccess.Parameters;

namespace Cheetah_DataAccess.Facts
{
    using Cheetah_DataAccess.Data;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("F_RolePosition", Schema = "Facts")]
    public partial class F_RolePosition : BaseClass<F_RolePosition>
    {
        [Column(Order = 100)]
        public virtual D_Role? UP_Role { get; set; }
        [Column(Order = 101)]
        public virtual D_Position? UP_PositionOrg { get; set; }
    }
}