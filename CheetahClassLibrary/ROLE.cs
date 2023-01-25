namespace CheetahClassLibrary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ROLE")]
    public partial class ROLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ROLE()
        {
            OrgPositions = new HashSet<OrgPosition1>();
            OrgPositions1 = new HashSet<OrgPosition1>();
        }

        [Key]
        public int idRole { get; set; }

        [Required]
        [StringLength(26)]
        public string roleName { get; set; }

        public Guid guidRole { get; set; }

        [StringLength(40)]
        public string roleDisplayName { get; set; }

        [StringLength(100)]
        public string roleDescription { get; set; }

        public byte dplyRole { get; set; }

        public int finalEnt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrgPosition1> OrgPositions { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrgPosition1> OrgPositions1 { get; set; }
    }
}
