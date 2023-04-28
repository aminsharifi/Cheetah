using Cheetah_Common.Data;
using Cheetah_Common.Links;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Common.Dimentions
{

    [Table(nameof(D_Position), Schema = nameof(TableType.Dimentions))]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class D_Position : BaseClass<D_Position>
    {
        public virtual ICollection<L_UserPosition>? PSO_UserPositions { get; set; } = new HashSet<L_UserPosition>();

        public virtual ICollection<L_RolePosition>? PSO_RolePositions { get; set; } = new HashSet<L_RolePosition>();
    }
}