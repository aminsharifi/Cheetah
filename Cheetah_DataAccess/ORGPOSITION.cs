namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ORGPOSITION")]
    public partial class ORGPOSITION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ORGPOSITION()
        {
            ORGPOSITION1 = new HashSet<ORGPOSITION>();
        }

        [Key]
        public int idPosition { get; set; }

        [StringLength(26)]
        public string posName { get; set; }

        public int? idParentPosition { get; set; }

        public Guid guidPosition { get; set; }

        [StringLength(40)]
        public string posDisplayName { get; set; }

        [StringLength(100)]
        public string posDescription { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? costPosition { get; set; }

        [StringLength(150)]
        public string ancestorPath { get; set; }

        public byte dplyPosition { get; set; }

        public int idOrg { get; set; }

        public int finalEnt { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ORGPOSITION> ORGPOSITION1 { get; set; }

        public virtual ORGPOSITION ORGPOSITION2 { get; set; }
    }
}
