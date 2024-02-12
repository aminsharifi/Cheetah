namespace Cheetah.Domain.Entities.Facts;
public partial class F_Condition : BaseEntity
{
    [NotMapped]
    private long? _tagId;

    public long? TagId
    {
        get { return _tagId; }
        set { _tagId = value; SetName(); }
    }
    public virtual D_Tag? Tag { get; set; }

    [NotMapped]
    private long? _operandId;
    public long? OperandId
    {
        get { return _operandId; }
        set { _operandId = value; SetName(); }
    }
    public virtual D_Operand? Operand { get; set; }

    [NotMapped]
    private string? _value;

    public string? Value
    {
        get { return _value; }
        set { _value = value; SetName(); }
    }

    public long? CaseId { get; set; }
    public virtual F_Case? Case { get; set; }

    public long? WorkItemId { get; set; }
    public virtual F_WorkItem? WorkItem { get; set; }

    public long? FlowId { get; set; }
    public virtual F_Flow? Flow { get; set; }

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
        DisplayName = Tag?.DisplayName + " " + Operand?.DisplayName + " " + Value + " است.";
        Name = Tag?.Name + " " + Operand?.Name + " " + Value + " است.";
    }
}
