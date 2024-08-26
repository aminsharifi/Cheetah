using Ardalis.SharedKernel;
using Cheetah.Core.Aggregates.CaseAggregate.Facts;
using Cheetah.Core.Aggregates.CaseAggregate.Links;
using Cheetah.Core.Aggregates.ProcessAggregate.Facts;
using Cheetah.Core.Aggregates.UserAggregate.Dimentions;
using Cheetah.Core.Common.Specifications;
using Cheetah.UseCases.Queries.Case.CaseTaskUser.Get;
using NSubstitute;

namespace Cheetah.UnitTest.UseCases.Queries.Case.CaseTaskUser.Get;

public class GetCaseTaskUserHandlerHandle
{
    [Fact]
    public async Task Validate()
    {
        #region Arrange
        IReadRepository<F_Case> _caseRepository = Substitute.For<IReadRepository<F_Case>>();
        IReadRepository<F_Task> _taskRepository = Substitute.For<IReadRepository<F_Task>>();
        IReadRepository<D_User> _userRepository = Substitute.For<IReadRepository<D_User>>();

        F_Case _case = new() { Id = 1 };
        F_Task _task = F_Task.Sample_Scenario_Requestor;
        D_User _user = D_User.a_sharifi;

        L_CaseTaskUser _caseTaskUser = new();
        _caseTaskUser.SetCase(_case);
        _caseTaskUser.SetTask(_task);
        _caseTaskUser.SetUser(_user);

        GetCaseTaskUserQuery _request = new GetCaseTaskUserQuery(input: _caseTaskUser);

        _caseRepository
            .FirstOrDefaultAsync(Arg.Any<GetIdEntitySpec<F_Case>>(), CancellationToken.None)
            .Returns(_case.Id);

        _taskRepository
            .FirstOrDefaultAsync(Arg.Any<GetIdEntitySpec<F_Task>>(), CancellationToken.None)
            .Returns(_task.Id);

        _userRepository
              .FirstOrDefaultAsync(Arg.Any<GetIdEntitySpec<D_User>>(), CancellationToken.None)
            .Returns(_user.Id);

        GetCaseTaskUserHandler _getCaseTaskUserHandler = new GetCaseTaskUserHandler(
            caseRepository: _caseRepository,
            taskRepository: _taskRepository,
            userRepository: _userRepository);

        #endregion

        #region Act
        var _result = await _getCaseTaskUserHandler.Handle(request: _request, CancellationToken.None);
        #endregion

        #region Assert

        Assert.Multiple(
            () => Assert.Equal(_case.Id, _result.Value.FirstId),
            () => Assert.Equal(_task.Id, _result.Value.SecondId),
            () => Assert.Equal(_user.Id, _result.Value.ThirdId));

        #endregion
    }
}
