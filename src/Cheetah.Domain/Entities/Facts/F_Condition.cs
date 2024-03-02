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
    public float? FloatValue
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
        if (Tag?.Name is not null && Operand?.Name is not null && Value is not null)
        {
            Name = Tag?.Name + " " + Operand?.Name + " " + Value;
        }        
        if (Tag?.DisplayName is not null && Operand?.DisplayName is not null && Value is not null)
        {
            DisplayName = Tag?.DisplayName + " " + Operand?.DisplayName + " " + Value + " است.";
        }
    }
}
