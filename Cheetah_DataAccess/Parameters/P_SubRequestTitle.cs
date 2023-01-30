namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("P_SubRequestTitle")]
    public partial class P_SubRequestTitle : BasePSClass
    {
        #region Simple Prob


        #endregion

        #region Relations
        [Description("نام فرآیند")]
        public long? SBT_idRequestTitles { get; set; }
        [ForeignKey("SBT_idRequestTitles")]
        public virtual P_RequestTitle? SBT_RequestTitles { get; set; }
        #endregion
    }
}
