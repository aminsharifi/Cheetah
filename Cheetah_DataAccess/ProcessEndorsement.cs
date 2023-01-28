namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ProcessEndorsement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProcessEndorsement()
        {
            CurrentProcessEndorsemen = new HashSet<CurrentProcessEndorseman>();
        }

        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idProcessEndorsements { get; set; }
        public int finalEnt { get; set; }
        public long baCreatedTime { get; set; }
        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion

        #region Simple Prop
        public byte? PE_ApproveOrder { get; set; }

        public int? PE_Code { get; set; }

        public int? PE_ExpertUser { get; set; }

        public bool? PE_Conditional { get; set; }

        public bool? PE_Mail { get; set; }

        public bool? PE_Automation { get; set; }

        public bool? PE_SMS { get; set; }

        public bool? PE_Transcript { get; set; }

        public bool? PE_Conditional2 { get; set; }

        [StringLength(50)]
        public string PE_TaskName { get; set; }

        [StringLength(50)]
        public string PE_ValidUserAction { get; set; }

        public bool? PE_Active { get; set; }

        [StringLength(50)]
        public string PE_SubRequestTitles { get; set; }

        public bool? PE_Conditional3 { get; set; }

        public bool? PE_Conditional4 { get; set; }

        public bool? PE_Conditional5 { get; set; }

        [StringLength(50)]
        public string PE_Code_STR { get; set; }

        public bool? RT_ConditionDrug { get; set; }

        public bool? RT_ConditionFMCG { get; set; }

        [StringLength(50)]
        public string PE_ValidOutput { get; set; }

        public bool? RT_SendAll { get; set; }

        public bool? RT_SupplierSHare { get; set; }

        public bool? RT_AlborzSHare { get; set; }

        [StringLength(50)]
        public string PE_UserRelationship { get; set; } 
        #endregion

        #region Relation
        #region Entity
        public long? PE_OrgPositions { get; set; }
        public long? PE_ProcessState { get; set; }
        public virtual RequestTitle RequestTitle { get; set; }
        public virtual RI_ProcessState RI_ProcessState { get; set; }
        public long? PE_RequestTitles { get; set; }
        #endregion

        #region Collection
        public virtual ICollection<CurrentProcessEndorseman> CurrentProcessEndorsemen { get; set; }
        #endregion 
        #endregion

    }
}
