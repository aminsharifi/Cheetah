namespace Cheetah_Models.Parameters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class P_UserActionDTO : BasePSClass
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
        public virtual P_UserActionGroup? UA_UserActionGroup { get; set; }
        #endregion

        #region Collections

        #endregion
        #endregion
    }
}
