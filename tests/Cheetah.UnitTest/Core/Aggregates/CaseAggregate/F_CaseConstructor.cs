using Cheetah.Core.Entities.Dimentions;
using Cheetah.Core.Entities.Facts;

namespace Cheetah.UnitTest.Core.Aggregates.CaseAggregate;

public class F_CaseConstructor
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
        D_User _requestor = D_User.a_sharifi;
        D_User _creator = D_User.m_sharifi;
        D_Process _process = D_Process.SampleProcess;
        long _eRPCode = -1;

        // act
        _testCase = new(RequestorId: _requestor.Id, CreatorId: _creator.Id, ProcessId: _process.Id, ERPCode: _eRPCode);

        // assert
        Assert.Multiple(
        () => Assert.Equal(_creator.Id, _testCase.CreatorId),
        () => Assert.Equal(_requestor.Id, _testCase.RequestorId),
        () => Assert.Equal(_process.Id, _testCase.ProcessId),
        () => Assert.Equal(_eRPCode, _testCase.ERPCode));
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
        () => Assert.Equal(D_CaseState.Initializing.Id, _testCase.CaseStateId),
        () => Assert.Equal(D_CaseState.Initializing, _testCase.CaseState),
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
        () => Assert.Equal(D_CaseState.Editing.Id, _testCase.CaseStateId),
        () => Assert.Equal(D_CaseState.Editing, _testCase.CaseState),
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
        () => Assert.Equal(D_CaseState.Aborted.Id, _testCase.CaseStateId),
        () => Assert.Equal(D_CaseState.Aborted, _testCase.CaseState),
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
        () => Assert.Equal(D_CaseState.Approved.Id, _testCase.CaseStateId),
        () => Assert.Equal(D_CaseState.Approved, _testCase.CaseState),
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
        () => Assert.Equal(D_CaseState.Ongoing.Id, _testCase.CaseStateId),
        () => Assert.Equal(D_CaseState.Ongoing, _testCase.CaseState),
        () => Assert.True(_testCase.IsOngoing()));
    }

    [Fact]
    public void SetRequestorId()
    {
        // arrange
        _testCase = CreateCase();
        D_User _requestor = D_User.a_sharifi;

        // act
        _testCase.SetRequestorId(_requestor.Id);

        // assert
        Assert.Multiple(
        () => Assert.Equal(_requestor.Id, _testCase.RequestorId),
        () => Assert.Equal("requestorId", Assert.Throws<ArgumentNullException>(() => _testCase.SetRequestorId(null)).ParamName));
    }

    [Fact]
    public void SetCreatorId()
    {
        // arrange
        _testCase = CreateCase();
        D_User _creator = D_User.a_sharifi;

        // act
        _testCase.SetCreatorId(_creator.Id);

        // assert
        Assert.Multiple(
        () => Assert.Equal(_creator.Id, _testCase.CreatorId),
        () => Assert.Equal("creatorId", Assert.Throws<ArgumentNullException>(() => _testCase.SetCreatorId(null)).ParamName));
    }

    [Fact]
    public void SetProcessId()
    {
        // arrange
        _testCase = CreateCase();
        D_Process _sampleProcess = D_Process.SampleProcess;

        // act
        _testCase.SetProcessId(_sampleProcess.Id);

        // assert
        Assert.Multiple(
        () => Assert.Equal(_sampleProcess.Id, _testCase.ProcessId),
        () => Assert.Equal("processId", Assert.Throws<ArgumentNullException>(() => _testCase.SetProcessId(null)).ParamName));
    }

    [Fact]
    public void SetSelectedScenario()
    {
        // arrange
        _testCase = CreateCase();
        F_Scenario _sampleScenario = F_Scenario.SampleScenario;

        // act
        _testCase.SetSelectedScenario(_sampleScenario.Id);

        // assert
        Assert.Multiple(
        () => Assert.Equal(_sampleScenario.Id, _testCase.SelectedScenarioId),
        () => Assert.Equal("selectedScenarioId", Assert.Throws<ArgumentNullException>(() => _testCase.SetSelectedScenario(null)).ParamName));
    }
}
