using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.UnitTest.Core.Aggregates.CaseAggregate;

public class CaseConstructor
{
    private F_Case _testCase;

    private F_Case CreateCase()
    {
        return new F_Case();
    }

    [Fact]
    private void InitializeCase()
    {
        // arrange
        long _requestorId = D_User.a_sharifi.Id, _creatorId = D_User.m_sharifi.Id, _processId = D_Process.SampleProcess.Id, _eRPCode = -1;

        // act
        _testCase = new(RequestorId: _requestorId, CreatorId: _creatorId, ProcessId: _processId, ERPCode: _eRPCode);

        // assert
        Assert.Multiple(
        () => Assert.Equal(_testCase.CreatorId, _creatorId),
        () => Assert.Equal(_testCase.RequestorId, _requestorId),
        () => Assert.Equal(_testCase.ProcessId, _processId),
        () => Assert.Equal(_testCase.ERPCode, _eRPCode));

    }

    [Fact]
    public void SetInitializing()
    {
        // arrange
        _testCase = CreateCase();

        // act
        _testCase.SetInitializing();


        // assert
        Assert.Multiple(
        () => Assert.Equal(_testCase.CaseStateId, D_CaseState.Initializing.Id),
        () => Assert.True(_testCase.IsInitializing()));
    }

    [Fact]
    public void SetEditing()
    {
        // arrange
        _testCase = CreateCase();

        // act
        _testCase.SetEditing();

        // assert
        Assert.Multiple(
        () => Assert.Equal(_testCase.CaseStateId, D_CaseState.Editing.Id),
        () => Assert.True(_testCase.IsEditing()));
    }

    [Fact]
    public void SetAborted()
    {
        // arrange
        _testCase = CreateCase();

        // act
        _testCase.SetAborted();

        // assert
        Assert.Multiple(
        () => Assert.Equal(_testCase.CaseStateId, D_CaseState.Aborted.Id),
        () => Assert.True(_testCase.IsAborted()));
    }

    [Fact]
    public void SetApproved()
    {
        // arrange
        _testCase = CreateCase();

        // act
        _testCase.SetApproved();

        // assert
        Assert.Multiple(
        () => Assert.Equal(_testCase.CaseStateId, D_CaseState.Approved.Id),
        () => Assert.True(_testCase.IsApproved()));
    }

    [Fact]
    public void SetOngoing()
    {
        // arrange
        _testCase = CreateCase();

        // act
        _testCase.SetOngoing();

        // assert
        Assert.Multiple(
        () => Assert.Equal(_testCase.CaseStateId, D_CaseState.Ongoing.Id),
        () => Assert.True(_testCase.IsOngoing()));
    }
}
