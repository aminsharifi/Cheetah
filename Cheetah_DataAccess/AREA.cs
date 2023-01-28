namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("AREA")]
    public partial class AREA
    {
        public AREA()
        {
            WFUSERs = new HashSet<WFUSER>();
        }

        #region Common Prop
        [Key]
        public int idArea { get; set; }
        public Guid guidArea { get; set; }
        public byte dplyArea { get; set; }
        public int finalEnt { get; set; }
        public bool dsblRecord { get; set; }
        #endregion

        #region Basic Prop
        [Required]
        [StringLength(26)]
        public string areaName { get; set; }

        [StringLength(40)]
        public string areaDisplayName { get; set; }

        [StringLength(100)]
        public string areaDescription { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? costArea { get; set; }
        #endregion

        #region Relations
        public virtual ICollection<WFUSER> WFUSERs { get; set; } 
        #endregion
    }
}
