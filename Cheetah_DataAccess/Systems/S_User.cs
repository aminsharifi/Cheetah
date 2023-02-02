namespace Cheetah_DataAccess.Systems
{
    using Cheetah_DataAccess.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("S_User", Schema = "Systems")]
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

        public virtual S_Location? User_Location { get; set; }
        public virtual S_Area? User_Area { get; set; }
        public virtual S_OrgPosition? User_DefaultPosition { get; set; }

        public long? User_FirstRoleUserId { get; set; }
        [ForeignKey("User_FirstRoleUserId")]
        public virtual S_User? User_FirstRoleUser { get; set; }

        public long? User_FirstApproverId { get; set; }
        [ForeignKey("User_FirstApproverId")]
        public virtual S_User? User_FirstApprover { get; set; }

        public long? User_SecondApproverId { get; set; }
        [ForeignKey("User_SecondApproverId")]
        public virtual S_User? User_SecondApprover { get; set; }

        public long? User_BossUserId { get; set; }
        [ForeignKey("User_BossUserId")]
        public virtual S_User? User_BossUser { get; set; }

        public long? User_DelegateId { get; set; }
        [ForeignKey("User_DelegateId")]
        public virtual S_User? User_Delegate { get; set; }
        #endregion

        #region Collection

        #endregion

        #endregion
    }
}
