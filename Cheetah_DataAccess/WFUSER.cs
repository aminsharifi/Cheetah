namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("WFUSER")]
    public partial class WFUSER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WFUSER()
        {
            Approves = new HashSet<Approve>();
            CurrentProcessEndorsemen = new HashSet<CurrentProcessEndorseman>();
            WFUSER1 = new HashSet<WFUSER>();
            WFUSER11 = new HashSet<WFUSER>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idUser { get; set; }

        [Required]
        [StringLength(200)]
        public string fullName { get; set; }

        [StringLength(100)]
        public string userName { get; set; }

        [Required]
        [StringLength(25)]
        public string domain { get; set; }

        public int? idArea { get; set; }

        public int? idLocation { get; set; }

        public bool enabled { get; set; }

        public int? idBossUser { get; set; }

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

        public int? idWorkingTimeSchema { get; set; }

        public int? idDelegate { get; set; }

        public byte? DelegateEnabled { get; set; }

        public int? idTimeZone { get; set; }

        public int? language { get; set; }

        public bool? createdCasesSkipAssigRules { get; set; }

        public byte? userPicture { get; set; }

        public bool? offlineForms { get; set; }

        public Guid? guidUser { get; set; }

        [Column(TypeName = "money")]
        public decimal? normalCost20220308_235415_0 { get; set; }

        [Column(TypeName = "money")]
        public decimal? overtimeCost { get; set; }

        public int finalEnt { get; set; }

        public int userStartPage { get; set; }

        [StringLength(50)]
        public string FirstNAme { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(10)]
        public string IDPersonel { get; set; }

        public long? idDefaultPosition { get; set; }

        public long? idUnitType { get; set; }

        [StringLength(20)]
        public string NationalCode { get; set; }

        [StringLength(500)]
        public string RelatedLocation { get; set; }

        [StringLength(500)]
        public string SubUsers { get; set; }

        [StringLength(500)]
        public string DistrictManager_RelatedL { get; set; }

        public int? FirstApprover { get; set; }

        public int? SecondApprover { get; set; }

        public bool? IsNeedUpperApprove { get; set; }

        public bool? IsUpApproveVacDay { get; set; }

        public bool? IsUpApproveVacHor { get; set; }

        public bool? IsUpApproveMisDay { get; set; }

        public bool? IsUpApproveMisHor { get; set; }

        public DateTime? Birthdate { get; set; }

        public long baCreatedTime { get; set; }

        public long? baLastUpdated { get; set; }

        [StringLength(50)]
        public string InternalPhone { get; set; }

        public int? idFirstRoleUser { get; set; }

        public int? idPosirionName { get; set; }

        [Column(TypeName = "money")]
        public decimal? normalCost20220606_155503_0 { get; set; }

        [Column(TypeName = "money")]
        public decimal? normalCost20220613_153951_0 { get; set; }

        [Column(TypeName = "money")]
        public decimal? normalCost20220704_113058_0 { get; set; }

        [Column(TypeName = "money")]
        public decimal? normalCost20220725_114415_0 { get; set; }

        [Column(TypeName = "money")]
        public decimal? normalCost20220801_151831_0 { get; set; }

        [Column(TypeName = "money")]
        public decimal? normalCost20221008_120219_0 { get; set; }

        public long? id1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? normalCost20221119_115603_0 { get; set; }

        [StringLength(20)]
        public string Temp_IDPersonel { get; set; }

        [StringLength(20)]
        public string LDAPDescription { get; set; }

        [Column(TypeName = "money")]
        public decimal? normalCost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Approve> Approves { get; set; }

        public virtual AREA AREA { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CurrentProcessEndorseman> CurrentProcessEndorsemen { get; set; }

        public virtual LOCATION LOCATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFUSER> WFUSER1 { get; set; }

        public virtual WFUSER WFUSER2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WFUSER> WFUSER11 { get; set; }

        public virtual WFUSER WFUSER3 { get; set; }
    }
}
