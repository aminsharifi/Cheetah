using Cheetah_Business.Data;
using Cheetah_Business.Facts;
using Cheetah_Business.Links;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Dimentions
{
    [Table(nameof(D_Role), Schema = nameof(TableType.Dimentions))]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    [Index(nameof(ROL_Independent), IsUnique = false, AllDescending = true)]
    public partial class D_Role : BaseClass<D_Role>
    {

        [Column(Order = 100)]
        public Boolean ROL_Independent { get; set; } = false;

        #region Collection
        public virtual ICollection<L_RolePosition>? ROL_RolePositions { get; set; } = new HashSet<L_RolePosition>();

        public virtual ICollection<F_Endorsement>? ROL_EndorsementPosition { get; set; } = new HashSet<F_Endorsement>();
        #endregion
    }
}
