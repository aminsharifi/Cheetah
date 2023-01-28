namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
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
        public short? OrgPositions_Code { get; set; }

        [StringLength(50)]
        public string OrgPositions_Name { get; set; }

        [StringLength(50)]
        public string OrgPositions_User { get; set; }

        public int? OrgPositions_Role { get; set; }

        public bool? OrgPositions_Group { get; set; }

        public int? OrgPositions_Role2 { get; set; }

        [StringLength(50)]
        public string OP_FMCGRole { get; set; }

        [StringLength(50)]
        public string OP_MedicineRole { get; set; }
        #endregion

        #region Relation
        public virtual ROLE ROLE { get; set; }

        public virtual ROLE ROLE1 { get; set; }
        #endregion
    }
}
