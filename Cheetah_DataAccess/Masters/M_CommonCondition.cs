namespace Cheetah_DataAccess.Masters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Cheetah_DataAccess.Systems;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("M_CommonCondition", Schema = "Masters")]
    [Description("M_CommonCondition")]
    public partial class M_CommonCondition : BaseClass
    {
        //Passed

        #region Simple Prop
        #region Condition        

        #region CCD_Conditional
        [Description("شرطی")]
        public bool? CCD_Conditional { get; set; }
        [Description("شرطی 2")]
        public bool? CCD_Conditional2 { get; set; }
        [Description("شرطی 3")]
        public bool? CCD_Conditional3 { get; set; }

        [Description("شرطی 4")]
        public bool? CCD_Conditional4 { get; set; }

        [Description("شرطی 5")]
        public bool? CCD_Conditional5 { get; set; }
        #endregion

        [Description("شرط دارویی")]
        public bool? CCD_ConditionDrug { get; set; }

        [Description("شرط FMCG")]
        public bool? CCD_ConditionFMCG { get; set; }

        [Description("سهم تامین کننده")]
        public bool? CCD_SupplierSHare { get; set; }

        [Description("سهم شرکت")]
        public bool? CCD_CompanySHare { get; set; }

        #endregion
        #endregion

        #region Collection

        #endregion
    }
}
