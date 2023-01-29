namespace Cheetah_DataAccess.BPMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Cheetah_DataAccess.Gizelle;

    public partial class WFUser
    {

        public WFUser()
        {
            Approves = new HashSet<Approve>();
            CurrentProcessEndorsemen = new HashSet<CurrentProcessEndorseman>();
            WFUSER1 = new HashSet<WFUser>();
            WFUSER11 = new HashSet<WFUser>();
        }

        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idUser { get; set; }
        public int finalEnt { get; set; }
        public long baCreatedTime { get; set; }
        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion

        #region Simple Prob

        [Required]
        [StringLength(200)]
        public string fullName { get; set; }

        [StringLength(100)]
        public string userName { get; set; }

        [Required]
        [StringLength(25)]
        public string domain { get; set; }

        public bool enabled { get; set; }

        public byte? enabledForAssignation { get; set; }

        public bool? notifByEmail { get; set; }

        public bool? notifByMessenger { get; set; }

        public bool? notifByCell { get; set; }

        [StringLength(100)]
        public string contactEmail { get; set; }

        [StringLength(100)]
        public string contactMessenger { get; set; }

        [StringLength(20)]
        public string contactCell { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? wfClassAccessCacheExpiry { get; set; }

        public byte? DelegateEnabled { get; set; }

        public int? language { get; set; }

        public bool? createdCasesSkipAssigRules { get; set; }

        public byte? userPicture { get; set; }

        public bool? offlineForms { get; set; }

        [Column(TypeName = "money")]
        public decimal? overtimeCost { get; set; }

        public int userStartPage { get; set; }

        [StringLength(50)]
        public string FirstNAme { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(10)]
        public string IDPersonel { get; set; }
        [StringLength(20)]
        public string NationalCode { get; set; }

        [StringLength(500)]
        public string RelatedLocation { get; set; }

        [StringLength(500)]
        public string SubUsers { get; set; }

        [StringLength(500)]
        public string DistrictManager_RelatedL { get; set; }

        public bool? IsNeedUpperApprove { get; set; }

        public bool? IsUpApproveVacDay { get; set; }

        public bool? IsUpApproveVacHor { get; set; }

        public bool? IsUpApproveMisDay { get; set; }

        public bool? IsUpApproveMisHor { get; set; }

        public DateTime? Birthdate { get; set; }

        public long? baLastUpdated { get; set; }

        [StringLength(50)]
        public string InternalPhone { get; set; }

        [StringLength(20)]
        public string Temp_IDPersonel { get; set; }

        [StringLength(20)]
        public string LDAPDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? normalCost { get; set; }

        #endregion

        #region Relations

        #region Entity
        public int? idFirstRoleUser { get; set; }

        public int? FirstApprover { get; set; }

        public int? SecondApprover { get; set; }

        public int? idArea { get; set; }

        public int? idLocation { get; set; }

        public int? idBossUser { get; set; }
        public int? idWorkingTimeSchema { get; set; }

        public int? idDelegate { get; set; }

        public int? idTimeZone { get; set; }

        public long? idDefaultPosition { get; set; }

        public long? idUnitType { get; set; }
        public int? idPosirionName { get; set; }
        public virtual Area AREA { get; set; }
        public virtual WFUser WFUSER2 { get; set; }
        public virtual WFUser WFUSER3 { get; set; }
        public virtual Location LOCATION { get; set; }
        #endregion

        #region Collection
        public virtual ICollection<Approve> Approves { get; set; }
        public virtual ICollection<CurrentProcessEndorseman> CurrentProcessEndorsemen { get; set; }
        public virtual ICollection<WFUser> WFUSER1 { get; set; }
        public virtual ICollection<WFUser> WFUSER11 { get; set; }
        #endregion

        #endregion

    }
}
