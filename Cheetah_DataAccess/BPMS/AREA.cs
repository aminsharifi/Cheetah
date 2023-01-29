namespace Cheetah_DataAccess.BPMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public partial class Area
    {
        //Passed
        #region Common Prop
        [Key]
        public long IdRecord { get; set; }
        public long TimeRecord { get; set; } = DateTime.Now.Ticks;
        public Guid GuidRecord { get; set; } = Guid.NewGuid();
        public bool DsblRecord { get; set; } = false;
        #endregion

        #region Basic Prop
        [Required]
        [StringLength(26)]
        public string Area_Name { get; set; }

        [Required]
        [StringLength(40)]
        public string Area_DisplayName { get; set; }

        [StringLength(100)]
        public string? Area_Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Area_CostArea { get; set; }
        #endregion

        #region Relations

        #endregion
    }
}
