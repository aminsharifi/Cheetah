namespace Cheetah_DataAccess.BPMS
{
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Location
    {
        #region Common Prop
        [Key]
        public long IdRecord { get; set; }
        public long TimeRecord { get; set; } = DateTime.Now.Ticks;
        public Guid GuidRecord { get; set; } = Guid.NewGuid();
        public bool DsblRecord { get; set; } = false;
        #endregion

        #region Simple Prop

        [Required]
        [StringLength(26)]
        public string LOC_Name { get; set; }

        [StringLength(40)]
        public string? LOC_DisplayName { get; set; }

        [StringLength(100)]
        public string? LOC_Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? LOC_Cost { get; set; }

        [StringLength(150)]
        public string? LOC_AncestorPath { get; set; }
        #endregion

        #region Relations
        #region Entity

        #region LOC_idParentLocation
        public long? LOC_idParentLocation { get; set; }
        [ForeignKey("LOC_idParentLocation")]
        public virtual Location? LOC_ParentLocation { get; set; }
        #endregion

        public long? LOC_idWorkingTimeSchema { get; set; }
        public long? LOC_idOrg { get; set; }
        public long? LOC_idTimeZone { get; set; }

        #endregion

        #region Collections
        public virtual ICollection<Location>? LOC_ChildLOCATION { get; set; }
        #endregion
        #endregion
    }
}
