namespace Cheetah_DataAccess.BPMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Role
    {
        public Role()
        {
            OrgPositions = new HashSet<OrgPosition>();
            OrgPositions1 = new HashSet<OrgPosition>();
        }

        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idRole { get; set; }
        public int finalEnt { get; set; }
        public long baCreatedTime { get; set; }
        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion

        #region Simple Prob
        [Required]
        [StringLength(26)]
        public string roleName { get; set; }

        [StringLength(40)]
        public string roleDisplayName { get; set; }

        [StringLength(100)]
        public string roleDescription { get; set; }
        #endregion

        #region Collection
        public virtual ICollection<OrgPosition> OrgPositions { get; set; }
        public virtual ICollection<OrgPosition> OrgPositions1 { get; set; }
        #endregion
    }
}
