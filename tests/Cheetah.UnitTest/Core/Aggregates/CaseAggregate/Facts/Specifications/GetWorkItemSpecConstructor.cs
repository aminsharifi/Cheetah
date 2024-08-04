using Cheetah.Core.Aggregates.CaseAggregate.Facts.Specifications;
using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Entities.Dimentions;
using Cheetah.Core.Entities.Facts;

namespace Cheetah.UnitTest.Core.Aggregates.CaseAggregate.Facts.Specifications;

public class GetWorkItemSpecConstructor
{
    [Fact]
    public void GetWorkItemSpec()
    {
        #region Arrange
        long _id = 1L;
        SimpleClassDTO _simpleClassDTO = new() { Id = _id };
        Boolean _enableTrack = false;
        F_Case _case = new();

        D_User _inboxUser = D_User.a_sharifi;
        F_WorkItem _inboxWorkItem = new() { Id = _id };
        _inboxWorkItem.SetCase(_case);
        _inboxWorkItem
            .SetInbox()
            .SetUserId(_inboxUser.Id);

        D_User _outboxUser = D_User.m_sharifi;
        F_WorkItem _outboxWorkItem = new() { Id = 2 };
        _outboxWorkItem.SetCase(_case);
        _outboxWorkItem
            .SetSent()
            .SetUserId(_outboxUser.Id);


        List<F_WorkItem> _listF_WorkItem = new();
        _listF_WorkItem.Add(_inboxWorkItem);
        _listF_WorkItem.Add(_outboxWorkItem);
        #endregion

        #region Act
        GetWorkItemSpec _getEntitySpec = new(_simpleClassDTO, _enableTrack);
        var _filteredWorkItems = _getEntitySpec.Evaluate(_listF_WorkItem);
        #endregion

        #region Assert
        Assert
            .Multiple(
            () => Assert.Contains(_inboxWorkItem, _filteredWorkItems),
            () => Assert.DoesNotContain(_outboxWorkItem, _filteredWorkItems));
        #endregion
    }
}
