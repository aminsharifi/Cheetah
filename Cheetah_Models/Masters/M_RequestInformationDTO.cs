namespace Cheetah_Models.Masters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Masters;
    using Cheetah_DataAccess.Parameters;
    using Cheetah_DataAccess.Systems;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class M_RequestInformationDTO : BasePSClass
    {
        #region Simple Prob

        #region WSResults
        public bool? RI_WS_Result { get; set; }
        [StringLength(1024)]
        public string? RI_WS_Result_Desc { get; set; }
        public int? RI_WS_TryNum { get; set; }
        public int? RI_WS_Result_Code { get; set; }
        public long? RI_WS_CurrentId { get; set; }
        #endregion

        #region DateTimes
        public DateTime? RI_RequestDate { get; set; } = DateTime.Now;
        public DateTime? RI_RequestFinishDate { get; set; }
        public DateTime? RI_OldDate { get; set; }
        public DateTime? RI_NewDate { get; set; }
        public DateTime? RI_LastTimeModify { get; set; }
        #endregion

        #region ProcessVar

        [StringLength(1024)]
        public string? RI_ProcessVar1 { get; set; }

        [StringLength(1024)]
        public string? RI_ProcessVar2 { get; set; }

        [StringLength(1024)]
        public string? RI_ProcessVar3 { get; set; }

        [StringLength(1024)]
        public string? RI_ProcessVar4 { get; set; }

        [StringLength(1024)]
        public string? RI_ProcessVar5 { get; set; }

        #endregion

        #region RI_Inputuser
        [StringLength(50)]
        public string? RI_Inputuser1 { get; set; }
        #endregion

        #region RI_OutputVar
        [StringLength(50)]
        public string? RI_OutputVar1 { get; set; }

        [StringLength(50)]
        public string? RI_OutputVar2 { get; set; }

        [StringLength(50)]
        public string? RI_OutputVar3 { get; set; }

        [StringLength(50)]
        public string? RI_OutputVar4 { get; set; }

        [StringLength(2500)]
        public string? RI_OutputVar5 { get; set; }
        #endregion

        #region ERP
        public long? RI_ERPID { get; set; }
        [StringLength(50)]
        public string? RI_ERPKindID { get; set; }
        [StringLength(50)]
        public string? RI_ERPBranchs { get; set; }
        #endregion

        public bool? RI_IsCancelled { get; set; } = false;
        public bool? IsTest { get; set; } = false;
        public long? RI_RequestID { get; set; }

        [StringLength(50)]
        public string? RI_RequestNumber { get; set; }

        [StringLength(100)]
        public string? IdWorkItem { get; set; }

        [StringLength(255)]
        public string? RI_Address { get; set; }

        public byte? RI_PE_Level { get; set; }
        public byte? RI_Attachment { get; set; }

        [StringLength(500)]
        public string? RI_RequestSubject { get; set; }

        [StringLength(50)]
        public string? RI_TaskName { get; set; }

        [StringLength(50)]
        public string? RI_UserNameCreator { get; set; }

        [StringLength(50)]
        public string? RI_ValidUserAction { get; set; }

        [StringLength(50)]
        public string? RI_People { get; set; }

        [StringLength(2000)]
        public string? RI_CurrentUserNames { get; set; }

        #region S_User
        public virtual S_User? RI_Person { get; set; }
        public virtual S_User? RI_ExpertUser { get; set; }
        public virtual S_User? RI_Requestor { get; set; }
        public virtual S_User? RI_Creator { get; set; }
        public virtual M_AllApprove? RI_AllApprove { get; set; }
        #endregion

        [Description("وضعیت فرآیند")]
        public virtual P_ProcessState? RI_ProcessState { get; set; }

        [Description("نوع درخواست")]
        public virtual P_RequestType? RI_RequestType { get; set; }

        [Description("نام فرآیند")]
        public virtual P_RequestTitle? RI_RequestTitle { get; set; }

        [Description("زیرفرآیند")]
        public virtual P_SubRequestTitle? RI_SubRequestTitle { get; set; }

        [Description("وضعیت تایید فعال")]
        public virtual M_CurrentPE? RI_M_CurrentPE { get; set; }
        //public virtual P_ProcessEndorsement? RI_ActiveProcessEndorsement { get; set; }

        [Description("تاریخچه نظرات کاربران")]
        public virtual ICollection<M_Approve>? RI_Approves { get; set; }
        public virtual ICollection<M_CallWebService>? RI_CallWebServices { get; set; }
        public virtual ICollection<M_UserActionsProcess>? RI_UserActionsProcesses { get; set; }
        public virtual ICollection<M_CurrentPE>? RI_M_CurrentPEs { get; set; }

        #endregion
    }
}
