namespace Cheetah_DataAccess.Masters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Facts;
    using Cheetah_DataAccess.Parameters;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("F_RequestInformation", Schema = "Facts")]
    public partial class F_RequestInformation : BaseClass
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

        #region DateTimes
        [Column(Order = 104)]
        public DateTime? RI_RequestDate { get; set; } = DateTime.Now;
        [Column(Order = 105)]
        public DateTime? RI_RequestFinishDate { get; set; }
        #endregion

        #region S_User
        [Column(Order = 106)]
        public virtual F_User? RI_ExpertUser { get; set; }
        [Column(Order = 107)]
        public virtual F_User? RI_Requestor { get; set; }
        [Column(Order = 108)]
        public virtual F_User? RI_Creator { get; set; }
        [Column(Order = 109)]
        public virtual F_AllApprove? RI_AllApprove { get; set; }
        #endregion

        [Description("وضعیت فرآیند")]
        [Column(Order = 110)]
        public virtual D_ProcessState? RI_ProcessState { get; set; }

        [Description("نام فرآیند")]
        [Column(Order = 111)]
        public virtual D_RequestTitle? RI_RequestTitle { get; set; }

        public virtual ICollection<F_ListOfParameter>? RI_ListOfParameters { get; set; } = new HashSet<F_ListOfParameter>();
        #endregion
    }
}
