using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Facts;
using Cheetah.Domain.Entities.Links;

namespace Cheetah.UnitTest.Core.Aggregates.CaseAggregate.Links;

public class L_CaseTaskUserConstructor
{
    [Fact]
    public void Set_CaseTaskUser()
    {
        // arrange
        L_CaseTaskUser _caseTaskUser;
        F_Case f_Case = new();
        f_Case.SetId(1);
        F_Task f_Task = F_Task.Sample_Scenario_RequestorManager;
        D_User d_User = D_User.m_sharifi;

        // act
        _caseTaskUser = new L_CaseTaskUser(CaseEntity: f_Case, TaskEntity: f_Task, UserEntity: d_User);

        // assert
        Assert.Multiple(
            () => Assert.Equal(1, _caseTaskUser.Case.Id),
            () => Assert.Equal(F_Task.Sample_Scenario_RequestorManager, _caseTaskUser.Task),
            () => Assert.Equal(D_User.m_sharifi, _caseTaskUser.User));
    }

    [Fact]
    public void CheckNull_CaseTaskUser()
    {
        // arrange
        L_CaseTaskUser _caseTaskUser;


        // act
        Action _caseAction = () => new L_CaseTaskUser(CaseEntity: null, TaskEntity: new F_Task(), UserEntity: new D_User());
        Action _taskAction = () => new L_CaseTaskUser(CaseEntity: new F_Case(), TaskEntity: null, UserEntity: new D_User());
        Action _userAction = () => new L_CaseTaskUser(CaseEntity: new F_Case(), TaskEntity: new F_Task(), UserEntity: null);

        // assert
        Assert.Multiple(
            () => Assert.Equal("caseEntity", Assert.ThrowsAny<ArgumentNullException>(_caseAction).ParamName),
            () => Assert.Equal("taskEntity", Assert.ThrowsAny<ArgumentNullException>(_taskAction).ParamName),
            () => Assert.Equal("userEntity", Assert.ThrowsAny<ArgumentNullException>(_userAction).ParamName));
    }
}