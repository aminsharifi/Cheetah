namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Facts;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("D_Skill", Schema = "Dimentions")]
    public partial class D_Skill : BaseDimClass
    {
        #region Simple Prob

        #endregion

        #region Collection
        [InverseProperty("US_Skill")]
        public virtual ICollection<F_UserSkill>? SKL_UserSkills { get; set; } = new HashSet<F_UserSkill>();
        #endregion
    }
}
