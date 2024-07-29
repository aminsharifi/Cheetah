using Ardalis.SharedKernel;
using Cheetah.Application.Business.Queries.Case.CaseTaskUser.List;
using Cheetah.Domain.Aggregates.CaseAggregate.Links;
using Cheetah.Domain.Aggregates.CaseAggregate.Links.Specifications;
using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Facts;
using NSubstitute;

namespace Cheetah.UnitTest.Application.Queries.Case.CaseTaskUser.List;

public class ListCaseTaskUserHandlerHandle
{
    [Fact]
    public async Task Validate()
    {
        #region Arrange
        IReadRepository<L_CaseTaskUser> _repository = Substitute.For<IReadRepository<L_CaseTaskUser>>();
        F_Case _case = new() { Id = 1 };
        F_Task _task = F_Task.Sample_Scenario_Requestor;
        D_User _user = D_User.a_sharifi;

        L_CaseTaskUser _caseTaskUser = new L_CaseTaskUser();
        _caseTaskUser.SetCase(_case);
        _caseTaskUser.SetTask(_task);
        _caseTaskUser.SetUser(_user);

        List<L_CaseTaskUser> _listCaseTaskUser = new();
        _listCaseTaskUser.Add(_caseTaskUser);

        ListCaseTaskUserQuery _listCaseTaskUserQuery = new(
            caseId: _caseTaskUser.Case!.Id,
            taskId: _caseTaskUser.Task!.Id);

        _repository
            .ListAsync(
            specification: Arg.Any<GetByCaseAndTaskSpec>()
            , CancellationToken.None)
            .Returns(_listCaseTaskUser);

        #endregion

        #region Act
        var _listCaseTaskUserHandler = new ListCaseTaskUserHandler(repository: _repository);
        var _result = await _listCaseTaskUserHandler.Handle(
            request: _listCaseTaskUserQuery,
            CancellationToken.None);
        #endregion

        #region Assert
        Assert.True(_result.IsSuccess);
        Assert.Single(_result.Value);
        Assert.Contains(_caseTaskUser, _listCaseTaskUser);
        #endregion
    }
}
