namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ParameterType")]
    public partial class ParameterType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ParameterType()
        {
            ParameterLists = new HashSet<ParameterList>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idParameterType { get; set; }

        public int? finalEnt { get; set; }

        public Guid guidParameterType { get; set; }

        public bool dsblParameterType { get; set; }

        public byte dplyParameterType { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int? Code { get; set; }

        [Column(TypeName = "ntext")]
        public string Dsc { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParameterList> ParameterLists { get; set; }
    }
}
