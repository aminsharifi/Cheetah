namespace Cheetah_DataAccess.Dimentions
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Facts;
    using Cheetah_DataAccess.Links;
    using Cheetah_DataAccess.Masters;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Internal;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("D_User", Schema = "Dimentions")]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    public partial class D_User : BaseClass<D_User>
    {
        public D_User()
        {

        }

        #region Common Prop
        #endregion

        #region Simple Prob
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
        public virtual D_User? User_BossUser { get; set; }
        [Column(Order = 109)]
        public long? User_DelegateId { get; set; }
        [ForeignKey("User_DelegateId")]
        public virtual D_User? User_Delegate { get; set; }
        [Column(Order = 110)]
        public virtual F_UserInformation? User_UserInformation { get; set; }
        #endregion        
        #endregion

        #region Collection
        [Description("واحد")]
        public virtual ICollection<L_UserArea>? User_UserAreas { get; set; } = new HashSet<L_UserArea>();
        [Description("موقعیت")]
        public virtual ICollection<L_UserLocation>? User_UserLocations { get; set; } = new HashSet<L_UserLocation>();
        public virtual ICollection<L_UserRelatedLocation>? User_Related_UserLocations { get; set; } = new HashSet<L_UserRelatedLocation>();
        public virtual ICollection<L_UserPosition>? User_UserRoles { get; set; } = new HashSet<L_UserPosition>();
        public virtual ICollection<F_ListOfParameter>? User_ListOfParameters { get; set; } = new HashSet<F_ListOfParameter>();
        #endregion

        #endregion
    }
}