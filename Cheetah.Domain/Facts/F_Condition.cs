namespace Cheetah.Domain.Facts;
public partial class F_Condition : SimpleClass
{    
    public long? TagId { get; set; }
    public virtual D_Tag? Tag { get; set; }

    public long? OperandId { get; set; }
    public virtual D_Operand? Operand { get; set; }

    public String? Value { get; set; }

    public long? ScenarioId { get; set; }
    public virtual F_Scenario? Scenario { get; set; }

    public long? CaseId { get; set; }
    public virtual F_Case? Case { get; set; }

    public long? EndorsementItemId { get; set; }
    [ForeignKey(nameof(EndorsementItemId))]
    public virtual F_EndorsementItem? EndorsementItem { get; set; }

    [NotMapped]
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
        //DisplayName = Scenario?.DisplayName + "," + Tag?.DisplayName + "," + Operand?.DisplayName + "," + Value;
        //Name = Scenario?.Name + "," + Tag?.Name + "," + Operand?.Name + "," + Value;
    }
}
