using Ardalis.SharedKernel;
using Cheetah.Application.Business.Queries.Case.Case.Get;
using Cheetah.Domain.Aggregates.ConditionAggregate.DTOs;
using Cheetah.Domain.Common.DTOs;
using Cheetah.Domain.Common.Specifications;
using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Facts;
using Mapster;
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

        F_Case _case = (F_Case)new F_Case()
            .SetId(1)
            .SetERPCode(1);

        SimpleClassDTO _caseDTO = _case.Adapt<SimpleClassDTO>();

        D_User _creator = D_User.a_sharifi;
        SimpleClassDTO _creatorDTO = _creator.Adapt<SimpleClassDTO>();

        D_User _requestor = D_User.a_sharifi;
        SimpleClassDTO _requestorDTO = _requestor.Adapt<SimpleClassDTO>();

        D_User _workItemUser = D_User.a_sharifi;
        SimpleClassDTO _workItemUserDTO = _workItemUser.Adapt<SimpleClassDTO>();


        D_Process _process = D_Process.SampleProcess;
        SimpleClassDTO _processDTO = _process.Adapt<SimpleClassDTO>();

        List<ConditionDTO> _caseConditionsDTO = new List<ConditionDTO>();
        List<ConditionDTO> _workItemConditionsDTO = new List<ConditionDTO>();
        SimpleClassDTO _workItemBaseDTO = new SimpleClassDTO();

        GetCaseQuery _getCaseQuery = new GetCaseQuery(
            Case: _caseDTO, Creator: _creatorDTO, Requestor: _requestorDTO,
            Process: _processDTO, CaseConditions: _caseConditionsDTO,
            WorkItemUser: _workItemUserDTO, WorkItemConditions: _workItemConditionsDTO,
            WorkItemBase: _workItemBaseDTO);

        _userRepository
            .FirstOrDefaultAsync(Arg.Any<GetIdEntitySpec<D_User>>(), Arg.Any<CancellationToken>())
            .Returns(_creator.Id);

        _processRepository
            .FirstOrDefaultAsync(Arg.Any<GetIdEntitySpec<D_Process>>(), Arg.Any<CancellationToken>())
            .Returns(_process.Id);

        #endregion

        #endregion

        #region Act

        GetCaseHandler _getCaseHandler = new GetCaseHandler(userRepository: _userRepository,
         processRepository: _processRepository, conditionRepository: _conditionRepository,
         iSender: _iSender, iMapper: _iMapper);

        var _result = await _getCaseHandler.Handle(_getCaseQuery, CancellationToken.None);

        #endregion

        #region Assert

        Assert.True(_result.IsSuccess);

        Assert.Multiple(
            () => Assert.Equal(_requestor.Id, _result.Value.RequestorId),
            () => Assert.Equal(_creator.Id, _result.Value.CreatorId),
            () => Assert.Equal(_process.Id, _result.Value.ProcessId),
            () => Assert.Equal(_case.ERPCode, _result.Value.ERPCode));

        Assert.Single(_result.Value.WorkItems!);

        Assert.Equal(_workItemUser.Id, _result.Value.WorkItems!.Select(x => x.UserId).First());

        #endregion

    }
}
