namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class ProcessEndorsement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProcessEndorsement()
        {
        }

        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idProcessEndorsements { get; set; }
        public int finalEnt { get; set; }
        public long baCreatedTime { get; set; }
        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion

        #region Simple Prop
        [Description("ترتیب فرآیند")]
        public byte? PE_ApproveOrder { get; set; }
        [Description("کد تایید فرآیند")]
        public int? PE_Code { get; set; }
        [Description("شرطی")]
        public bool? PE_Conditional { get; set; }
        [Description("ارسال ایمیل")]
        public bool? PE_Mail { get; set; }
        [Description("ارسال به اتوماسیون")]
        public bool? PE_Automation { get; set; }
        [Description("ارسال به پیام کوتاه")]
        public bool? PE_SMS { get; set; }
        [Description("ارسال رونوشت")]
        public bool? PE_Transcript { get; set; }
        [Description("شرطی 2")]
        public bool? PE_Conditional2 { get; set; }

        [StringLength(50)]
        [Description("نام فرم")]
        public string PE_TaskName { get; set; }

        [StringLength(50)]
        [Description("اقدامات مجاز کاربر")]
        public string PE_ValidUserAction { get; set; }

        [Description("ارسال جهت اخذ تایید")]
        public bool? PE_Active { get; set; }

        [StringLength(50)]
        [Description("زیرفرآیند")]
        public string PE_SubRequestTitles { get; set; }

        [Description("شرطی 3")]
        public bool? PE_Conditional3 { get; set; }

        [Description("شرطی 4")]
        public bool? PE_Conditional4 { get; set; }

        [Description("شرطی 5")]
        public bool? PE_Conditional5 { get; set; }

        [StringLength(50)]
        public string PE_Code_STR { get; set; }

        [Description("شرط دارویی")]
        public bool? RT_ConditionDrug { get; set; }

        [Description("شرط FMCG")]
        public bool? RT_ConditionFMCG { get; set; }

        [StringLength(50)]
        [Description("اقدامات مجاز خروجی")]
        public string PE_ValidOutput { get; set; }

        [Description("ارسال به همه")]
        public bool? RT_SendAll { get; set; }

        [Description("سهم تامین کننده")]
        public bool? RT_SupplierSHare { get; set; }

        [Description("سهم پخش البرز")]
        public bool? RT_AlborzSHare { get; set; }

        [StringLength(50)]
        [Description("وضعیت استخدامی")]
        public string PE_UserRelationship { get; set; }
        #endregion

        #region Relation
        #region Entity

        [Description("کارشناس تخصیص پیشفرض")]
        public virtual WFUSER PE_ExpertUser { get; set; }

        [Description("سمت سازمانی")]
        public virtual OrgPosition1 PE_OrgPositions { get; set; }

        [Description("نام فرآیند")]
        public virtual RequestTitle PE_RequestTitles { get; set; }

        [Description("وضعیت فرآیند")]
        public virtual ProcessState PE_ProcessState { get; set; }

        #endregion
        #region Collection

        #endregion
        #endregion
    }
}
