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
        [Column(Order = 100)]
        public virtual P_FieldType? PT_P_FieldType { get; set; }
        [InverseProperty("PL_P_ParameterType")]
        public virtual ICollection<P_ParameterList>? PT_P_ParameterList { get; set; } = new HashSet<P_ParameterList>();    

    }
}
