namespace Cheetah_DataAccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UserAction")]
    public partial class UserAction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserAction()
        {
         
        }

        #region Common Prop
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idUserAction { get; set; }
        public int finalEnt { get; set; }
        public long baCreatedTime { get; set; }
        public Guid baGuid { get; set; }
        public bool dsblRecord { get; set; }
        #endregion

        #region Simple Prob

        [Description("کد اقدام")]
        public byte? UserAction_Code { get; set; }

        [StringLength(50)]
        [Description("عنوان اقدام")]
        public string UserAction_Name { get; set; }

        [Description("اندیس سورت")]
        public int? UserAction_SortIndex { get; set; }

        [Description("کد در سیستم ERP")]
        public int? ERPCode { get; set; }

        [StringLength(50)]
        [Description("اقدامات مجاز")]
        public string UserAction_ValidActions { get; set; }

        [StringLength(200)]
        [Description("مخفف")]
        public string UserAction_Abbreviation { get; set; }
        #endregion

        #region Relations

        #region Entity
        [Description("گروه اقدام کاربر")]
        public virtual UserActionGroup UserActionGroup { get; set; }
        #endregion

        #region Collections

        #endregion
        #endregion

    }
}
