namespace Cheetah_DataAccess.Masters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Cheetah_DataAccess.Systems;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("M_CommonAttrib", Schema = "Masters")]
    [Description("M_CommonAttrib")]
    public partial class M_CommonAttrib : BaseClass
    {
        //Passed

        #region Simple Prop
        [Description("واحد")]
        public virtual S_Area? CMA_S_Area { get; set; }
        [Description("موقعیت")]
        public virtual S_Location? CMA_S_Location { get; set; }
        [Description("نوع واحد")]
        public virtual P_UnitType? CMA_P_UnitType { get; set; }
        
        #endregion

        #region Collection

        #endregion
    }
}
