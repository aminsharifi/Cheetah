namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Facts;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("D_UnitType", Schema = "Dimentions")]
    public partial class D_UnitType : BaseClass<D_UnitType>
    {
        #region Simple Prop        
        #endregion

        #region Relations
        #region Entity

        #endregion

        #region Collections
        [InverseProperty("Area_UnitType")]
        public virtual ICollection<D_Area>? UT_Areas { get; set; } = new HashSet<D_Area>();
        #endregion
        #endregion
    }
}
