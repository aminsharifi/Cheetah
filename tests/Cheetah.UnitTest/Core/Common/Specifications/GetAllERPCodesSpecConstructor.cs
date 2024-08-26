using Cheetah.Core.Aggregates.UserAggregate.Dimentions;
using Cheetah.Core.Common.Specifications;

namespace Cheetah.UnitTest.Core.Common.Specifications;

public class GetAllERPCodesSpecConstructor
{
    [Fact]
    private void GetAllERPCodes()
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
        GetAllERPCodesSpec<D_User> _spec = new();
        var _filtered = _spec.Evaluate(_list_User);
        #endregion

        #region Assert
        Assert.Equal(_list_User.Select(x => x.ERPCode), _filtered);
        #endregion
    }
}
