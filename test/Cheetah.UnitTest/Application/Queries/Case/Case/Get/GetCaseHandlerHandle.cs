using Ardalis.SharedKernel;
using Cheetah.Application.Business.Queries.Case.Case.Get;
using Cheetah.Domain.Aggregates.ConditionAggregate.DTOs;
using Cheetah.Domain.Common.DTOs;
using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Facts;
using MapsterMapper;
using MediatR;
using NSubstitute;

namespace Cheetah.UnitTest.Application.Queries.Case.Case.Get;

public class GetCaseHandlerHandle
{
    [Fact]
    public async Task GetRelatedCase()
    {
        #region Arrange
        IReadRepository<D_User> _userRepository = Substitute.For<IReadRepository<D_User>>();
        IReadRepository<D_Process> _processRepository = Substitute.For<IReadRepository<D_Process>>();
        IReadRepository<F_Condition> _conditionRepository = Substitute.For<IReadRepository<F_Condition>>();
        ISender _iSender = Substitute.For<ISender>();
        IMapper _iMapper = Substitute.For<IMapper>();

        #region GetCaseQuery
        SimpleClassDTO _case = new SimpleClassDTO();
        SimpleClassDTO _creator = new SimpleClassDTO();
        SimpleClassDTO _requestor = new SimpleClassDTO();
        SimpleClassDTO _process = new SimpleClassDTO();
        List<ConditionDTO> _caseConditions = new List<ConditionDTO>();
        SimpleClassDTO _workItemUser = new SimpleClassDTO();
        List<ConditionDTO> _workItemConditions = new List<ConditionDTO>();
        SimpleClassDTO _workItemBase = new SimpleClassDTO();

        GetCaseQuery _getCaseQuery = new GetCaseQuery(
            Case: _case, Creator: _creator, Requestor: _requestor,
            Process: _process, CaseConditions: _caseConditions,
            WorkItemUser: _workItemUser, WorkItemConditions: _workItemConditions,
            WorkItemBase: _workItemBase);
        #endregion
        #endregion

        #region Act

        GetCaseHandler _getCaseHandler = new GetCaseHandler(userRepository: _userRepository,
            processRepository: _processRepository, conditionRepository: _conditionRepository,
            iSender: _iSender, iMapper: _iMapper);

        var _handle = await _getCaseHandler.Handle(_getCaseQuery, Arg.Any<CancellationToken>());
        #endregion

        #region Assert

        Assert.True(_handle.IsSuccess);

        #endregion
    }
}
