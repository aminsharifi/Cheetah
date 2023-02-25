namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Facts;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("D_Role", Schema = "Dimentions")]
    public partial class D_Role : BaseClass<D_Role>
    {
        #region Simple Prob

        #endregion

        #region Collection
        [InverseProperty("UR_Role")]
        public virtual ICollection<F_UserRole>? ROL_UserRoles { get; set; } = new HashSet<F_UserRole>();
        #endregion
    }
}
