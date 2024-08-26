using Ardalis.SharedKernel;
using Cheetah.Core.Aggregates.UserAggregate.Dimentions;
using Cheetah.Core.Aggregates.UserAggregate.Links;
using Cheetah.Core.Aggregates.UserAggregate.Specifications;
using Cheetah.UseCases.Queries.User.UserCondition.List;
using NSubstitute;

namespace Cheetah.UnitTest.UseCases.Queries.User.UserCondition.List;

public class ListUsersByCaseConditionHandlerHandle
{
    IReadRepository<L_UserCondition> _userConditionRepository;
    D_User _user1;
    D_User _user2;
    List<D_User> _users;
    ListUsersByCaseConditionQuery _request;
    public ListUsersByCaseConditionHandlerHandle()
    {
        _user1 = D_User.a_sharifi;
        _user2 = D_User.m_sharifi;
        _users = [_user1, _user2];
        _userConditionRepository = Substitute.For<IReadRepository<L_UserCondition>>();
        _userConditionRepository
            .ListAsync(Arg.Any<GetUserByCaseConditionSpec>(), CancellationToken.None)
            .Returns(_users.Select(x => x.Id).ToList());
    }

    [Fact]
    public async Task GetUsersByCaseCondition()
    {
        #region Arrange
        _request = new(UserFilter: _users.Select(x => x.Id), ConditionFilter: []);
        ListUsersByCaseConditionHandler _handle = new(userConditionRepository: _userConditionRepository);
        #endregion

        #region Act
        var _result = await _handle.Handle(request: _request, CancellationToken.None);
        #endregion

        #region Assert
        Assert.Equal(_users.Select(x => x.Id), _result.Value);
        #endregion
    }
}
