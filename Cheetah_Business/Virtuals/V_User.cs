using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Virtuals
{
    [Table(nameof(V_User), Schema = nameof(TableType.Virtuals))]
    public partial class V_User
    {
        public V_User()
        {

        }

        #region Common Prop
        #endregion

        #region Simple Prob

        [Column(Order = 101)]
        [Key]
        public Int64? PERPCode { get; set; }

        [StringLength(128)]
        [Column(Order = 102)]
        public String? PName { get; set; }

        [StringLength(128)]
        [Column(Order = 103)]
        public String? PDisplayName { get; set; }

        [StringLength(512)]
        [Column(Order = 104)]
        public String? User_BossName { get; set; }

        [Column(Order = 105)]
        public Boolean? DsblRecord { get; set; }

        #endregion

        #region Relations

        #region Entity

        #endregion

        #region Collection

        #endregion

        #endregion
    }
}