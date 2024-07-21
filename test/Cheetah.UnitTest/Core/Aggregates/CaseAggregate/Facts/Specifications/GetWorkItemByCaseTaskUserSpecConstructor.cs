using Cheetah.Domain.Aggregates.CaseAggregate.Facts.Specifications;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.UnitTest.Core.Aggregates.CaseAggregate.Facts.Specifications;

public class GetWorkItemByCaseTaskUserSpecConstructor
{
    [Fact]
    public void GetWorkItemByCaseTaskSpec()
    {
        #region Arrange
        var _caseId = 1;
        F_Case _case = new() { Id = _caseId };
        F_Task _task = F_Task.Sample_Scenario_Requestor;

        F_WorkItem _workItem1 = new() { Id = 1 };
        _workItem1.SetTaskId(_task.Id);
        _workItem1.SetSent();
        _workItem1.SetCase(_case);

        F_WorkItem _workItem2 = new() { Id = 2 };
        _workItem2.SetTaskId(_task.Id);
        _workItem2.SetInbox();
        _workItem2.SetCase(_case);

        List<F_WorkItem> _listF_WorkItem = new();
        _listF_WorkItem.Add(_workItem1);
        _listF_WorkItem.Add(_workItem2);
        #endregion

        #region Act
        GetWorkItemByCaseTaskSpec _spec = new(CaseId: _caseId, TaskId: _task.Id);
        var _filteredList = _spec.Evaluate(_listF_WorkItem);
        #endregion

        #region Assert

        Assert.Multiple(
            () => Assert.Contains(_workItem2, _filteredList),
            () => Assert.DoesNotContain(_workItem1, _filteredList));

        #endregion
    }
}