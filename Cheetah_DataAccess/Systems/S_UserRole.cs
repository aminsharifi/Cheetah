namespace Cheetah_DataAccess.Systems
{
    using Cheetah_DataAccess.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("S_UserRole", Schema = "Systems")]
    public partial class S_UserRole: BasePSClass
    {
        #region Simple Prob
        public virtual S_Role? UR_Role { get; set; }
        public virtual S_User? UR_User { get; set; }
        
        #endregion

        #region Collection

        #endregion
    }
}
