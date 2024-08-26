using Cheetah.Core.Aggregates.UserAggregate.Dimentions;
using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Common.Specifications;

namespace Cheetah.UnitTest.Core.Common.Specifications;

public class GetEntitySpecConstructor
{
    [Fact]
    private void GetEntityWithId()
    {
        #region Arrange

        D_User _user1 = (D_User)new D_User().SetId(1).SetERPCode(10001);
        D_User _user2 = (D_User)new D_User().SetId(2).SetERPCode(10002);
        D_User _user3 = (D_User)new D_User().SetId(3).SetERPCode(10003);
        List<D_User> _list_User = new List<D_User>();
        _list_User.Add(_user1);
        _list_User.Add(_user2);
        _list_User.Add(_user3);
        #endregion

        #region Act
        GetEntitySpec<D_User> _spec = new GetEntitySpec<D_User>(2);
        var _filtered = _spec.Evaluate(_list_User);
        #endregion

        #region Assert
        Assert.Multiple(
            () => Assert.Single(_filtered),
            () => Assert.Contains(_user2, _filtered),
            () => Assert.DoesNotContain(_user3, _filtered));
        #endregion
    }
    [Fact]
    private void GetEntityWithClass()
    {
        #region Arrange
        D_User _user1 = (D_User)new D_User().SetId(1).SetERPCode(10001);
        D_User _user2 = (D_User)new D_User().SetId(2).SetERPCode(10002);
        D_User _user3 = (D_User)new D_User().SetId(3).SetERPCode(10003);
        List<D_User> _list_User = new List<D_User>();
        _list_User.Add(_user1);
        _list_User.Add(_user2);
        _list_User.Add(_user3);
        SimpleClassDTO _input = new SimpleClassDTO() { ERPCode = 10002 };
        #endregion

        #region Act
        GetEntitySpec<D_User> _spec = new GetEntitySpec<D_User>(_input);
        var _filtered = _spec.Evaluate(_list_User);
        #endregion

        #region Assert
        Assert.Multiple(
            () => Assert.Single(_filtered),
            () => Assert.Contains(_user2, _filtered),
            () => Assert.DoesNotContain(_user3, _filtered));
        #endregion
    } 
}
