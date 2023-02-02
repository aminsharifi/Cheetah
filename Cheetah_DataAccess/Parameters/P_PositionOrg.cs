namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Systems;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("P_PositionOrg", Schema = "Parameters")]
    public partial class P_PositionOrg : BasePSClass
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
        public virtual S_Role? PSO_Role { get; set; }

        [Description("نقش جایگزین")]
        public virtual S_Role? PSO_Role2 { get; set; }


        #endregion

        #endregion
    }
}
