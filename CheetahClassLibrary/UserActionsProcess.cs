namespace CheetahClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserActionsProcess")]
    public partial class UserActionsProcess
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserActionsProcess()
        {
            CurrentProcessEndorsemen1 = new HashSet<CurrentProcessEndorseman>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idUserActionsProcess { get; set; }

        public int? finalEnt { get; set; }

        public long? CurrentProcessEndorsemen { get; set; }

        public int? RequestTitles_Code { get; set; }

        public bool? Automation { get; set; }

        [StringLength(50)]
        public string sender_input { get; set; }

        [StringLength(50)]
        public string Receiver_input { get; set; }

        [StringLength(255)]
        public string Subject_input { get; set; }

        [StringLength(2048)]
        public string TextBody_input { get; set; }

        [StringLength(215)]
        public string IdentificationCode_input { get; set; }

        public bool? SendLetterResponse { get; set; }

        public bool? SendERP { get; set; }

        public long? RequestInformation { get; set; }

        public bool? SendNotifyERP { get; set; }

        public DateTime? CreateDate { get; set; }

        public bool? SMS { get; set; }

        public long baCreatedTime { get; set; }

        public Guid baGuid { get; set; }

        public long? SupplierDocPrintDtl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CurrentProcessEndorseman> CurrentProcessEndorsemen1 { get; set; }

        public virtual RequestInformation RequestInformation1 { get; set; }
    }
}
