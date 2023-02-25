using Cheetah_DataAccess.Parameters;

namespace Cheetah_DataAccess.Facts
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Dimentions;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("F_UserSkill", Schema = "Facts")]
    public partial class F_UserSkill : BaseClass<F_UserSkill>
    {
        #region Simple Prob
        [Column(Order = 100)]
        public virtual D_Skill? US_Skill { get; set; }
        [Column(Order = 101)]
        public virtual D_User? US_User { get; set; }

        #endregion

        #region Collection

        #endregion
    }
}
