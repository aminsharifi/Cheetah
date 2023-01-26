namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class RI_ProcessState
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RI_ProcessState()
        {
            ProcessEndorsements = new HashSet<ProcessEndorsement>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idRI_ProcessState { get; set; }

        public int? finalEnt { get; set; }

        public Guid guidRI_ProcessState { get; set; }

        public bool dsblRI_ProcessState { get; set; }

        public byte dplyRI_ProcessState { get; set; }

        public int? PS_Code { get; set; }

        [StringLength(50)]
        public string PS_Name { get; set; }

        public int? PS_ERP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcessEndorsement> ProcessEndorsements { get; set; }
    }
}
