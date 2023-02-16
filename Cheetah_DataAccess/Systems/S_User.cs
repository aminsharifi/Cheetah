namespace Cheetah_DataAccess.Systems
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Masters;
    using Cheetah_DataAccess.Parameters;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System;
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
        public virtual IdentityUser? identityUser { get; set; }
        #endregion

        #region Simple Prob
        public long? User_Int_P_FieldType { get; set; }
        public bool? User_Bool_P_FieldType { get; set; }

        [Required]
        [StringLength(200)]
        public string? User_FullName { get; set; }

        [StringLength(100)]
        public string? User_UserName { get; set; }

        [Required]
        [StringLength(25)]
        public string? User_Domain { get; set; }
        public bool? User_EnabledForAssignation { get; set; }
        public bool? User_NotifByEmail { get; set; }
        public bool? User_NotifByMessenger { get; set; }
        public bool? User_NotifByCell { get; set; }

        [StringLength(100)]
        public string? User_ContactEmail { get; set; }

        [StringLength(100)]
        public string? User_ContactMessenger { get; set; }

        [StringLength(20)]
        public string? User_ContactCell { get; set; }

        public bool? User_DelegateEnabled { get; set; }

        public bool? User_CreatedCasesSkipAssigRules { get; set; }

        public byte[]? User_UserPicture { get; set; }

        public bool? User_OfflineForms { get; set; }

        [Column(TypeName = "money")]
        public decimal? User_OvertimeCost { get; set; }

        public int? User_UserStartPage { get; set; }

        [StringLength(50)]
        public string? User_FirstName { get; set; }

        [StringLength(50)]
        public string? User_LastName { get; set; }

        [StringLength(10)]
        public string? User_IDPersonel { get; set; }
        [StringLength(20)]
        public string? User_NationalCode { get; set; }
        public DateTime? User_Birthdate { get; set; }

        [StringLength(50)]
        public string? User_InternalPhone { get; set; }

        [StringLength(20)]
        public string? User_Temp_IDPersonel { get; set; }

        [StringLength(20)]
        public string? User_LDAPDescription { get; set; }

        [StringLength(512)]
        public String? User_Address { get; set; }
        [StringLength(215)]
        public String? User_RegistrationNumber { get; set; }

        #endregion

        #region Relations

        #region Entity
        public int? User_language { get; set; }
        public long? User_idWorkingTimeSchema { get; set; }
        public long? User_idTimeZone { get; set; }
        public virtual S_Role? User_S_Role { get; set; }

        #region S_User

        public long? User_BossUserId { get; set; }
        [ForeignKey("User_BossUserId")]
        public virtual S_User? User_BossUser { get; set; }
        public long? User_DelegateId { get; set; }
        [ForeignKey("User_DelegateId")]
        public virtual S_User? User_Delegate { get; set; }
        public virtual P_FieldType? User_P_FieldType { get; set; }
        public virtual P_Operand? User_P_Operand { get; set; }
        #endregion
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
