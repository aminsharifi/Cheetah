namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("P_UserAction")]
    public partial class P_UserAction : BasePSClass
    {
        #region Simple Prob

        [StringLength(50)]
        [Description("اقدامات مجاز")]
        public string? UA_ValidActions { get; set; }

        [StringLength(200)]
        [Description("مخفف")]
        public string? UA_Abbreviation { get; set; }
        #endregion

        #region Relations

        #region Entity
        [Description("گروه اقدام کاربر")]
        public long? UA_idUserActionGroup { get; set; }
        [ForeignKey("UA_idUserActionGroup")]
        public virtual P_UserActionGroup? UA_UserActionGroup { get; set; }
        #endregion

        #region Collections

        #endregion
        #endregion
    }
}
