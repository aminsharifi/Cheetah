namespace Cheetah_DataAccess.Gizelle
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Cheetah_DataAccess.BPMS;

    public partial class CurrentProcessEndorseman
    {
        //Passed
        #region Common Prop
        [Key]
        public long IdRecord { get; set; }
        public long TimeRecord { get; set; } = DateTime.Now.Ticks;
        public Guid GuidRecord { get; set; } = Guid.NewGuid();
        public bool DsblRecord { get; set; } = false;
        #endregion

        #region Simple Prop
        public bool CUE_Active { get; set; } = true;
        #endregion

        #region Collection

        #region CUE_ProcessEndorsements
        [Description("تایید کننده")]
        public long? CUE_idProcessEndorsements { get; set; }
        [ForeignKey("CUE_idProcessEndorsements")]
        public virtual ProcessEndorsement? CUE_ProcessEndorsements { get; set; }
        #endregion


        #region CUE_RequestInformation
        public long? CUE_idRequestInformation { get; set; }
        [ForeignKey("CUE_idRequestInformation")]
        public virtual RequestInformation? CUE_RequestInformation { get; set; }
        #endregion

        #region CUE_UserAction
        [Description("اقدام کاربر")]
        public long? CUE_idUserAction { get; set; }
        [ForeignKey("CUE_idUserAction")]
        public virtual UserAction? CUE_UserAction { get; set; }
        #endregion

        #region CUE_UserActionsProcess
        public long? CUE_idUserActionsProcess { get; set; }
        [ForeignKey("CUE_idUserActionsProcess")]
        public virtual UserActionsProcess? CUE_UserActionsProcess { get; set; }
        #endregion

        #region CUE_User
        [Description("کاربر")]
        public double? CUE_idUser { get; set; }
        [ForeignKey("CUE_idUser")]
        public virtual WFUser? CUE_User { get; set; }
        #endregion

        #endregion
    }
}
