﻿using Cheetah.Core.Aggregates.Common.Dimentions;
using Cheetah.Core.Aggregates.ConditionAggregate.Dimentions;
using Cheetah.Core.Common;
using System.Drawing;

namespace Cheetah.Core.Aggregates.ConditionAggregate.Facts;
public partial class F_Condition : BaseEntity, IAggregateRoot
{
    public F_Condition()
    {

    }

    #region D_Color
    public virtual D_Color? Color { get; private set; }
    public long? ColorId { get; private set; }
    public F_Condition SetColor(D_Color? color)
    {
        this.Color = color;
        SetColorId(color.Id);
        return this;
    }
    public F_Condition SetColorId(Int64? colorId)
    {
        this.ColorId = colorId;       
        return this;
    }
    #endregion

    #region Tag
    public virtual D_Tag? Tag { get; private set; }
    public long? TagId { get; private set; }
    public F_Condition SetTag(D_Tag? tag)
    {
        this.Tag = tag;
        SetTagId(tag.Id);
        return this;
    }
    public F_Condition SetTagId(Int64? tagId)
    {
        this.TagId = tagId;
        SetNaming();
        return this;
    }
    #endregion

    #region Operand
    public virtual D_Operand? Operand { get; private set; }    
    public long? OperandId { get; private set; }
    public F_Condition SetOperand(D_Operand? operand)
    {
        this.Operand = operand;
        SetOperandId(operand.Id);
        return this;
    }
    public F_Condition SetOperandId(Int64? operandId)
    {
        this.OperandId = operandId;
        SetNaming();
        return this;
    }
    public F_Condition ResetOperand()
    {
        this.OperandId = null;
        this.Operand = null;
        SetNaming();
        return this;
    }
    #endregion

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

    public Boolean? CheckValidation { get; private set; }

    public BaseEntity SetCheckValidation(bool checkValidation)
    {
        CheckValidation = checkValidation;
        return this;
    }

    #region Collections

    #endregion
}
