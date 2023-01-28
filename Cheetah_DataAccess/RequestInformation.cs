namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("RequestInformation")]
    public partial class RequestInformation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RequestInformation()
        {
            Approves = new HashSet<Approve>();
            CallWebServices = new HashSet<CallWebService>();
            UserActionsProcesses = new HashSet<UserActionsProcess>();
        }

        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idRequestInformation { get; set; }
        public int finalEnt { get; set; }
        public long baCreatedTime { get; set; }
        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion


        #region Simple Prob
        public bool? RI_IsCancelled { get; set; }
        public DateTime? RI_RequestDate { get; set; }
        public DateTime? RI_RequestFinishDate { get; set; }
        public long? RI_RequestID { get; set; }
        [StringLength(50)]
        public string RI_RequestNumber { get; set; }

        [StringLength(512)]
        public string RI_UserComment { get; set; }
        [StringLength(255)]
        public string RI_Address { get; set; }
        [StringLength(50)]
        public string RI_LastUserComment { get; set; }
       
        public byte? RI_PE_Level { get; set; }
        public byte? RI_Attachment { get; set; }
   
        public bool? RI_ConditionOccur { get; set; }

        public long? ERPID { get; set; }

        public bool? IsTest { get; set; }

        public bool? RI_ConditionOccur2 { get; set; }
        [StringLength(500)]
        public string RI_RequestSubject { get; set; }

        [StringLength(50)]
        public string RI_TaskName { get; set; }

        [StringLength(50)]
        public string RI_UserNameCreator { get; set; }
        [StringLength(50)]
        public string RI_ValidUserAction { get; set; }

        public bool? WSResult { get; set; }

        public DateTime? RI_OldDate { get; set; }

        public DateTime? RI_NewDate { get; set; }

        public bool? RI_ConditionOccur3 { get; set; }

        public bool? RI_ConditionOccur4 { get; set; }

        public bool? RI_ConditionOccur5 { get; set; }

        [StringLength(1024)]
        public string RI_ProcessVar1 { get; set; }

        [StringLength(1024)]
        public string RI_ProcessVar2 { get; set; }

        [StringLength(1024)]
        public string RI_ProcessVar3 { get; set; }

        [StringLength(1024)]
        public string RI_ProcessVar4 { get; set; }

        [StringLength(1024)]
        public string RI_ProcessVar5 { get; set; }

        [StringLength(1024)]
        public string WSResult_Desc { get; set; }

        [StringLength(50)]
        public string RI_People { get; set; }

        [StringLength(512)]
        public string RI_UserComment2 { get; set; }

        [StringLength(50)]
        public string RI_OutputVar1 { get; set; }

        [StringLength(50)]
        public string RI_OutputVar2 { get; set; }

        [StringLength(50)]
        public string RI_OutputVar3 { get; set; }

        [StringLength(50)]
        public string RI_OutputVar4 { get; set; }

        [StringLength(2500)]
        public string RI_OutputVar5 { get; set; }

        [StringLength(250)]
        public string RI_UserComment3 { get; set; }

        [StringLength(50)]
        public string RI_ERPBranchs { get; set; }

        [StringLength(50)]
        public string RI_ERPKindID { get; set; }

        public bool? RT_ConditionDrug { get; set; }

        public bool? RT_ConditionFMCG { get; set; }
        public bool? RT_SupplierSHare { get; set; }

        public bool? RT_AlborzSHare { get; set; }

        [StringLength(50)]
        public string RI_Inputuser1 { get; set; }

        [StringLength(2000)]
        public string RI_CurrentUserNames { get; set; }

        public DateTime? RI_LastTaskSentDate { get; set; }

        [StringLength(100)]
        public string IdWorkItem { get; set; }

        [StringLength(50)]
        public string RI_PERequestDate { get; set; }
        public int? WS_TryNum { get; set; }
        public DateTime? LastTimeModify { get; set; }
        #endregion


        #region Relations
        #region Entity
        public int? RI_ExpertUser { get; set; }
        public int? RI_LastUserInCharge { get; set; }
        public int? RI_Requestor { get; set; }
        public int? RI_Creator { get; set; }
        public int? RI_Location { get; set; }
        public long? RI_UnitType { get; set; }
        public long? RI_RequestType { get; set; }
        public long? RI_SubRequestTitles { get; set; }
        public long? RI_ActiveProcessEndorseme { get; set; }
        public int? WSResult_Code { get; set; }
        public long? RI_Person { get; set; }
        public long? RI_CustomerView { get; set; }
        public int? Deploymentexpert { get; set; }
        public long? WS_CurrentId { get; set; }
        public long? RI_RejectReason { get; set; }
        public long? RI_AttendanceInfo { get; set; }
        public int? RI_Area { get; set; }
        public long? RI_RequestTitle { get; set; }
        public long? RI_UserAction { get; set; }
        public long? RI_ProcessState { get; set; }
        public long? RI_LastUserAction { get; set; }
        #endregion
        #region Collection
        public virtual ICollection<Approve> Approves { get; set; }
        public virtual ICollection<CallWebService> CallWebServices { get; set; }
        public virtual CurrentProcessEndorseman CurrentProcessEndorseman { get; set; }
        public virtual ICollection<UserActionsProcess> UserActionsProcesses { get; set; }
        #endregion 
        #endregion

    }
}
