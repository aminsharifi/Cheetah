namespace Cheetah_DataAccess.BPMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class OrgPosition
    {
        #region Common Prop
        [Key]
        public long IdRecord { get; set; }
        public long TimeRecord { get; set; } = DateTime.Now.Ticks;
        public Guid GuidRecord { get; set; } = Guid.NewGuid();
        public bool DsblRecord { get; set; } = false;
        #endregion

        #region Simple Prop
        [StringLength(26)]
        public string? POS_Name { get; set; }

        [StringLength(40)]
        public string? POS_DisplayName { get; set; }

        [StringLength(100)]
        public string? POS_Description { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? POS_cost { get; set; }

        [StringLength(150)]
        public string? POS_ancestorPath { get; set; }

        #endregion

        #region Relation

        #region Entity
        public long? POS_idOrg { get; set; }

        #region POS_ParentPosition
        public long? POS_idParentPosition { get; set; }
        [ForeignKey("POS_idParentPosition")]
        public virtual OrgPosition? POS_ParentPosition { get; set; }
        #endregion

        #endregion

        #region Collection
        public virtual ICollection<OrgPosition>? ORGPOPOS_ChildPosition { get; set; }
        #endregion

        #endregion

    }
}
