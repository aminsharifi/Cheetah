namespace Cheetah_DataAccess.Systems
{
    using Cheetah_DataAccess.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("S_User")]
    public partial class S_User: BasePSClass
    {
        #region Common Prop

        #endregion

        #region Simple Prob

        [Required]
        [StringLength(200)]
        public string? User_FullName { get; set; }

        [StringLength(100)]
        public string? User_UserName { get; set; }

        [Required]
        [StringLength(25)]
        public string? User_Domain { get; set; }

        public bool? User_Enabled { get; set; }

        public byte? User_EnabledForAssignation { get; set; }

        public bool? User_NotifByEmail { get; set; }

        public bool? User_NotifByMessenger { get; set; }

        public bool? User_NotifByCell { get; set; }

        [StringLength(100)]
        public string? User_ContactEmail { get; set; }

        [StringLength(100)]
        public string? User_ContactMessenger { get; set; }

        [StringLength(20)]
        public string? User_ContactCell { get; set; }

        public byte? User_DelegateEnabled { get; set; }

        public int? User_language { get; set; }

        public bool? User_CreatedCasesSkipAssigRules { get; set; }

        public byte? User_UserPicture { get; set; }

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

        [StringLength(500)]
        public string? User_RelatedLocation { get; set; }

        [StringLength(500)]
        public string? User_SubUsers { get; set; }

        [StringLength(500)]
        public string? User_DistrictManager_RelatedL { get; set; }
        public bool? User_IsNeedUpperApprove { get; set; }      
        public DateTime? User_Birthdate { get; set; }

        [StringLength(50)]
        public string? User_InternalPhone { get; set; }

        [StringLength(20)]
        public string? User_Temp_IDPersonel { get; set; }

        [StringLength(20)]
        public string? User_LDAPDescription { get; set; }

        #endregion

        #region Relations

        #region Entity

        public long? User_idWorkingTimeSchema { get; set; }
        public long? User_idTimeZone { get; set; }
        public long? User_idUnitType { get; set; }

        #region FirstRoleUser
        public long? User_idFirstRoleUser { get; set; }
        [ForeignKey("User_idFirstRoleUser")]
        public virtual S_User? User_FirstRoleUser { get; set; }
        #endregion

        #region FirstApprover
        public long? User_idFirstApprover { get; set; }
        [ForeignKey("User_idFirstApprover")]
        public virtual S_User? User_FirstApprover { get; set; }
        #endregion

        #region SecondApprover
        public long? User_idSecondApprover { get; set; }
        [ForeignKey("User_idSecondApprover")]
        public virtual S_User? User_SecondApprover { get; set; }
        #endregion

        #region Area
        public long? User_idArea { get; set; }
        [ForeignKey("User_idArea")]
        public virtual S_Area? User_Area { get; set; }
        #endregion

        #region Location
        public long? User_idLocation { get; set; }
        [ForeignKey("User_idLocation")]
        public virtual S_Location? User_Location { get; set; }
        #endregion

        #region BossUser
        public long? User_idBossUser { get; set; }
        [ForeignKey("User_idBossUser")]
        public virtual S_User? User_BossUser { get; set; }
        #endregion

        #region Delegate
        public long? User_idDelegate { get; set; }
        [ForeignKey("User_idDelegate")]
        public virtual S_User? User_Delegate { get; set; }
        #endregion

        #region DefaultPosition
        public long? User_idDefaultPosition { get; set; }
        [ForeignKey("User_idDefaultPosition")]
        public virtual S_OrgPosition? User_DefaultPosition { get; set; } 
        #endregion

        #endregion

        #region Collection
   
        #endregion

        #endregion

    }
}
