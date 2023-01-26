namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("OrgPositions")]
    public partial class OrgPosition1
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idOrgPositions { get; set; }

        public int? finalEnt { get; set; }

        public Guid guidOrgPositions { get; set; }

        public bool dsblOrgPositions { get; set; }

        public byte dplyOrgPositions { get; set; }

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

        public virtual ROLE ROLE { get; set; }

        public virtual ROLE ROLE1 { get; set; }
    }
}
