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

        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idPosition { get; set; }
        public int finalEnt { get; set; }
        public long baCreatedTime { get; set; }
        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion

        #region Simple Prop
        [StringLength(26)]
        public string posName { get; set; }

        [StringLength(40)]
        public string posDisplayName { get; set; }

        [StringLength(100)]
        public string posDescription { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? costPosition { get; set; }

        [StringLength(150)]
        public string ancestorPath { get; set; }

        #endregion

        #region Relation

        #region Entity
        public int? idParentPosition { get; set; }
        public int idOrg { get; set; }
        public virtual ORGPOSITION ORGPOSITION2 { get; set; } 
        #endregion

        #region Collection
        public virtual ICollection<ORGPOSITION> ORGPOSITION1 { get; set; }  
        #endregion

        #endregion

    }
}
