using Cheetah_DataAccess.Parameters;

namespace Cheetah_DataAccess.Facts
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Dimentions;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("F_UserLocation", Schema = "Facts")]
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
