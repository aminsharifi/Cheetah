namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Systems;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("P_PositionOrganization")]
    public partial class P_PositionOrganization : BasePSClass
    {
        #region Basic Prop
        [StringLength(50)]
        [Description("ایفاکننده")]
        public string? PSO_User { get; set; }

        [Description("سطح ستاد")]
        public bool? PSO_Group { get; set; }

        [StringLength(50)]
        [Description("نقش FMCG")]
        public string? PSO_FMCGRole { get; set; }

        [StringLength(50)]
        [Description("نقش دارویی")]
        public string? PSO_MedicineRole { get; set; }
        #endregion


        #region Relation

        #region PSO_Role
        [Description("نقش")]
        public long? PSO_idRole { get; set; }
        [ForeignKey("PSO_idRole")]
        public virtual S_Role? PSO_Role { get; set; }
        #endregion

        #region PSO_Role2
        [Description("نقش جایگزین")]
        public long? PSO_idRole2 { get; set; }
        [ForeignKey("PSO_idRole2")]
        public virtual S_Role? PSO_Role2 { get; set; } 
        #endregion

        #endregion
    }
}
