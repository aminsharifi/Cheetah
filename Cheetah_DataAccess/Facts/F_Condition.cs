namespace Cheetah_DataAccess.Facts
{
    using Cheetah_DataAccess.Data;
    using Cheetah_DataAccess.Dimentions;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("F_Condition", Schema = "Facts")]
    [Index(nameof(PCode), IsUnique = true, AllDescending = true)]
    [Index(nameof(PIndex), IsUnique = true, AllDescending = true)]
    [Index(nameof(PName), IsUnique = true, AllDescending = true)]
    [Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
    [Index(nameof(PERPCode), IsUnique = false, AllDescending = true)]
    [Index(nameof(DsblRecord), IsUnique = false, AllDescending = true)]
    [Index(nameof(Parent_Id), IsUnique = false, AllDescending = true)]
    public partial class F_Condition : BaseClass<F_Condition>
    {
        [Column(Order = 100)]
        public virtual D_ParameterList? CD_ParameterList { get; set; }

        [Column(Order = 101)]
        public virtual D_Operand? CD_Operand { get; set; }

        [Column(Order = 102)]
        public String? CD_Value { get; set; }


        [Column(Order = 103)]
        public long? CD_EndorsementPatternId { get; set; }
        [ForeignKey("CD_EndorsementPatternId")]
        public virtual D_EndorsementPattern? CD_EndorsementPattern { get; set; }

    }
}
