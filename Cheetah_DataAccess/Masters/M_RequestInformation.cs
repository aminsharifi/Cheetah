namespace Cheetah_DataAccess.Masters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Cheetah_DataAccess.Systems;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("M_RequestInformation")]
    public partial class M_RequestInformation : BaseClass
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

        #region ConditionOccur
        public bool? RI_ConditionOccur1 { get; set; }
        public bool? RI_ConditionOccur2 { get; set; }
        public bool? RI_ConditionOccur3 { get; set; }
        public bool? RI_ConditionOccur4 { get; set; }
        public bool? RI_ConditionOccur5 { get; set; }
        public bool? RI_ConditionDrug { get; set; }
        public bool? RI_ConditionFMCG { get; set; }
        public bool? RI_SupplierSHare { get; set; }
        public bool? RI_AlborzSHare { get; set; }
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
        public string RI_Inputuser1 { get; set; }
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

        #region Others

        public bool? RI_IsCancelled { get; set; } = false;
        public bool? IsTest { get; set; } = false;
        public long? RI_RequestID { get; set; }

        [StringLength(50)]
        public string? RI_RequestNumber { get; set; }

        [StringLength(100)]
        public string? IdWorkItem { get; set; }

        [StringLength(255)]
        public string? RI_Address { get; set; }

        [StringLength(50)]
        public string? RI_LastUserComment { get; set; }
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

        [StringLength(512)]
        public string? RI_UserComment { get; set; }
        public DateTime? RI_LastTaskSentDate { get; set; }

        [StringLength(50)]
        public string? RI_People { get; set; }

        [StringLength(2000)]
        public string? RI_CurrentUserNames { get; set; }


        #endregion

        #endregion

        #region Relations
        #region Entity
        public long? RI_idUnitType { get; set; }
        public long? RI_Person { get; set; }
        public long? RI_RejectReason { get; set; }

        #region WFUsers

        #region RI_ExpertUser
        public long? RI_idExpertUser { get; set; }
        [ForeignKey("RI_idExpertUser")]
        public S_User? RI_ExpertUser { get; set; }
        #endregion

        #region RI_LastUserInCharge
        public long? RI_idLastUserInCharge { get; set; }
        [ForeignKey("RI_idLastUserInCharge")]
        public S_User? RI_LastUserInCharge { get; set; }
        #endregion

        #region RI_Requestor
        public long? RI_idRequestor { get; set; }
        [ForeignKey("RI_idRequestor")]
        public S_User? RI_Requestor { get; set; }
        #endregion

        #region RI_Creator
        public long? RI_idCreator { get; set; }
        [ForeignKey("RI_idCreator")]
        public S_User? RI_Creator { get; set; }
        #endregion

        #endregion

        #region RI_Location
        public long? RI_idLocation { get; set; }
        [ForeignKey("RI_idLocation")]
        public S_Location? RI_Location { get; set; }
        #endregion

        #region RI_idRequestType
        public long? RI_idRequestType { get; set; }
        [ForeignKey("RI_idRequestType")]
        public P_RequestType? RI_RequestType { get; set; }
        #endregion

        #region RI_RequestTitle
        public long? RI_idRequestTitle { get; set; }
        [ForeignKey("RI_idRequestTitle")]
        public P_RequestTitle? RI_RequestTitle { get; set; }
        #endregion

        #region RI_SubRequestTitle
        public long? RI_idSubRequestTitle { get; set; }
        [ForeignKey("RI_idSubRequestTitle")]
        public P_SubRequestTitle? RI_SubRequestTitle { get; set; }
        #endregion

        #region RI_ActiveProcessEndorsement
        [Description("RI_ActiveidProcessEndorsement")]
        public long? RI_ActiveidProcessEndorsement { get; set; }
        [ForeignKey("RI_ActiveidProcessEndorsement")]
        public P_ProcessEndorsement? RI_ActiveProcessEndorsement { get; set; }
        #endregion

        #region RI_Area
        public long? RI_idArea { get; set; }
        [ForeignKey("RI_idArea")]
        public S_Area? RI_Area { get; set; }
        #endregion

        #region RI_UserAction
        public long? RI_idUserAction { get; set; }
        [ForeignKey("RI_idUserAction")]
        public P_UserAction? RI_UserAction { get; set; }
        #endregion

        #region RI_LastUserAction
        public long? RI_idLastUserAction { get; set; }
        [ForeignKey("RI_idLastUserAction")]
        public P_UserAction? RI_LastUserAction { get; set; }
        #endregion

        #region RI_ProcessState
        public long? RI_idProcessState { get; set; }
        [ForeignKey("RI_idProcessState")]
        public P_ProcessState? RI_ProcessState { get; set; }
        #endregion

        #endregion
        #region Collection
        public virtual ICollection<M_Approve>? RI_Approves { get; set; }
        public virtual ICollection<M_CallWebService>? RI_CallWebServices { get; set; }
        public virtual ICollection<M_UserActionsProcess>? RI_UserActionsProcesses { get; set; }
        #endregion
        #endregion
    }
}
