﻿using Cheetah.Core.Aggregates.CaseAggregate.Facts;
using Cheetah.Core.Aggregates.CaseAggregate.Links;
using Cheetah.Core.Aggregates.CaseAggregate.Links.Specifications;
using Cheetah.Core.Aggregates.ProcessAggregate.Facts;
using Cheetah.Core.Aggregates.UserAggregate.Dimentions;

namespace Cheetah.UnitTest.Core.Aggregates.CaseAggregate.Links.Specifications;

public class GetByCaseAndTaskSpecConstructor
{
    [Fact]
    public void Set_CaseTaskUser()
    {

        #region Arrange
        F_Case _case = new() { Id = 1 };
        F_Task _task = F_Task.Sample_Scenario_RequestorManager;
        D_User _user = D_User.m_sharifi;
        L_CaseTaskUser _caseTaskUser = new L_CaseTaskUser(CaseEntity: _case, TaskEntity: _task, UserEntity: _user);
        List<L_CaseTaskUser> _listcaseTaskUser = new();
        _listcaseTaskUser.Add(_caseTaskUser);
        #endregion


        #region Arrange
        GetByCaseAndTaskSpec _getByCaseAndTaskSpec = new(caseId: 1, taskId: _task.Id);
        var _filterdList = _getByCaseAndTaskSpec.Evaluate(_listcaseTaskUser);
        #endregion

        #region Assert
        Assert.Contains(_caseTaskUser, _listcaseTaskUser);
        #endregion
    }
}