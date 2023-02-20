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
        [Column(Order = 100)]
        public float? FloatValue { get; set; }
        [Column(Order = 101)]
        public Boolean? BooleanValue { get; set; }
        [Column(Order = 102)]
        public String? StringValue { get; set; }
        [Column(Order = 103)]
        public virtual P_ParameterList? LOP_P_ParameterList { get; set; }
        [Column(Order = 104)]
        public virtual P_ParameterType? LOP_P_ParameterType { get; set; }
        [Column(Order = 105)]
        public virtual P_Operand? PT_P_Operand { get; set; }


    }
}
