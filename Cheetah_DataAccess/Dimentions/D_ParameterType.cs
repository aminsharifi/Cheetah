namespace Cheetah_DataAccess.Parameters
{
    using Cheetah_DataAccess.Data;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("D_ParameterType", Schema = "Dimentions")]    
    public partial class D_ParameterType: BaseDimClass
    {
        [Column(Order = 100)]
        public virtual D_FieldType? PT_P_FieldType { get; set; }
        [InverseProperty("PL_ParameterType")]
        public virtual ICollection<D_ParameterList>? PT_ParameterList { get; set; } = new HashSet<D_ParameterList>();    

    }
}
