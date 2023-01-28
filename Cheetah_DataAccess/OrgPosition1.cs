namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("OrgPositions")]
    public partial class OrgPosition1
    {

        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idOrgPositions { get; set; }
        public int finalEnt { get; set; }
        public long baCreatedTime { get; set; }
        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion

        #region Basic Prop

        [Description("کد سمت")]
        public short? OrgPositions_Code { get; set; }

        [StringLength(50)]
        [Description("نام سمت")]
        public string OrgPositions_Name { get; set; }

        [StringLength(50)]
        [Description("ایفاکننده")]
        public string OrgPositions_User { get; set; }

        [Description("سطح ستاد")]
        public bool? OrgPositions_Group { get; set; }

        [StringLength(50)]
        [Description("نقش FMCG")]
        public string OP_FMCGRole { get; set; }

        [StringLength(50)]
        [Description("نقش دارویی")]
        public string OP_MedicineRole { get; set; }
        #endregion


        #region Relation
        [Description("نقش")]
        public virtual ROLE OrgPositions_Role { get; set; }

        [Description("نقش جایگزین")]
        public virtual ROLE OrgPositions_Role2 { get; set; }
        #endregion
    }
}
