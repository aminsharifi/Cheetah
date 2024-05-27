namespace Cheetah.Domain.Entities.Facts;
public partial class F_Condition : BaseEntity, IAggregateRoot
{
    public F_Condition()
    {

    }
    public F_Condition(long? tagId, long? operandId)
    {
        TagId = tagId;
        OperandId = operandId;
    }

    public F_Condition(String name, String displayName,
        Int64 sortIndex, Int64 eRPCode, long tagId, long operandId, string value) :
        base(name, displayName, sortIndex, eRPCode)
    {
        SetConditionValue(tagId, operandId, value);
    }

    public F_Condition(Int64 id, String name, String displayName,
        Int64 sortIndex, Int64 eRPCode, long tagId, long operandId, string value) :
        base(id, name, displayName, sortIndex, eRPCode)
    {
        SetConditionValue(tagId, operandId, value);
    }

    public void SetConditionValue(long? tagId, long? operandId, string value)
    {
        TagId = tagId;
        OperandId = operandId;
        Value = value;
    }
    public void SetConditionValue(D_Tag? tag, D_Operand? operand, string value)
    {
        Tag = tag;
        Operand = operand;
        Value = value;
    }

    private long? _tagId;
    public long? TagId
    {
        get { return _tagId; }
        private set { _tagId = value; SetName(); }
    }

    public virtual D_Tag? Tag { get; private set; }

    public void SetTag(D_Tag? tag)
    {
        Tag = tag;
    }

    private long? _operandId;
    public long? OperandId
    {
        get { return _operandId; }
        private set { _operandId = value; SetName(); }
    }

    public void ResetOperand()
    {
        OperandId = null;
        Operand = null;
    }
    public void SetOperand(long? operandId)
    {
        OperandId = operandId;
    }
    public void SetOperand(D_Operand? operand)
    {
        Operand = operand;
    }
    public virtual D_Operand? Operand { get; private set; }

    private string? _value;

    public string? Value
    {
        get { return _value; }
        private set { _value = value; SetName(); }
    }

    #region PublicProperties
    [NotMapped]
    public string? PublicValue
    {
        get { return Value; }
        set { Value = value; }
    }
    [NotMapped]
    public long? PublicOperandId
    {
        get { return OperandId; }
        set { OperandId = value; }
    }
    [NotMapped]
    public bool PublicBooleanValue
    {
        get { return BooleanValue; }
        set { BooleanValue = value; }
    }
    [NotMapped]
    public float? PublicFloatValue
    {
        get { return FloatValue; }
        set { FloatValue = value; }
    }
    [NotMapped]
    public DateTime? PublicDateTimeOffsetValue
    {
        get
        {
            return DateTimeOffsetValue;
        }
        set { DateTimeOffsetValue = value; }
    }
    [NotMapped]
    public long? PublicTagId
    {
        get { return TagId; }
        set { TagId = value; }
    }
    #endregion

    public bool BooleanValue
    {
        get
        {
            return Value == "1";
        }
        private set
        {
            Value = value == true ? "1" : "0";
        }
    }

    public float? FloatValue
    {
        get
        {
            float _returnvalue;
            float.TryParse(Value, out _returnvalue);

            return _returnvalue;
        }
        private set
        {
            Value = value.ToString();
        }
    }
    [NotMapped]
    public DateTime? DateTimeOffsetValue
    {
        get
        {
            DateTime _returnvalue;
            DateTime.TryParse(Value, out _returnvalue);
            if (_returnvalue == DateTime.MinValue)
                _returnvalue = DateTime.Today;
            return _returnvalue;
        }
        private set
        {
            Value = value?.ToString();
        }
    }
    public F_Condition ShallowCopy()
    {
        return (F_Condition)MemberwiseClone();
    }

    public override void SetName()
    {
        String _name = default!, _displayName = default!;

        if (Tag?.Name is not null && Operand?.Name is not null && Value is not null)
        {
            _name = Tag?.Name + " " + Operand?.Name + " " + Value;
        }
        if (Tag?.DisplayName is not null && Operand?.DisplayName is not null && Value is not null)
        {
            _displayName = Tag?.DisplayName + " " + Operand?.DisplayName + " " + Value + " است.";
        }
        SetNameAndDisplayName(_name, _displayName);
    }

    #region Collections

    #endregion
}
