using Ardalis.SharedKernel;
using Cheetah.Application.Business.Queries.Condition.List;
using Cheetah.Domain.Aggregates.ConditionAggregate.Specifications;
using Cheetah.Domain.Entities.Facts;
using Microsoft.Extensions.Caching.Memory;
using NSubstitute;

namespace Cheetah.UnitTest.Application.Queries.Condition.List;

public class ListIncludedConditionsHandlerHandle
{
    IReadRepository<F_Condition> _conditionRepository;
    IMemoryCache _cache;
    ListIncludedConditionsQuery _request;
    List<long> _conditionIds;
    List<F_Condition> _conditions;
    F_Condition _approveCondition;
    F_Condition _rejectCondition;
    public ListIncludedConditionsHandlerHandle()
    {
        _conditionRepository = Substitute.For<IReadRepository<F_Condition>>();
        _cache = Substitute.For<IMemoryCache>();
        _approveCondition = F_Condition.Approve;
        _rejectCondition = F_Condition.Reject;
        _conditionIds = [_approveCondition.Id];
        _conditions = [_approveCondition];
        _conditionRepository
            .ListAsync(Arg.Any<GetConditionSpec>(), CancellationToken.None)
            .Returns(_conditions);
    }

    [Fact]
    public async Task GetConditions()
    {
        #region Arrange
   
        _cache
        .TryGetValue(Arg.Any<String>(), out Arg.Any<F_Condition>())
        .Returns(callInfo =>
        {
            return false; // Return true to indicate success
        });

        _request = new ListIncludedConditionsQuery(_conditionIds);

        ListIncludedConditionsHandler _listIncludedConditionsHandler =
            new ListIncludedConditionsHandler(conditionRepository: _conditionRepository,
            cache: _cache);

        #endregion

        #region Act
        var _result = await _listIncludedConditionsHandler
            .Handle(request: _request, cancellationToken: CancellationToken.None);
        #endregion

        #region Asset
        Assert.Multiple(
            () => Assert.Single(_result.Value),
            () => Assert.Contains(_approveCondition, _result.Value),
            () => Assert.DoesNotContain(_rejectCondition, _result.Value));
        #endregion
    }

    [Fact]
    public async Task GetConditionsFromCache()
    {
        #region Arrange
        _cache
            .TryGetValue(Arg.Any<String>(), out Arg.Any<F_Condition>())
            .Returns(callInfo =>
            {
                callInfo[1] = _approveCondition; // The second argument is the out parameter
                return true; // Return true to indicate success
            });

        _request = new ListIncludedConditionsQuery(_conditionIds);

        ListIncludedConditionsHandler _listIncludedConditionsHandler =
            new ListIncludedConditionsHandler(conditionRepository: _conditionRepository,
            cache: _cache);

        #endregion

        #region Act
        var _result = await _listIncludedConditionsHandler
            .Handle(request: _request, cancellationToken: CancellationToken.None);
        #endregion

        #region Asset
        Assert.Multiple(
            () => Assert.Single(_result.Value),
            () => Assert.Contains(_approveCondition, _result.Value),
            () => Assert.DoesNotContain(_rejectCondition, _result.Value));
        #endregion
    }
}
