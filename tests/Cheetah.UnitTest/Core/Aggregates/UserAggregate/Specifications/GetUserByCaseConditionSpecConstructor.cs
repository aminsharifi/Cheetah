using Cheetah.Core.Aggregates.CaseAggregate.Links;
using Cheetah.Core.Aggregates.UserAggregate.Dimentions;
using Cheetah.Core.Aggregates.UserAggregate.Links;
using Cheetah.Core.Aggregates.UserAggregate.Specifications;

namespace Cheetah.UnitTest.Core.Aggregates.UserAggregate.Specifications;

public class GetUserByCaseConditionSpecConstructor
{
    [Fact]
    private void GetUserByCaseCondition()
    {
        #region Arrange

        D_User _user1 = new() { Id = 1 };
        D_User _user2 = new() { Id = 2 };
        List<D_User> _listUser = new();
        _listUser.Add(_user1);
        _listUser.Add(_user2);

        L_UserCondition _userCondition1 = (L_UserCondition)new L_UserCondition()
            .SetFirstId(_user1.Id)
            .SetSecondId(1);

        L_UserCondition _userCondition2 = (L_UserCondition)new L_UserCondition()
            .SetFirstId(_user1.Id)
            .SetSecondId(2);

        L_UserCondition _userCondition3 = (L_UserCondition)new L_UserCondition()
          .SetFirstId(_user2.Id)
          .SetSecondId(1);

        List<L_UserCondition> _listUserCondition = new();

        _listUserCondition.Add(_userCondition1);
        _listUserCondition.Add(_userCondition2);
        _listUserCondition.Add(_userCondition3);

        L_CaseCondition _caseCondition = (L_CaseCondition)new L_CaseCondition()
            .SetFirstId(2000)
            .SetSecondId(2);

        List<L_CaseCondition> _listCaseCondition = new();
        _listCaseCondition.Add(_caseCondition);


        #endregion

        #region Act

        GetUserByCaseConditionSpec _spec = new(UserFilter: _listUser.Select(x => x.Id),
            ConditionFilter: _listCaseCondition.Select(x => x.SecondId!.Value));

        var _filtered = _spec.Evaluate(_listUserCondition);

        #endregion

        #region Assert

        Assert.Multiple(
        () => Assert.Contains(_user1.Id, _filtered),
        () => Assert.DoesNotContain(_user2.Id, _filtered));

        #endregion
    }
}
