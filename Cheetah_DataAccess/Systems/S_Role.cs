namespace Cheetah_DataAccess.Systems
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Role")]
    public partial class S_Role
    {
        #region Simple Prob
        [Required]
        [StringLength(26)]
        public string Role_Name { get; set; }

        [StringLength(40)]
        public string Role_DisplayName { get; set; }

        [StringLength(100)]
        public string Role_Description { get; set; }
        #endregion

        #region Collection
        public virtual ICollection<S_OrgPosition> Role_OrgPosition { get; set; }
        #endregion
    }
}
