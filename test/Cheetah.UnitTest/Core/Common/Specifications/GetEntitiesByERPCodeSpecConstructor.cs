using Cheetah.Domain.Common.Specifications;
using Cheetah.Domain.Entities.Dimentions;

namespace Cheetah.UnitTest.Core.Common.Specifications;

public class GetEntitiesByERPCodeSpecConstructor
{
    [Fact]
    private void GetEntitiesByERPCode()
    {
        #region Arrange
        D_User _user1 = (D_User)new D_User().SetId(1).SetERPCode(10001);
        D_User _user2 = (D_User)new D_User().SetId(2).SetERPCode(10002);
        D_User _user3 = (D_User)new D_User().SetId(3).SetERPCode(10003);
        List<D_User> _list_User = new List<D_User>();
        _list_User.Add(_user1);
        _list_User.Add(_user2);
        _list_User.Add(_user3);
        List<long?> _erpCodes = new List<long?>();
        _erpCodes.Add(10001);
        _erpCodes.Add(10003);
        #endregion

        #region Act
        GetEntitiesByERPCodeSpec<D_User> _spec = new GetEntitiesByERPCodeSpec<D_User>(_erpCodes);
        var _filtered = _spec.Evaluate(_list_User);
        #endregion

        #region Assert
        Assert.Multiple(
            () => Assert.Contains(_user1, _filtered),
            () => Assert.DoesNotContain(_user2, _filtered),
            () => Assert.Contains(_user3, _filtered));
        #endregion
    }
}
