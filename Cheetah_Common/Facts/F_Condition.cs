using Cheetah_Common.Data;
using Cheetah_Common.Dimentions;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Common.Facts
{

    [Table(nameof(F_Condition), Schema = nameof(TableType.Facts))]
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
        public long? CD_D_TagId { get; set; }
        public virtual D_Tag? CD_D_Tag { get; set; }

        [Column(Order = 101)]
        public long? CD_OperandId { get; set; }
        public virtual D_Operand? CD_Operand { get; set; }

        [Column(Order = 102)]
        public String? CD_Value { get; set; }

        [Column(Order = 103)]
        public long? CD_EndorsementPatternId { get; set; }
        public virtual D_EndorsementPattern? CD_EndorsementPattern { get; set; }

        [NotMapped]
        public Boolean CD_BooleanValue
        {
            get
            {
                return (CD_Value == "1") ? true : false;
            }
            set
            {
                CD_Value = (value == true) ? "1" : "0";
            }
        }
        [NotMapped]
        public float CD_FloatValue
        {
            get
            {
                return float.Parse(CD_Value ??= "0");
            }
            set
            {
                CD_Value = value.ToString();
            }
        }
    }
}
