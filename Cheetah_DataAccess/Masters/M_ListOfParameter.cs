namespace Cheetah_DataAccess.Masters
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Parameters;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("M_ListOfParameter", Schema = "Masters")]
    public partial class M_ListOfParameter : BasePSClass
    {
        public float? FloatValue { get; set; }
        public Boolean? BooleanValue { get; set; }
        public String? StringValue { get; set; }
        public virtual P_ParameterList? LOP_P_ParameterList { get; set; }
        public virtual P_ParameterType? LOP_P_ParameterType { get; set; }
        public virtual P_Operand? PT_P_Operand { get; set; }


    }
}
