namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Facts;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("D_Location", Schema = "Dimentions")]
    public partial class D_Location : BaseDimClass
    {
        #region Simple Prop        
        [InverseProperty("UL_Location")]
        public virtual ICollection<F_UserLocation>? Loc_UserLocations { get; set; } = new HashSet<F_UserLocation>();
        #endregion

        #region Relations
        #region Entity

        #endregion

        #region Collections

        #endregion
        #endregion
    }
}
