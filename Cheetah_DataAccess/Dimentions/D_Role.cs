namespace Cheetah_DataAccess.Dimentions
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Facts;
    using Cheetah_DataAccess.Links;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("D_Role", Schema = "Dimentions")]
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
