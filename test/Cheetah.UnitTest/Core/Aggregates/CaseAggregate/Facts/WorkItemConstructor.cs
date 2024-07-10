using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.UnitTest.Core.Aggregates.CaseAggregate.Facts;

public class WorkItemConstructor
{
    F_WorkItem _testWorkItem;

    [Fact]
    public void SetInbox()
    {
        // arrange
        _testWorkItem = new F_WorkItem();

        // act
        _testWorkItem.SetInbox();

        // assert
        Assert.Multiple(
        () => Assert.Equal(_testWorkItem.WorkItemStateId, D_WorkItemState.Inbox.Id),
        () => Assert.True(_testWorkItem.IsInbox()));
    }
    [Fact]
    public void SetSent()
    {
        // arrange
        _testWorkItem = new F_WorkItem();

        // act
        _testWorkItem.SetSent();

        // assert
        Assert.Multiple(
        () => Assert.Equal(_testWorkItem.WorkItemStateId, D_WorkItemState.Sent.Id),
        () => Assert.True(_testWorkItem.IsSent()));
    }
    [Fact]
    public void SetExit()
    {
        // arrange
        _testWorkItem = new F_WorkItem();

        // act
        _testWorkItem.SetExit();

        // assert
        Assert.Multiple(
        () => Assert.Equal(_testWorkItem.WorkItemStateId, D_WorkItemState.Exit.Id),
        () => Assert.True(_testWorkItem.IsExit()));
    }
    [Fact]
    public void SetFuture()
    {
        // arrange
        _testWorkItem = new F_WorkItem();

        // act
        _testWorkItem.SetFuture();

        // assert
        Assert.Multiple(
        () => Assert.Equal(_testWorkItem.WorkItemStateId, D_WorkItemState.Future.Id),
        () => Assert.True(_testWorkItem.IsFuture()));
    }
    [Fact]
    public void ThrowsExceptionGivenNullCase()
    {
        // arrange
        _testWorkItem = new F_WorkItem();

        // act
        Action action = () => _testWorkItem.SetCase(null);

        // assert
        var ex = Assert.Throws<ArgumentNullException>(action);
        Assert.Equal("f_Case", ex.ParamName);
    }
}
