namespace Cheetah_DataAccess.Dimentions
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Links;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("D_Location", Schema = "Dimentions")]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class D_Location : BaseClass<D_Location>
    {
        #region Simple Prop        
        public virtual ICollection<L_UserLocation>? Loc_UserLocations { get; set; } = new HashSet<L_UserLocation>();
        #endregion

        #region Relations
        #region Entity

        #endregion

        #region Collections

        #endregion
        #endregion
    }
}
