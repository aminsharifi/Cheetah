using Cheetah.Core.Aggregates.CaseAggregate.Facts.Specifications;
using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Enums;
using Cheetah.Core.Interfaces.Cartable.DTOs;
using Cheetah.Core.Entities.Dimentions;
using Cheetah.Core.Entities.Facts;

namespace Cheetah.UnitTest.Core.Aggregates.CaseAggregate.Facts.Specifications;

public class GetCartableSpecConstructor
{
    [Fact]
    public void CheckInbox()
    {
        #region Arrange
        F_Case _case = new();
        D_User _inboxUser = D_User.a_sharifi;
        F_WorkItem _inboxWorkItem = new();
        _inboxWorkItem.SetCase(_case);
        _inboxWorkItem
            .SetInbox()
            .SetUserId(_inboxUser.Id);

        D_User _outboxUser = D_User.m_sharifi;
        F_WorkItem _outboxWorkItem = new();
        _outboxWorkItem.SetCase(_case);
        _outboxWorkItem
            .SetSent()
            .SetUserId(_outboxUser.Id);

        List<F_WorkItem> _WorkItems = new();
        _WorkItems.Add(_inboxWorkItem);
        _WorkItems.Add(_outboxWorkItem);

        CartableDTO _inboxCartableDTO = new();
        _inboxCartableDTO.User = new SimpleClassDTO() { Id = _inboxUser.Id };
        CartableProperty _cartableProperty = CartableProperty.Inbox;
        #endregion

        #region Act
        GetCartableSpec _spec = new(_inboxCartableDTO, _cartableProperty);
        var _filtered_WorkItems = _spec.Evaluate(_WorkItems);
        #endregion

        #region Assert

        Assert.Multiple(
            () => Assert.Contains(_inboxWorkItem, _filtered_WorkItems),
            () => Assert.DoesNotContain(_outboxWorkItem, _filtered_WorkItems));

        #endregion
    }
    [Fact]
    public void CheckOutbox()
    {
        #region Arrange
        F_Case _case = new();
        D_User _inboxUser = D_User.a_sharifi;
        F_WorkItem _inboxWorkItem = new();
        _inboxWorkItem.SetCase(_case);
        _inboxWorkItem
            .SetInbox()
            .SetUserId(_inboxUser.Id);
        _inboxWorkItem.SetCase(_case);

        D_User _outboxUser = D_User.m_sharifi;
        F_WorkItem _outboxWorkItem = new();
        _outboxWorkItem
            .SetSent()
            .SetUserId(_outboxUser.Id);
        _outboxWorkItem.SetCase(_case);

        List<F_WorkItem> _WorkItems = new();
        _WorkItems.Add(_inboxWorkItem);
        _WorkItems.Add(_outboxWorkItem);

        CartableDTO _outboxCartableDTO = new();
        _outboxCartableDTO.User = new SimpleClassDTO() { Id = _outboxUser.Id };
        CartableProperty _cartableProperty = CartableProperty.Outbox;

        #endregion

        #region Act
        GetCartableSpec _spec = new(_outboxCartableDTO, _cartableProperty);
        var _filtered_WorkItems = _spec.Evaluate(_WorkItems);
        #endregion

        #region Assert
        Assert.Multiple(
            () => Assert.Contains(_outboxWorkItem, _filtered_WorkItems),
            () => Assert.DoesNotContain(_inboxWorkItem, _filtered_WorkItems));
        #endregion
    }
}
