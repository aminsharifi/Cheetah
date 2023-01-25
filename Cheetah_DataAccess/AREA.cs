namespace CheetahClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("AREA")]
    public partial class AREA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AREA()
        {
            WFUSERs = new HashSet<WFUSER>();
        }

        [Key]
        public int idArea { get; set; }

        [Required]
        [StringLength(26)]
        public string areaName { get; set; }

        public Guid guidArea { get; set; }

        [StringLength(40)]
        public string areaDisplayName { get; set; }

        [StringLength(100)]
        public string areaDescription { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? costArea { get; set; }

        public byte dplyArea { get; set; }

        public int finalEnt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFUSER> WFUSERs { get; set; }
    }
}
