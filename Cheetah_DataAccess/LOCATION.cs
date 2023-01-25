namespace CheetahClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("LOCATION")]
    public partial class LOCATION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOCATION()
        {
            LOCATION1 = new HashSet<LOCATION>();
            WFUSERs = new HashSet<WFUSER>();
        }

        [Key]
        public int idLocation { get; set; }

        [Required]
        [StringLength(26)]
        public string locName { get; set; }

        public int? idParentLocation { get; set; }

        public Guid guidLocation { get; set; }

        [StringLength(40)]
        public string locDisplayName { get; set; }

        [StringLength(100)]
        public string locDescription { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? costLocation { get; set; }

        [StringLength(150)]
        public string ancestorPath { get; set; }

        public byte dplyLocation { get; set; }

        public int? idWorkingTimeSchema { get; set; }

        public int idOrg { get; set; }

        public int? idTimeZone { get; set; }

        public int finalEnt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOCATION> LOCATION1 { get; set; }

        public virtual LOCATION LOCATION2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFUSER> WFUSERs { get; set; }
    }
}
