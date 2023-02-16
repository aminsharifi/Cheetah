namespace Cheetah_DataAccess.Systems
{
    using Cheetah_DataAccess.Data;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("S_Location", Schema = "Systems")]
    public partial class S_Location : BasePSClass
    {
        #region Simple Prop        
        [InverseProperty("S_Location")]
        public virtual ICollection<S_UserLocation>? S_UserLocation { get; set; } = new HashSet<S_UserLocation>();
        #endregion

        #region Relations
        #region Entity

        #endregion

        #region Collections

        #endregion
        #endregion
    }
}
