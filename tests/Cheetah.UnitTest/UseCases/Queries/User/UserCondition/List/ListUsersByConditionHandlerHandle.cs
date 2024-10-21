using Ardalis.SharedKernel;
using Cheetah.Core.Aggregates.UserAggregate.Dimentions;
using Cheetah.Core.Aggregates.UserAggregate.Links;
using Cheetah.Core.Aggregates.UserAggregate.Specifications;
using Cheetah.UseCases.Queries.User.UserCondition.Get;
using Cheetah.UseCases.Queries.User.UserCondition.List;
using NSubstitute;

namespace Cheetah.UnitTest.UseCases.Queries.User.UserCondition.List;

public class ListUsersByConditionHandlerHandle
{
    IReadRepository<L_UserCondition> _userConditionRepository;
    ListUsersByConditionQuery _request;
    D_User _user1;
    D_User _user2;
    List<D_User> _users;
    public ListUsersByConditionHandlerHandle()
    {
        _user1 = D_User.a_sharifi;
        _user2 = D_User.m_sharifi;
        _users = [_user1, _user2];
        _userConditionRepository = Substitute.For<IReadRepository<L_UserCondition>>();
        _userConditionRepository
            .ListAsync(Arg.Any<GetUserByConditionSpec>(), CancellationToken.None)
            .Returns(_users.Select(x => x.Id).ToList());
    }
    [Fact]
    public async Task ListUsersByCondition()
    {
        #region Arrange
        _request = new([]);
        ListUsersByConditionHandler _handle = new(userConditionRepository: _userConditionRepository);
        #endregion

        #region Act
        var _result = await _handle.Handle(request: _request, CancellationToken.None);
        #endregion

        #region Assert
        Assert.Equal(_users.Select(x => x.Id), _result.Value);
        #endregion
    }
}
