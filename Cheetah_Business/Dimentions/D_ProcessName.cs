using Cheetah_Business.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Dimentions
{
    [Table(nameof(D_ProcessName), Schema = nameof(TableType.Dimentions))]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class D_ProcessName : BaseClass<D_ProcessName>
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

        public long PN_EndorsementPatternId { get; set; }
        [Description("الگوی فرآیند")]
        [Column(Order = 103)]
        public virtual D_EndorsementPattern PN_EndorsementPattern { get; set; }

        #endregion

        #endregion

        #region Relations

        #endregion
    }
}
