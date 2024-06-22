namespace Cheetah.Domain.Entities.Facts;
public partial class F_Condition : BaseEntity, IAggregateRoot
{
    public F_Condition()
    {

    }

    public F_Condition SetTag(D_Tag? tag)
    {
        this.Tag = tag;
        return this;
    }
    public F_Condition SetTagId(Int64? tagId)
    {
        this.TagId = tagId;
        return this;
    }
    public F_Condition SetOperand(D_Operand? operand)
    {
        this.Operand = operand;
        return this;
    }
    public F_Condition SetOperandId(Int64? operandId)
    {
        this.OperandId = operandId;
        return this;
    }
    public F_Condition SetValue(string value)
    {
        this.Value = value;
        return this;
    }
    public F_Condition SetConditionValue(D_Tag? tag, D_Operand? operand, string value)
    {
        this
            .SetTag(tag)
            .SetOperand(operand)
            .SetValue(value);

        return this;
    }
    
    public F_Condition ResetOperand()
    {
        this.OperandId = null;
        this.Operand = null;
        return this;
    }
    public F_Condition SetNaming()
    {
        String _name = default!, _displayName = default!;

        if (this?.Name is not null && this?.Name is not null && this is not null)
        {
            _name = this?.Name + " " + this?.Name + " " + this?.Value;
        }
        if (this?.DisplayName is not null && this?.DisplayName is not null && this?.Value is not null)
        {
            _displayName = this.Tag?.DisplayName + " " + this.Operand?.DisplayName + " " + this?.Value + " است.";
        }
        return this;
    }

    private long? _tagId;
    public long? TagId
    {
        get { return _tagId; }
        private set { _tagId = value; SetNaming(); }
    }

    public virtual D_Tag? Tag { get; private set; }

    private long? _operandId;
    public long? OperandId
    {
        get { return _operandId; }
        private set { _operandId = value; SetNaming(); }
    }


    public virtual D_Operand? Operand { get; private set; }

    private string? _value;

    public string? Value
    {
        get { return _value; }
        private set { _value = value; SetNaming(); }
    }

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

    public F_Condition ShallowCopy()
    {
        return (F_Condition)MemberwiseClone();
    }

    #region Collections

    #endregion
}
