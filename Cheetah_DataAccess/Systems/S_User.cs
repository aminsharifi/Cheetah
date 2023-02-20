namespace Cheetah_DataAccess.Systems
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Masters;
    using Cheetah_DataAccess.Parameters;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("S_User", Schema = "Systems")]
    public partial class S_User : BasePSClass
    {
        public S_User()
        {

        }
        public S_User(IdentityUser identityUser)
        {
            this.identityUser = identityUser;
        }

        #region Common Prop
        #endregion
        #region Simple Prob
        [Required]
        [StringLength(200)]
        [Column(Order = 100)]
        public string? User_FullName { get; set; }
        [StringLength(100)]
        [Column(Order = 101)]
        public string? User_UserName { get; set; }
        [Required]
        [StringLength(25)]
        [Column(Order = 102)]
        public string? User_Domain { get; set; }
        [Column(Order = 103)]
        public bool? User_EnabledForAssignation { get; set; }
        [Column(Order = 104)]
        public bool? User_DelegateEnabled { get; set; }
        [Column(Order = 105)]
        public bool? User_CreatedCasesSkipAssigRules { get; set; }       
        [StringLength(10)]
        [Column(Order = 106)]
        public string? User_IDPersonel { get; set; }      
        [StringLength(20)]
        [Column(Order = 107)]
        public string? User_LDAPDescription { get; set; }

        #endregion

        #region Relations

        #region Entity   

        #region S_User
        [Column(Order = 108)]
        public long? User_BossUserId { get; set; }
        [ForeignKey("User_BossUserId")]
        public virtual S_User? User_BossUser { get; set; }
        [Column(Order = 109)]
        public long? User_DelegateId { get; set; }
        [ForeignKey("User_DelegateId")]
        public virtual S_User? User_Delegate { get; set; }
        [Column(Order = 110)]
        public virtual S_UserInformation? User_S_UserInformation { get; set; }
        #endregion
        [Column(Order = 111)]
        public virtual IdentityUser? identityUser { get; set; }
        #endregion

        #region Collection
        [Description("واحد")]
        [InverseProperty("UR_User")]
        public virtual ICollection<S_UserArea>? User_S_UserAreas { get; set; } = new HashSet<S_UserArea>();
        [Description("موقعیت")]

        [InverseProperty("UL_UserLocation")]
        public virtual ICollection<S_UserLocation>? S_UserLocations { get; set; } = new HashSet<S_UserLocation>();
        [InverseProperty("UL_RelatedUserLocation")]
        public virtual ICollection<S_UserLocation>? User_Related_S_UserLocations { get; set; } = new HashSet<S_UserLocation>();

        [InverseProperty("UR_User")]
        public virtual ICollection<S_UserRole>? User_S_UserRoles { get; set; } = new HashSet<S_UserRole>();
        public virtual ICollection<M_ListOfParameter>? User_M_ListOfParameter { get; set; } = new HashSet<M_ListOfParameter>();
        #endregion

        #endregion
    }
}
