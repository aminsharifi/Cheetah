using Ardalis.SharedKernel;
using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Common.Specifications;
using Cheetah.Core.Interfaces.WorkItem.DTOs;
using Cheetah.Core.Entities.Dimentions;
using Cheetah.Core.Entities.Facts;
using Cheetah.UseCases.Commands.Case.CaseTaskUser.Create;
using Mapster;
using NSubstitute;

namespace Cheetah.UnitTest.UseCases.Commands.Case.CaseTaskUser.Create;

public class CreateCaseTaskUserHandlerHandle
{
    [Fact]
    public async Task ReturnsSuccessGivenValidValues()
    {
        #region Arrange

        IRepository<D_User> _userRepository = Substitute.For<IRepository<D_User>>();
        IRepository<F_WorkItem> _workItemRepository = Substitute.For<IRepository<F_WorkItem>>();

        #region WorkItem
        F_WorkItem _workItem = new() { Id = 1 };
        BaseClassWithNameDTO _workItemClassDTO = new() { Id = _workItem.Id };
        #endregion

        #region User
        D_User _user = D_User.a_sharifi;
        BaseClassWithNameDTO _userClassDTO = _user.Adapt<BaseClassWithNameDTO>();
        #endregion

        #region UpdateWorkItemUser_Request
        UpdateWorkItemUser_Request _updateWorkItemUser_Request = new();
        _updateWorkItemUser_Request.WorkItem = _workItemClassDTO;
        _updateWorkItemUser_Request.User = _userClassDTO;
        #endregion

        _workItemRepository
            .FirstOrDefaultAsync(Arg.Any<GetEntitySpec<F_WorkItem>>(), Arg.Any<CancellationToken>())
            .Returns(_workItem);

        _userRepository
            .FirstOrDefaultAsync(Arg.Any<GetIdEntitySpec<D_User>>(), Arg.Any<CancellationToken>())
            .Returns(_user.Id);

        #endregion

        #region Act

        CreateCaseTaskUserHandler _handler = new(_userRepository, _workItemRepository);
        var result = await _handler.Handle(new CreateCaseTaskUserCommand(_updateWorkItemUser_Request), CancellationToken.None);

        #endregion

        #region Assert

        Assert.True(result.IsSuccess);

        Assert.Equal(_user.Id, _workItem.UserId);

        #endregion

    }
}
