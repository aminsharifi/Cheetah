namespace Cheetah_DataAccess.Systems
{
    using Cheetah_DataAccess.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("S_Area", Schema = "Systems")]
    public partial class S_Area: BasePSClass
    {
        #region Relations
        [InverseProperty("UR_Area")]
        public virtual ICollection<S_UserArea>? Area_S_UserAreas { get; set; } = new HashSet<S_UserArea>();
        #endregion
    }
}
