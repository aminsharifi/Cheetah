using Cheetah_DataAccess.Parameters;

namespace Cheetah_DataAccess.Facts
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Dimentions;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("F_UserRole", Schema = "Facts")]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class F_UserRole : BaseClass<F_UserRole>
    {
        #region Simple Prob
        [Column(Order = 100)]
        public virtual D_Role? UR_Role { get; set; }
        [Column(Order = 101)]
        public virtual D_User? UR_User { get; set; }

        #endregion

        #region Collection

        #endregion
    }
}
