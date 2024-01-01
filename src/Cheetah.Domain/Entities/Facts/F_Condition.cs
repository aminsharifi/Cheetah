namespace Cheetah.Domain.Entities.Facts;
public class F_Condition : SimpleClass
{
    public long? TagId { get; set; }
    public virtual D_Tag? Tag { get; set; }

    public long? OperandId { get; set; }
    public virtual D_Operand? Operand { get; set; }

    public string? Value { get; set; }

    public long? ScenarioId { get; set; }
    public virtual F_Scenario? Scenario { get; set; }

    public long? CaseId { get; set; }
    public virtual F_Case? Case { get; set; }

    public long? EndorsementItemId { get; set; }
    [ForeignKey(nameof(EndorsementItemId))]
    public virtual F_EndorsementItem? EndorsementItem { get; set; }

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

    #region Values

    public static readonly F_Condition Price =
        new F_Condition
        {
            Id = 1,
            ERPCode = 1,
            SortIndex = 1,
            Name = "Price",
            DisplayName = "مبلغ",
            TagId = 301,
            OperandId = 3,
            Value = "0",
            ScenarioId = 1
        };
    public static readonly F_Condition One =
        new F_Condition
        {
            Id = 2,
            Name = nameof(One),
            ERPCode = 2,
            SortIndex = 1,
            TagId = 201,
            OperandId = 1,
            Value = "0",
            EndorsementItemId = 1
        };

    public static readonly F_Condition Two =
        new F_Condition
        {
            Id = 3,
            Name = nameof(Two),
            ERPCode = 3,
            SortIndex = 1,
            TagId = 201,
            OperandId = 1,
            Value = "0",
            EndorsementItemId = 2
        };

    public static readonly F_Condition Three =
        new F_Condition
        {
            Id = 4,
            Name = nameof(Three),
            ERPCode = 4,
            SortIndex = 1,
            TagId = 203,
            OperandId = 1,
            Value = "0",
            EndorsementItemId = 3
        };

    public static readonly F_Condition Four =
        new F_Condition
        {
            Id = 5,
            Name = nameof(Four),
            ERPCode = 5,
            SortIndex = 1,
            TagId = 202,
            OperandId = 1,
            Value = "1",
            EndorsementItemId = 4
        };
    #endregion
}
