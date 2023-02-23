using Cheetah_DataAccess.Parameters;

namespace Cheetah_DataAccess.Facts
{
    using Cheetah_DataAccess.Data;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("F_UserArea", Schema = "Facts")]
    public partial class F_UserArea : BaseDimClass
    {
        #region Simple Prob
        [Column(Order = 100)]
        public virtual D_Area? UA_Area { get; set; }
        [Column(Order = 101)]
        public virtual F_User? UA_User { get; set; }
        #endregion

        #region Collection

        #endregion
    }
}
