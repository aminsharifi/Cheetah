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
        public long? RI_ERPID { get; set; }
        public bool? RI_IsCancelled { get; set; } = false;
        public bool? IsTest { get; set; } = false;
        public byte? RI_PE_Level { get; set; }

        #region DateTimes
        public DateTime? RI_RequestDate { get; set; } = DateTime.Now;
        public DateTime? RI_RequestFinishDate { get; set; }
        public DateTime? RI_OldDate { get; set; }
        public DateTime? RI_NewDate { get; set; }
        public DateTime? RI_LastTimeModify { get; set; }
        #endregion

        #region S_User
        public virtual S_User? RI_ExpertUser { get; set; }
        public virtual S_User? RI_Requestor { get; set; }
        public virtual S_User? RI_Creator { get; set; }
        public virtual M_AllApprove? RI_AllApprove { get; set; }
        #endregion

        [Description("وضعیت فرآیند")]
        public virtual P_ProcessState? RI_ProcessState { get; set; }

        [Description("نوع درخواست")]
        public virtual P_RequestType? RI_RequestType { get; set; }

        [Description("نام فرآیند")]
        public virtual P_RequestTitle? RI_RequestTitle { get; set; }

        [Description("زیرفرآیند")]
        public virtual P_SubRequestTitle? RI_SubRequestTitle { get; set; }

        [Description("وضعیت تایید فعال")]
        public virtual M_CurrentPE? RI_M_CurrentPE { get; set; }
        public virtual ICollection<M_CurrentPE>? RI_M_CurrentPEs { get; set; } = new HashSet<M_CurrentPE>();
        public virtual ICollection<M_ListOfParameter>? RI_M_ListOfParameters { get; set; } = new HashSet<M_ListOfParameter>();
        #endregion
    }
}
