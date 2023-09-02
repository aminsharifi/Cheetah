using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using HotChocolate;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
namespace Cheetah_Business.Facts;

[Table(nameof(F_Condition), Schema = nameof(TableType.Facts))]
[Index(nameof(CreateTimeRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(LastUpdatedRecord), IsUnique = true, AllDescending = true)]
[Index(nameof(ERPCode), IsUnique = false, AllDescending = true)]
[Index(nameof(EnableRecord), IsUnique = false, AllDescending = true)]
public partial class F_Condition : SimpleClass
{
    [Column(Order = 100)]
    public long? TagId { get; set; }
    public virtual D_Tag? Tag { get; set; }

    [Column(Order = 101)]
    public long? OperandId { get; set; }
    public virtual D_Operand? Operand { get; set; }

    [Column(Order = 102)]
    public String Value { get; set; }

    [Column(Order = 103)]
    public long? ScenarioId { get; set; }
    public virtual F_Scenario? Scenario { get; set; }

    [Column(Order = 105)]
    public long? CaseId { get; set; }
    public virtual F_Case? Case { get; set; }

    [Column(Order = 109)]
    public long? EndorsementItemId { get; set; }
    [ForeignKey(nameof(EndorsementItemId))]
    public virtual F_EndorsementItem? EndorsementItem { get; set; }

    [NotMapped]
    [GraphQLIgnore]
    public Boolean BooleanValue
    {
        get
        {
            return (Value == "1");
        }
        set
        {
            Value = (value == true) ? "1" : "0";
        }
    }

    [NotMapped]
    [GraphQLIgnore]
    public float FloatValue
    {
        get
        {
            return float.Parse(Value ??= "0");
        }
        set
        {
            Value = value.ToString();
        }
    }
    public F_Condition ShallowCopy()
    {
        return (F_Condition)this.MemberwiseClone();
    }
    public override void SetName()
    {
        DisplayName = Scenario?.DisplayName + "," + Tag?.DisplayName + "," + Operand?.DisplayName + "," + Value;
        Name = Scenario?.Name + "," + Tag?.Name + "," + Operand?.Name + "," + Value;
    }
}
