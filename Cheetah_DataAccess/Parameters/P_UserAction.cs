namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("P_UserAction", Schema = "Parameters")]
    public partial class P_UserAction : BasePSClass
    {

        #region Relations

        #region Entity
        [Description("گروه اقدام کاربر")]
        [Column(Order = 100)]
        public virtual P_UserActionGroup? UA_UserActionGroup { get; set; }
        #endregion

        #region Collections

        #endregion
        #endregion
    }
}
