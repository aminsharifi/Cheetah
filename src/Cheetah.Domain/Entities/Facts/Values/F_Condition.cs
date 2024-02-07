namespace Cheetah.Domain.Entities.Facts;
public partial class F_Condition
{
    #region Values

    public static readonly F_Condition Price =
        new()
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
        new ()
        {
            Id = 2,
            Name = nameof(One),
            ERPCode = 2,
            SortIndex = 1,
            TagId = 201,
            OperandId = 1,
            Value = "0",
            ActionId = 1
        };

    public static readonly F_Condition Two =
        new()
        {
            Id = 3,
            Name = nameof(Two),
            ERPCode = 3,
            SortIndex = 1,
            TagId = 201,
            OperandId = 1,
            Value = "0",
            ActionId = 2
        };

    public static readonly F_Condition Three =
        new()
        {
            Id = 4,
            Name = nameof(Three),
            ERPCode = 4,
            SortIndex = 1,
            TagId = 203,
            OperandId = 1,
            Value = "0",
            ActionId = 3
        };

    public static readonly F_Condition Four =
        new()
        {
            Id = 5,
            Name = nameof(Four),
            ERPCode = 5,
            SortIndex = 1,
            TagId = 202,
            OperandId = 1,
            Value = "1",
            ActionId = 4
        };
    #endregion
}
