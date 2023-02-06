namespace Cheetah_Models.Parameters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class P_ParameterListDTO : BasePSClass
    {
        [Description("گروه لیست")]
        public virtual P_ParameterList? P_ParameterList { get; set; }
    }
}
