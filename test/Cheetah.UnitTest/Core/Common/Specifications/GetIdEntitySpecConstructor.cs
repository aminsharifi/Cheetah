using Cheetah.Domain.Common.DTOs;
using Cheetah.Domain.Common.Specifications;
using Cheetah.Domain.Entities.Dimentions;

namespace Cheetah.UnitTest.Core.Common.Specifications;

public class GetIdEntitySpecConstructor
{
    [Fact]
    private void GetIdEntity()
    {
        #region Arrange

        D_User _user1 = (D_User)new D_User().SetId(1).SetERPCode(10001);
        D_User _user2 = (D_User)new D_User().SetId(2).SetERPCode(10002);
        D_User _user3 = (D_User)new D_User().SetId(3).SetERPCode(10003);
        List<D_User> _list_User = new List<D_User>();
        _list_User.Add(_user1);
        _list_User.Add(_user2);
        _list_User.Add(_user3);
        SimpleClassDTO _simpleClassDTO = new SimpleClassDTO() { ERPCode = 10002 };
        #endregion

        #region Act
        GetIdEntitySpec<D_User> _spec = new GetIdEntitySpec<D_User>(_simpleClassDTO);
        var _filtered = _spec.Evaluate(_list_User);
        #endregion

        #region Assert
        Assert.Multiple(
            () => Assert.Single(_filtered),
            () => Assert.Contains(_user2.Id, _filtered),
            () => Assert.DoesNotContain(_user3.Id, _filtered));
        #endregion
    }
}
