namespace Cheetah_DataAccess.Systems
{
    using Cheetah_DataAccess.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("S_UserLocation", Schema = "Systems")]
    public partial class S_UserLocation : BasePSClass
    {
        #region Simple Prob
        [Column(Order = 100)]
        public virtual S_User? UL_UserLocation { get; set; }
        [Column(Order = 101)]
        public virtual S_User? UL_RelatedUserLocation { get; set; }
        [Column(Order = 102)]
        public virtual S_Location? S_Location { get; set; }


        #endregion

        #region Collection

        #endregion
    }
}
