using Cheetah_Business.Data;
using Cheetah_Business.Facts;
using Cheetah_Business.Links;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Virtuals
{
    [Table(nameof(V_User), Schema = nameof(TableType.Virtuals))]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    public partial class V_User : BaseClass<V_User>
    {
        public V_User()
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

        [Column(Order = 109)]
        public long? User_DelegateId { get; set; }

        #endregion              

        #endregion
      

        #endregion
    }
}