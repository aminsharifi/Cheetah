namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("P_ParameterType", Schema = "Parameters")]
    public partial class P_ParameterType: BasePSClass
    {
        [Description("گروه لیست")]
        public virtual P_ParameterList? P_ParameterList { get; set; }
    }
}
