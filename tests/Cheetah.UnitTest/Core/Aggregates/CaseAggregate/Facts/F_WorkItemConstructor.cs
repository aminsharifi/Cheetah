using Cheetah.Core.Aggregates.CaseAggregate.Dimentions;
using Cheetah.Core.Aggregates.CaseAggregate.Facts;
using Cheetah.Core.Aggregates.ProcessAggregate.Facts;
using Cheetah.Core.Aggregates.UserAggregate.Dimentions;

namespace Cheetah.UnitTest.Core.Aggregates.CaseAggregate.Facts;

public class F_WorkItemConstructor
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
            () => Assert.Equal(D_WorkItemState.Inbox, _testWorkItem.WorkItemState),
            () => Assert.Equal(D_WorkItemState.Inbox.Id, _testWorkItem.WorkItemStateId),
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
            () => Assert.Equal(D_WorkItemState.Sent.Id, _testWorkItem.WorkItemStateId),
            () => Assert.Equal(D_WorkItemState.Sent, _testWorkItem.WorkItemState),
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
            () => Assert.Equal(D_WorkItemState.Exit.Id, _testWorkItem.WorkItemStateId),
            () => Assert.Equal(D_WorkItemState.Exit, _testWorkItem.WorkItemState),
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
            () => Assert.Equal(D_WorkItemState.Future, _testWorkItem.WorkItemState),
            () => Assert.Equal(D_WorkItemState.Future.Id, _testWorkItem.WorkItemStateId),
            () => Assert.True(_testWorkItem.IsFuture()));
    }

    [Fact]
    public void SetCase()
    {
        // arrange
        _testWorkItem = new F_WorkItem();
        F_Case f_Case = new F_Case();

        // act
        _testWorkItem.SetCase(f_Case);

        // assert
        Assert.Multiple(
            () => Assert.Equal(0, _testWorkItem.CaseId),
            () => Assert.Equal("f_Case", Assert.Throws<ArgumentNullException>(() => _testWorkItem.SetCase(null)).ParamName));
    }

    [Fact]
    public void SetTaskId()
    {
        // arrange
        _testWorkItem = new F_WorkItem();
        F_Task _Sample_Scenario_Requestor = F_Task.Sample_Scenario_Requestor;

        // act
        _testWorkItem.SetTaskId(_Sample_Scenario_Requestor.Id);

        // assert
        Assert.Multiple(
            () => Assert.Equal(_Sample_Scenario_Requestor.Id, _testWorkItem.TaskId),
            () => Assert.Equal("taskId", Assert.Throws<ArgumentNullException>(() => _testWorkItem.SetTaskId(null)).ParamName));
    }

    [Fact]
    public void SetUserId()
    {
        // arrange
        _testWorkItem = new F_WorkItem();
        D_User _m_sharifi = D_User.m_sharifi;

        // act
        _testWorkItem.SetUserId(_m_sharifi.Id);

        // assert
        Assert.Multiple(
            () => Assert.Equal(_m_sharifi.Id, _testWorkItem.UserId),
            () => Assert.Equal("userId", Assert.Throws<ArgumentNullException>(() => _testWorkItem.SetUserId(null)).ParamName));
    }
}
