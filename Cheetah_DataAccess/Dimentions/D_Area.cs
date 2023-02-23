namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Facts;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("D_Area", Schema = "Dimentions")]
    public partial class D_Area : BaseDimClass
    {
        [Column(Order = 100)]
        public virtual D_UnitType? Area_UnitType { get; set; }
        #region Relations
        [InverseProperty("UA_Area")]
        public virtual ICollection<F_UserArea>? Area_UserAreas { get; set; } = new HashSet<F_UserArea>();
        #endregion
    }
}
