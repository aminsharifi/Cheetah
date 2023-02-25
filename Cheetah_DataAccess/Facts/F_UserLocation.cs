using Cheetah_DataAccess.Parameters;

namespace Cheetah_DataAccess.Facts
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Dimentions;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("F_UserLocation", Schema = "Facts")]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class F_UserLocation : BaseClass<F_UserLocation>
    {
        #region Simple Prob
        [Column(Order = 100)]
        public virtual D_User? UL_UserLocation { get; set; }
        [Column(Order = 101)]
        public virtual D_User? UL_RelatedUserLocation { get; set; }
        [Column(Order = 102)]
        public virtual D_Location? UL_Location { get; set; }


        #endregion

        #region Collection

        #endregion
    }
}
