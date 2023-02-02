namespace Cheetah_DataAccess.Masters
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Cheetah_DataAccess.Systems;

    [Table("M_CurrentPE", Schema = "Masters")]
    [Description("CurrentProcessEndorsements")]
    public partial class M_CurrentPE : BaseClass
    {
        //Passed

        #region Simple Prop

        #endregion

        #region Collection

        [Description("تایید کننده")]
        public virtual P_ProcessEndorsement? CPE_ProcessEndorsements { get; set; }
        public virtual M_RequestInformation? CPE_RequestInformation { get; set; }
        [Description("اقدام کاربر")]
        public virtual P_UserAction? CPE_UserAction { get; set; }
        public virtual M_UserActionsProcess? CPE_UserActionsProcess { get; set; }
        [Description("کاربر")]
        public virtual S_User? CPE_User { get; set; }

        #endregion
    }
}
