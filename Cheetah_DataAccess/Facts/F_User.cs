namespace Cheetah_DataAccess.Facts
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Masters;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("F_User", Schema = "Facts")]
    public partial class F_User : BaseDimClass
    {
        public F_User()
        {

        }
        public F_User(IdentityUser identityUser)
        {
            this.User_IdentityUser = identityUser;
        }

        #region Common Prop
        #endregion
        #region Simple Prob
        [Required]
        [StringLength(200)]
        [Column(Order = 100)]
        public String? User_FullName { get; set; }
        [StringLength(100)]
        [Column(Order = 101)]
        public String? User_UserName { get; set; }
        [Required]
        [StringLength(25)]
        [Column(Order = 102)]
        public String? User_Domain { get; set; }
        [Column(Order = 103)]
        public Boolean? User_EnabledForAssignation { get; set; }
        [Column(Order = 104)]
        public Boolean? User_DelegateEnabled { get; set; }
        [Column(Order = 105)]
        public Boolean? User_CreatedCasesSkipAssigRules { get; set; }
        [StringLength(10)]
        [Column(Order = 106)]
        public String? User_IDPersonel { get; set; }
        [StringLength(20)]
        [Column(Order = 107)]
        public String? User_LDAPDescription { get; set; }

        #endregion

        #region Relations

        #region Entity   

        #region S_User
        [Column(Order = 108)]
        public Int64? User_BossUserId { get; set; }
        [ForeignKey("User_BossUserId")]
        public virtual F_User? User_BossUser { get; set; }
        [Column(Order = 109)]
        public Int64? User_DelegateId { get; set; }
        [ForeignKey("User_DelegateId")]
        public virtual F_User? User_Delegate { get; set; }
        [Column(Order = 110)]
        public virtual F_UserInformation? User_UserInformation { get; set; }
        #endregion
        [Column(Order = 111)]
        public virtual IdentityUser? User_IdentityUser { get; set; }
        #endregion

        #region Collection
        [Description("واحد")]
        [InverseProperty("UA_User")]
        public virtual ICollection<F_UserArea>? User_UserAreas { get; set; } = new HashSet<F_UserArea>();
        [Description("موقعیت")]

        [InverseProperty("UL_UserLocation")]
        public virtual ICollection<F_UserLocation>? User_UserLocations { get; set; } = new HashSet<F_UserLocation>();
        [InverseProperty("UL_RelatedUserLocation")]
        public virtual ICollection<F_UserLocation>? User_Related_UserLocations { get; set; } = new HashSet<F_UserLocation>();

        [InverseProperty("UR_User")]
        public virtual ICollection<F_UserRole>? User_UserRoles { get; set; } = new HashSet<F_UserRole>();
        public virtual ICollection<F_ListOfParameter>? User_ListOfParameters { get; set; } = new HashSet<F_ListOfParameter>();
        #endregion

        #endregion
    }
}