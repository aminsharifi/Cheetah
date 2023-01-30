namespace Cheetah_DataAccess.Systems
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("OrgPosition")]
    public partial class S_OrgPosition
    {
        #region Simple Prop
        [StringLength(26)]
        [Required]
        public string POS_Name { get; set; }

        [StringLength(40)]
        [Required]
        public string POS_DisplayName { get; set; }

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
        public virtual S_OrgPosition? POS_ParentPosition { get; set; }
        #endregion

        #endregion

        #region Collection
        public virtual ICollection<S_OrgPosition>? ORGPOPOS_ChildPosition { get; set; }
        #endregion

        #endregion

    }
}
