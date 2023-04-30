using Cheetah_Business.Data;
using Cheetah_Business.Links;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Dimentions
{
    [Table(nameof(D_Process), Schema = nameof(TableType.Dimentions))]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class D_Process : BaseClass<D_Process>
    {
        #region Simple Prob

        #region Others
        [Description("نمایش جهت پشتیبانی")]
        [Column(Order = 100)]
        public Boolean? PN_ShowSupport { get; set; } = true;

        [Description("فرآیند ERP")]
        [Column(Order = 101)]
        public Boolean? PN_ERP { get; set; } = true;

        [Description("حذف تایید درخواست کننده")]
        [Column(Order = 102)]
        public Boolean? PN_RemoveRequestorApproval { get; set; } = true;

        #endregion

        #endregion

        #region Relations
        public virtual ICollection<L_Process_Strategy>? PSO_Process_Strategies { get; set; } = new HashSet<L_Process_Strategy>();
        #endregion
    }
}
