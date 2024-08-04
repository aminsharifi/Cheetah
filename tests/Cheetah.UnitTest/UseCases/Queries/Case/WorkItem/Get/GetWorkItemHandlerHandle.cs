using Ardalis.Result;
using Ardalis.SharedKernel;
using Cheetah.Core.Aggregates.CaseAggregate.Facts.Specifications;
using Cheetah.Core.Aggregates.ConditionAggregate.DTOs;
using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Entities.Dimentions;
using Cheetah.Core.Entities.Facts;
using Cheetah.UseCases.Queries.Case.WorkItem.Get;
using Cheetah.UseCases.Queries.Condition.Get;
using Mapster;
using MediatR;
using NSubstitute;

namespace Cheetah.UnitTest.UseCases.Queries.Case.WorkItem.Get;

public class GetWorkItemHandlerHandle
{
    IReadRepository<D_User> _userRepository;
    IReadRepository<F_WorkItem> _workItemRepository;
    ISender _iSender;
    F_WorkItem _workItem;
    SimpleClassDTO _workItemUser;
    List<ConditionDTO> _workItemConditions;
    bool _rebase;
    GetWorkItemQuery _getWorkItemQuery;
    GetWorkItemHandler _getWorkItemHandler;
    SimpleClassDTO _workItemDTO;
    public GetWorkItemHandlerHandle()
    {
        _userRepository = Substitute.For<IReadRepository<D_User>>();
        _workItemRepository = Substitute.For<IReadRepository<F_WorkItem>>();
        _iSender = Substitute.For<ISender>();
        _workItem = (F_WorkItem)new F_WorkItem()
            .SetId(1);
        _workItemUser = new() { Id = 1 };
        _workItemConditions = [];
        ConditionDTO _conditionDTO = new()
        {
            Base = F_Condition.Approve.Adapt<BaseClassWithNameDTO>()
        };
        _workItemConditions.Add(_conditionDTO);
        _rebase = false;
        _workItemRepository
            .FirstOrDefaultAsync(Arg.Any<GetWorkItemSpec>(), CancellationToken.None)
            .Returns(_workItem);
        _iSender
            .Send(Arg.Any<GetConditionIdQuery>())
            .Returns(Result.Success(F_Condition.Approve.Id));
    }
    private void CreateWorkItemHandler()
    {
        _workItemDTO = _workItem.Adapt<SimpleClassDTO>();

        _getWorkItemQuery = new GetWorkItemQuery(
            WorkItem: _workItemDTO,
            WorkItemUser: _workItemUser,
            WorkItemConditions: _workItemConditions,
            Rebase: _rebase);

        _getWorkItemHandler = new GetWorkItemHandler(
            userRepository: _userRepository,
            workItemRepository: _workItemRepository,
            iSender: _iSender);
    }

    [Fact]
    public async Task GetWorkItemHandlerConflict()
    {
        #region Arrange        

        _workItem
            .SetLastModified(DateTime.UtcNow);

        CreateWorkItemHandler();

        #endregion

        #region Act

        var _result = await _getWorkItemHandler.Handle(
            request: _getWorkItemQuery, cancellationToken: CancellationToken.None);

        #endregion

        #region Assert

        Assert.True(_result.IsConflict());

        #endregion
    }
    [Fact]
    public async Task GetConditionFromWorkItemHandler()
    {
        #region Arrange

        CreateWorkItemHandler();

        #endregion

        #region Act

        var _result = await _getWorkItemHandler.Handle(
            request: _getWorkItemQuery, cancellationToken: CancellationToken.None);

        #endregion

        #region Assert

        var _conditionIds = _result.Value.WorkItemConditions!.Select(x => x.SecondId);

        Assert.Multiple(
            () => Assert.Single(_result.Value.WorkItemConditions!),
            () => Assert.Contains(F_Condition.Approve.Id, _conditionIds));

        #endregion
    }
}
