using Cheetah.Core.Aggregates.UserAggregate.Links;
using Cheetah.Core.Aggregates.UserAggregate.Specifications;
using Cheetah.Core.Entities.Dimentions;
using Cheetah.Core.Entities.Facts;

namespace Cheetah.UnitTest.Core.Aggregates.UserAggregate.Specifications;

public class GetUserByConditionSpecConstructor
{
    [Fact]
    private void GetUserByCondition()
    {
        #region Arrange
        D_User _user1 = new() { Id = 1 };
        D_User _user2 = new() { Id = 2 };
        D_User _user3 = new() { Id = 3 };
        List<D_User> _listUser = new();
        _listUser.Add(_user1);
        _listUser.Add(_user2);
        _listUser.Add(_user3);

        F_Condition _condition1 = new() { Id = 1 };
        F_Condition _condition2 = new() { Id = 2 };
        List<F_Condition> _includedCondition = new();
        _includedCondition.Add(_condition1);


        L_UserCondition _userCondition1 = (L_UserCondition)new L_UserCondition()
            .SetFirstId(_user1.Id)
            .SetSecondId(_condition1.Id);

        L_UserCondition _userCondition2 = (L_UserCondition)new L_UserCondition()
            .SetFirstId(_user1.Id)
            .SetSecondId(_condition2.Id);

        L_UserCondition _userCondition3 = (L_UserCondition)new L_UserCondition()
          .SetFirstId(_user2.Id)
          .SetSecondId(_condition1.Id);

        L_UserCondition _userCondition4 = (L_UserCondition)new L_UserCondition()
        .SetFirstId(_user3.Id)
        .SetSecondId(_condition2.Id);

        List<L_UserCondition> _listUserCondition = new();

        _listUserCondition.Add(_userCondition1);
        _listUserCondition.Add(_userCondition2);
        _listUserCondition.Add(_userCondition3);

        #endregion

        #region Act
        GetUserByConditionSpec _spec = new(PerformerConditions: _includedCondition.Select(x => x.Id));
        var _filtered = _spec.Evaluate(_listUserCondition);
        #endregion

        #region Assert
        Assert.Multiple
            (
            () => Assert.Contains(_user1.Id, _listUserCondition.Select(x => x.FirstId)),
            () => Assert.Contains(_user2.Id, _listUserCondition.Select(x => x.FirstId)),
            () => Assert.DoesNotContain(_user3.Id, _listUserCondition.Select(x => x.FirstId))
            );
        #endregion
    }
}
