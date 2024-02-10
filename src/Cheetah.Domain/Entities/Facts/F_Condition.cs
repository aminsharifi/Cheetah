namespace Cheetah.Domain.Entities.Facts;
public partial class F_Condition : BaseEntity
{
    public long? TagId { get; set; }
    public virtual D_Tag? Tag { get; set; }

    public long? OperandId { get; set; }
    public virtual D_Operand? Operand { get; set; }

    public string? Value { get; set; }

    public long? CaseId { get; set; }
    public virtual F_Case? Case { get; set; }

    public long? WorkItemId { get; set; }
    public virtual F_WorkItem? WorkItem { get; set; }

    public long? ActionId { get; set; }  
    public virtual F_Action? Action { get; set; }

    [NotMapped]
    public bool BooleanValue
    {
        get
        {
            return Value == "1";
        }
        set
        {
            Value = value == true ? "1" : "0";
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
        return (F_Condition)MemberwiseClone();
    }
    public override void SetName()
    {
        //DisplayName = Scenario?.DisplayName + "," + Tag?.DisplayName + "," + Operand?.DisplayName + "," + Value;
        //Name = Scenario?.Name + "," + Tag?.Name + "," + Operand?.Name + "," + Value;
    }
}
