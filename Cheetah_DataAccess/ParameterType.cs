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

        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idParameterType { get; set; }
        public int finalEnt { get; set; }
        public long baCreatedTime { get; set; }
        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion

        #region Simple Prob
        [StringLength(100)]
        public string Name { get; set; }

        public int? Code { get; set; }

        [Column(TypeName = "ntext")]
        public string Dsc { get; set; } 
        #endregion

        #region Relation
        public virtual ICollection<ParameterList> ParameterLists { get; set; } 
        #endregion
    }
}
