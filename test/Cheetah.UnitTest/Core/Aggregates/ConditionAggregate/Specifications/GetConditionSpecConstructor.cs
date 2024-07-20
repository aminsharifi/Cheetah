using Cheetah.Application.Business.Condition.Specifications;
using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.UnitTest.Core.Aggregates.ConditionAggregate.Specifications;

public class GetConditionSpecConstructor
{
    [Fact]
    private void GetConditionSpec()
    {
        #region Arrange
        D_Tag d_Tag = D_Tag.Role;
        D_Operand _operand = D_Operand.Equals;
        String _admin = "Admin";

        F_Condition _condition = new() { Id = 1 };
        _condition.SetTag(d_Tag);
        _condition.SetOperand(_operand);
        _condition.SetValue(_admin);

        List<F_Condition> _conditions = new List<F_Condition>();
        _conditions.Add(_condition);

        List<long> _includeIdList = new();
        _includeIdList.Add(_condition.Id);
        #endregion

        #region Act
        GetConditionSpec _spec = new(IncludeIds: _includeIdList);
        var _filtered = _spec.Evaluate(_conditions);
        #endregion

        #region Assert
        Assert.Contains(_condition, _filtered);
        #endregion
    }
}
