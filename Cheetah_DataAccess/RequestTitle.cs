namespace CheetahClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class RequestTitle
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RequestTitle()
        {
            ProcessEndorsements = new HashSet<ProcessEndorsement>();
            SubRequestTitles = new HashSet<SubRequestTitle>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idRequestTitles { get; set; }

        public int? finalEnt { get; set; }

        public Guid guidRequestTitles { get; set; }

        public bool dsblRequestTitles { get; set; }

        public byte dplyRequestTitles { get; set; }

        [StringLength(50)]
        public string RequestTitles_Name { get; set; }

        public bool? RequestTitles_ShowSupport { get; set; }

        [StringLength(50)]
        public string RequestTitles_ProcessName { get; set; }

        public int? RequestTitles_Code { get; set; }

        [StringLength(50)]
        public string RT_ConditionOccur { get; set; }

        [StringLength(50)]
        public string RT_ConditionOccur2 { get; set; }

        public bool? CheckList { get; set; }

        public bool? ERP { get; set; }

        public bool? RT_AnotherRequester { get; set; }

        [StringLength(50)]
        public string RT_ConditionOccur3 { get; set; }

        [StringLength(50)]
        public string RT_ConditionOccur4 { get; set; }

        [StringLength(50)]
        public string RT_ConditionOccur5 { get; set; }

        [StringLength(50)]
        public string RT_OutputVar1 { get; set; }

        [StringLength(50)]
        public string RT_OutputVar2 { get; set; }

        [StringLength(50)]
        public string RT_OutputVar3 { get; set; }

        [StringLength(50)]
        public string RT_OutputVar4 { get; set; }

        [StringLength(50)]
        public string RT_OutputVar5 { get; set; }

        public bool? RT_RemoveRequestorApproval { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessEndorsement> ProcessEndorsements { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubRequestTitle> SubRequestTitles { get; set; }
    }
}
