using Ardalis.Result;
using Ardalis.SharedKernel;
using Cheetah.Application.Business.Queries.Case.WorkItem.Get;
using Cheetah.Domain.Aggregates.CaseAggregate.Facts.Specifications;
using Cheetah.Domain.Aggregates.ConditionAggregate.DTOs;
using Cheetah.Domain.Common.DTOs;
using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Facts;
using Mapster;
using MediatR;
using NSubstitute;

namespace Cheetah.UnitTest.Application.Queries.Case.WorkItem.Get;

public class GetWorkItemHandlerHandle
{
    [Fact]
    public async Task GetWorkItemHandlerConflict()
    {
        #region Arrange
        IReadRepository<D_User> _userRepository = Substitute.For<IReadRepository<D_User>>();
        IReadRepository<F_WorkItem> _workItemRepository = Substitute.For<IReadRepository<F_WorkItem>>();
        ISender _iSender = Substitute.For<ISender>();

        F_WorkItem _workItem = (F_WorkItem)new F_WorkItem()
            .SetId(1)
            .SetLastModified(DateTime.UtcNow);

        SimpleClassDTO _workItemDTO = _workItem.Adapt<SimpleClassDTO>();

        SimpleClassDTO _workItemUser = new() { Id = 1 };
        List<ConditionDTO> _workItemConditions = new List<ConditionDTO>();
        bool _rebase = false;

        GetWorkItemQuery _getWorkItemQuery = new GetWorkItemQuery(
            WorkItem: _workItemDTO,
            WorkItemUser: _workItemUser,
            WorkItemConditions: _workItemConditions,
            Rebase: _rebase);

        _workItemRepository
             .FirstOrDefaultAsync(Arg.Any<GetWorkItemSpec>(), CancellationToken.None)
             .Returns(_workItem);

        GetWorkItemHandler _getWorkItemHandler = new GetWorkItemHandler(
            userRepository: _userRepository,
            workItemRepository: _workItemRepository,
            iSender: _iSender);

        #endregion

        #region Act

        var _result = await _getWorkItemHandler.Handle(
            request: _getWorkItemQuery, cancellationToken: CancellationToken.None);

        #endregion

        #region Assert

        Assert.True(_result.IsConflict());

        #endregion
    }
}
