using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Facts
{
    [Table(nameof(F_RequestInformation), Schema = nameof(TableType.Facts))]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class F_RequestInformation : BaseClass<F_RequestInformation>
    {
        #region Simple Prob
        [Column(Order = 100)]
        public Int64? RI_ERPID { get; set; }
        [Column(Order = 101)]
        public Boolean? RI_IsCancelled { get; set; } = false;
        [Column(Order = 102)]
        public Boolean? IsTest { get; set; } = false;
        [Column(Order = 103)]
        public Byte? RI_PE_Level { get; set; }
        #endregion

        #region DateTimes
        [Column(Order = 104)]
        public DateTime? RI_RequestDate { get; set; } = DateTime.Now;
        [Column(Order = 105)]
        public DateTime? RI_RequestFinishDate { get; set; }
        #endregion

        #region S_User
        [Column(Order = 106)]
        public long? RI_RequestorId { get; set; }
        public virtual D_User? RI_Requestor { get; set; }

        [Column(Order = 107)]
        public long? RI_CreatorId { get; set; }
        public virtual D_User? RI_Creator { get; set; }

        [Column(Order = 109)]
        public long? RI_AllApproveId { get; set; }
        public virtual F_AllApprove? RI_AllApprove { get; set; }
        #endregion

        #region Enitty
        [Description("وضعیت فرآیند")]
        [Column(Order = 110)]
        public long? RI_ProcessStateId { get; set; }
        public virtual D_ProcessState? RI_ProcessState { get; set; }

        [Description("نام فرآیند")]
        [Column(Order = 111)]
        public long? RI_RequestTitleId { get; set; }
        public virtual D_ProcessName? RI_RequestTitle { get; set; }
        #endregion

        #region Collection
        public virtual ICollection<F_Condition>? RI_Conditions { get; set; } = new HashSet<F_Condition>();
        #endregion
    }
}
