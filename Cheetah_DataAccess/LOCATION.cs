namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("LOCATION")]
    public partial class LOCATION
    {     
        public LOCATION()
        {
            LOCATION1 = new HashSet<LOCATION>();
            WFUSERs = new HashSet<WFUSER>();
        }

        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idLocation { get; set; }
        public int finalEnt { get; set; }
        public long baCreatedTime { get; set; }
        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion

        #region Simple Prop

        [Required]
        [StringLength(26)]
        public string locName { get; set; }

        [StringLength(40)]
        public string locDisplayName { get; set; }

        [StringLength(100)]
        public string locDescription { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? costLocation { get; set; }

        [StringLength(150)]
        public string ancestorPath { get; set; } 
        #endregion

        #region Relations
        #region Entity
        public int? idParentLocation { get; set; }
        public int? idWorkingTimeSchema { get; set; }
        public int idOrg { get; set; }
        public int? idTimeZone { get; set; }
        public virtual LOCATION LOCATION2 { get; set; } 
        #endregion

        #region Collections
        public virtual ICollection<LOCATION> LOCATION1 { get; set; }
        public virtual ICollection<WFUSER> WFUSERs { get; set; }  
        #endregion
        #endregion
    }
}
