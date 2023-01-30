namespace Cheetah_DataAccess.Systems
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("WFUser")]
    public partial class S_User
    {
        #region Common Prop
        [Key]
        public long IdRecord { get; set; }
        public long TimeRecord { get; set; } = DateTime.Now.Ticks;
        public Guid GuidRecord { get; set; } = Guid.NewGuid();
        public bool DsblRecord { get; set; } = false;
        #endregion

        #region Simple Prob

        [Required]
        [StringLength(200)]
        public string WFUser_FullName { get; set; }

        [StringLength(100)]
        public string WFUser_UserName { get; set; }

        [Required]
        [StringLength(25)]
        public string WFUser_Domain { get; set; }

        public bool WFUser_Enabled { get; set; }

        public byte? WFUser_EnabledForAssignation { get; set; }

        public bool? WFUser_NotifByEmail { get; set; }

        public bool? WFUser_NotifByMessenger { get; set; }

        public bool? WFUser_NotifByCell { get; set; }

        [StringLength(100)]
        public string WFUser_ContactEmail { get; set; }

        [StringLength(100)]
        public string WFUser_ContactMessenger { get; set; }

        [StringLength(20)]
        public string WFUser_ContactCell { get; set; }

        public byte? WFUser_DelegateEnabled { get; set; }

        public int? WFUser_language { get; set; }

        public bool? WFUser_CreatedCasesSkipAssigRules { get; set; }

        public byte? WFUser_UserPicture { get; set; }

        public bool? WFUser_OfflineForms { get; set; }

        [Column(TypeName = "money")]
        public decimal? WFUser_OvertimeCost { get; set; }

        public int? WFUser_UserStartPage { get; set; }

        [StringLength(50)]
        public string? WFUser_FirstName { get; set; }

        [StringLength(50)]
        public string? WFUser_LastName { get; set; }

        [StringLength(10)]
        public string? WFUser_IDPersonel { get; set; }
        [StringLength(20)]
        public string? WFUser_NationalCode { get; set; }

        [StringLength(500)]
        public string? WFUser_RelatedLocation { get; set; }

        [StringLength(500)]
        public string? WFUser_SubUsers { get; set; }

        [StringLength(500)]
        public string? WFUser_DistrictManager_RelatedL { get; set; }
        public bool? WFUser_IsNeedUpperApprove { get; set; }
        public bool? WFUser_IsUpApproveVacDay { get; set; }
        public bool? WFUser_IsUpApproveVacHor { get; set; }
        public bool? WFUser_IsUpApproveMisDay { get; set; }
        public bool? WFUser_IsUpApproveMisHor { get; set; }
        public DateTime? WFUser_Birthdate { get; set; }
        public long? WFUser_baLastUpdated { get; set; }

        [StringLength(50)]
        public string? WFUser_InternalPhone { get; set; }

        [StringLength(20)]
        public string? WFUser_Temp_IDPersonel { get; set; }

        [StringLength(20)]
        public string? WFUser_LDAPDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? WFUser_normalCost { get; set; }


        #endregion

        #region Relations

        #region Entity

        public int? idWorkingTimeSchema { get; set; }
        public int? idTimeZone { get; set; }
        public long? idUnitType { get; set; }

        #region FirstRoleUser
        public long? WFUser_idFirstRoleUser { get; set; }
        [ForeignKey("WFUser_idFirstRoleUser")]
        public S_User? WFUser_FirstRoleUser { get; set; }
        #endregion

        #region FirstApprover
        public long? WFUser_idFirstApprover { get; set; }
        [ForeignKey("WFUser_idFirstApprover")]
        public S_User? WFUser_FirstApprover { get; set; }
        #endregion

        #region SecondApprover
        public long? WFUser_idSecondApprover { get; set; }
        [ForeignKey("WFUser_idSecondApprover")]
        public S_User? WFUser_SecondApprover { get; set; }
        #endregion

        #region Area
        public long? WFUser_idArea { get; set; }
        [ForeignKey("WFUser_idArea")]
        public S_Area? WFUser_Area { get; set; }
        #endregion

        #region Location
        public long? WFUser_idLocation { get; set; }
        [ForeignKey("WFUser_idLocation")]
        public S_Location WFUser_Location { get; set; }
        #endregion

        #region BossUser
        public long? WFUser_idBossUser { get; set; }
        [ForeignKey("WFUser_idBossUser")]
        public S_User WFUser_BossUser { get; set; }
        #endregion

        #region Delegate
        public long? WFUser_idDelegate { get; set; }
        [ForeignKey("WFUser_idDelegate")]
        public S_User WFUser_Delegate { get; set; }
        #endregion

        #region DefaultPosition
        public long? WFUser_idDefaultPosition { get; set; }
        [ForeignKey("WFUser_idDefaultPosition")]
        public S_OrgPosition WFUser_DefaultPosition { get; set; } 
        #endregion

        #endregion

        #region Collection
   
        #endregion

        #endregion

    }
}
