namespace Cheetah_DataAccess.Systems
{
    using Cheetah_DataAccess.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("S_UserArea", Schema = "Systems")]
    public partial class S_UserArea : BasePSClass
    {
        #region Simple Prob
        [Column(Order = 100)]
        public virtual S_Area? UR_Area { get; set; }
        [Column(Order = 101)]
        public virtual S_User? UR_User { get; set; }        
        #endregion

        #region Collection

        #endregion
    }
}