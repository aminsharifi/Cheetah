namespace Cheetah_DataAccess.Systems
{
    using Cheetah_DataAccess.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("S_Role", Schema = "Systems")]
    public partial class S_Role: BasePSClass
    {
        #region Simple Prob

        #endregion

        #region Collection
        [InverseProperty("UR_Role")]
        public virtual ICollection<S_UserRole>? S_UserRoles { get; set; } = new HashSet<S_UserRole>();
        #endregion
    }
}
