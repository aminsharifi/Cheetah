namespace Cheetah_DataAccess.Masters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Cheetah_DataAccess.Systems;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("M_CurrentPE", Schema = "Masters")]
    [Description("CurrentProcessEndorsements")]
    public partial class M_CurrentPE : BaseClass
    {
        //Passed

        #region Simple Prop
        [Description("فعال")]
        public Boolean? CPE_Active { get; set; } = false;
        #endregion

        #region Collection
        [Description("تایید کننده")]
        public virtual P_ProcessEndorsement? CPE_ProcessEndorsements { get; set; }
        [Description("اقدام کاربر")]
        public virtual P_UserAction? CPE_UserAction { get; set; }
        [Description("کاربر")]
        public virtual S_User? CPE_User { get; set; }

        #endregion
    }
}
