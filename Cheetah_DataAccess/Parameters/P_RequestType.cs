namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("P_RequestType", Schema = "Parameters")]
    public partial class P_RequestType : BasePSClass
    {
        #region Simple Prob
        [Description("نام فرآیند")]
        [Column(Order = 100)]
        public virtual P_RequestTitle? SBT_RequestTitles { get; set; }
        #endregion
    }
}
