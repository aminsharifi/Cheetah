namespace Cheetah_DataAccess.Systems
{
    using Cheetah_DataAccess.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("S_Skill", Schema = "Systems")]
    public partial class S_Skill : BasePSClass
    {
        #region Simple Prob

        #endregion

        #region Collection
        [InverseProperty("US_Skill")]
        public virtual ICollection<S_UserSkill>? S_UserSkills { get; set; } = new HashSet<S_UserSkill>();
        #endregion
    }
}
