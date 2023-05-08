using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using HotChocolate;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Facts
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
        public long? CD_TagId { get; set; }
        public virtual D_Tag? CD_Tag { get; set; }

        [Column(Order = 101)]
        public long? CD_OperandId { get; set; }
        public virtual D_Operand? CD_Operand { get; set; }

        [Column(Order = 102)]
        public String CD_Value { get; set; }

        [Column(Order = 103)]
        public long? CD_ScenarioId { get; set; }
        public virtual F_Scenario? CD_Scenario { get; set; }

        [NotMapped]
        [GraphQLIgnore]
        public Boolean CD_BooleanValue
        {
            get
            {
                return (CD_Value == "1");
            }
            set
            {
                CD_Value = (value == true) ? "1" : "0";
            }
        }

        [NotMapped]
        [GraphQLIgnore]
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

        public override void SetName()
        {
            PDisplayName = CD_Scenario?.PDisplayName + "," + CD_Tag?.PDisplayName + "," + CD_Operand?.PDisplayName + "," + CD_Value;
            PName = CD_Scenario?.PName + "," + CD_Tag?.PName + "," + CD_Operand?.PName + "," + CD_Value;
        }
    }
}
