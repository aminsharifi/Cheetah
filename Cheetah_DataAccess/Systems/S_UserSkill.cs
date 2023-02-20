namespace Cheetah_DataAccess.Systems
{
    using Cheetah_DataAccess.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("S_UserSkill", Schema = "Systems")]
    public partial class S_UserSkill : BasePSClass
    {
        #region Simple Prob
        [Column(Order = 100)]
        public virtual S_Skill? US_Skill { get; set; }
        [Column(Order = 101)]
        public virtual S_User? US_User { get; set; }

        #endregion

        #region Collection

        #endregion
    }
}
