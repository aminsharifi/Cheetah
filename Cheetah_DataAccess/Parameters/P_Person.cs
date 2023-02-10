namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("P_Person", Schema = "Parameters")]
    public partial class P_Person : BasePSClass
    {
        #region Relation

        #region Entity

        [StringLength(100)]
        public string? FirstName { get; set; }
        [StringLength(100)]
        public string? LastName { get; set; }
        [StringLength(100)]
        public String? CellPhone { get; set; }
        [StringLength(512)]
        public String? Address { get; set; }
        [StringLength(215)]
        public String? RegistrationNumber { get; set; }
        [StringLength(10)]
        public String? NationalID { get; set; }
        [StringLength(10)]
        public String? LicenseNum { get; set; }
        
        [StringLength(50)]
        public String? Phone { get; set; }
        //[PersonType][bigint] NULL,
        //[LegalType][bigint] NULL,        
        //[Gender][bigint] NULL,               
        #endregion        

        #region Collection
        
        #endregion

        #endregion
    }
}
