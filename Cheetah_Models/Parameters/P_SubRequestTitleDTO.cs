namespace Cheetah_Models.Parameters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class P_SubRequestTitleDTO : BasePSClass
    {
        #region Simple Prob


        #endregion

        #region Relations
        [Description("نام فرآیند")]
        public virtual P_RequestTitle? SBT_RequestTitles { get; set; }
        #endregion
    }
}
