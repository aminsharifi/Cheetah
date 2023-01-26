namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ParameterList")]
    public partial class ParameterList
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idParameterList { get; set; }

        public int? finalEnt { get; set; }

        public Guid guidParameterList { get; set; }

        public bool dsblParameterList { get; set; }

        public byte dplyParameterList { get; set; }

        [StringLength(500)]
        public string Name { get; set; }

        public int? Code { get; set; }

        public long? ParameterType { get; set; }

        public long? PValue { get; set; }

        [StringLength(50)]
        public string CodeStr { get; set; }

        public int? Ordering { get; set; }

        [Column(TypeName = "ntext")]
        public string Dsc { get; set; }

        public virtual ParameterType ParameterType1 { get; set; }
    }
}
