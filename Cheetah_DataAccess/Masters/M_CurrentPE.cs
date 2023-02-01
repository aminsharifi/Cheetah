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

    [Table("M_CurrentPE")]
    [Description("CurrentProcessEndorsements")]
    public partial class M_CurrentPE : BaseClass
    {
        //Passed

        #region Simple Prop

        #endregion

        #region Collection

        #region CPE_ProcessEndorsements
        [Description("تایید کننده")]
        public long? CPE_idProcessEndorsements { get; set; }
        [ForeignKey("CPE_idProcessEndorsements")]
        public virtual P_ProcessEndorsement? CPE_ProcessEndorsements { get; set; }
        #endregion

        #region CPE_RequestInformation
        public long? CPE_idRequestInformation { get; set; }
        [ForeignKey("CPE_idRequestInformation")]
        public virtual M_RequestInformation? CPE_RequestInformation { get; set; }
        #endregion

        #region CPE_UserAction
        [Description("اقدام کاربر")]
        public long? CPE_idUserAction { get; set; }
        [ForeignKey("CPE_idUserAction")]
        public virtual P_UserAction? CPE_UserAction { get; set; }
        #endregion

        #region CPE_UserActionsProcess
        public long? CPE_idUserActionsProcess { get; set; }
        [ForeignKey("CPE_idUserActionsProcess")]
        public virtual M_UserActionsProcess? CPE_UserActionsProcess { get; set; }
        #endregion

        #region CPE_User
        [Description("کاربر")]
        public double? CPE_idUser { get; set; }
        [ForeignKey("CPE_idUser")]
        public virtual S_User? CPE_User { get; set; }
        #endregion

        #endregion
    }
}
