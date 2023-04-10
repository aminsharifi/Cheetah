namespace Cheetah_DataAccess.Facts
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Dimentions;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("F_ListOfParameter", Schema = "Facts")]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class F_ListOfParameter : BaseClass<F_ListOfParameter>
    {
        [Column(Order = 100)]
        public Single? LOP_FloatValue { get; set; }
        [Column(Order = 101)]
        public Boolean? LOP_BooleanValue { get; set; }
        [Column(Order = 102)]
        public String? LOP_StringValue { get; set; }
        [Column(Order = 103)]
        public virtual D_ParameterList? LOP_ParameterList { get; set; }
        [Column(Order = 104)]
        public virtual D_ParameterType? LOP_ParameterType { get; set; }
        [Column(Order = 105)]
        public virtual D_Operand? PT_Operand { get; set; }


    }
}
