namespace Cheetah_DataAccess.Masters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using Cheetah_DataAccess.Systems;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("M_RequestInformation", Schema = "Masters")]
    public partial class M_RequestInformation : BaseClass
    {
        #region Simple Prob
        [Column(Order = 100)]
        public long? RI_ERPID { get; set; }
        [Column(Order = 101)]
        public bool? RI_IsCancelled { get; set; } = false;
        [Column(Order = 102)]
        public bool? IsTest { get; set; } = false;
        [Column(Order = 103)]
        public byte? RI_PE_Level { get; set; }

        #region DateTimes
        [Column(Order = 104)]
        public DateTime? RI_RequestDate { get; set; } = DateTime.Now;
        [Column(Order = 105)]
        public DateTime? RI_RequestFinishDate { get; set; }
        [Column(Order = 106)]
        public DateTime? RI_OldDate { get; set; }
        [Column(Order = 107)]
        public DateTime? RI_NewDate { get; set; }
        [Column(Order = 108)]
        public DateTime? RI_LastTimeModify { get; set; }
        #endregion

        #region S_User
        [Column(Order = 109)]
        public virtual S_User? RI_ExpertUser { get; set; }
        [Column(Order = 110)]
        public virtual S_User? RI_Requestor { get; set; }
        [Column(Order = 111)]
        public virtual S_User? RI_Creator { get; set; }
        [Column(Order = 112)]
        public virtual M_AllApprove? RI_AllApprove { get; set; }
        #endregion

        [Description("وضعیت فرآیند")]
        [Column(Order = 113)]
        public virtual P_ProcessState? RI_ProcessState { get; set; }

        [Description("نوع درخواست")]
        [Column(Order = 114)]
        public virtual P_RequestType? RI_RequestType { get; set; }

        [Description("نام فرآیند")]
        [Column(Order = 115)]
        public virtual P_RequestTitle? RI_RequestTitle { get; set; }

        [Description("زیرفرآیند")]
        [Column(Order = 116)]
        public virtual P_SubRequestTitle? RI_SubRequestTitle { get; set; }
        public virtual ICollection<M_ListOfParameter>? RI_M_ListOfParameters { get; set; } = new HashSet<M_ListOfParameter>();
        #endregion
    }
}
