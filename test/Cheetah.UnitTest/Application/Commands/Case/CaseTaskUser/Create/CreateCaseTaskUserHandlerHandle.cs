using Ardalis.SharedKernel;
using Cheetah.Application.Business.Commands.Case.CaseTaskUser.Create;
using Cheetah.Application.Business.DTOs.Case;
using Cheetah.Domain.Common.DTOs;
using Cheetah.Domain.Common.Specifications;
using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Facts;
using NSubstitute;

namespace Cheetah.UnitTest.Application.Commands.Case.CaseTaskUser.Create;

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
        BaseClassWithNameDTO _workItemClassDTO = new BaseClassWithNameDTO() { Id = _workItem.Id };
        #endregion

        #region User
        D_User _user = new() { Id = D_User.a_sharifi.Id };
        BaseClassWithNameDTO _userClassDTO = new BaseClassWithNameDTO() { Id = _user.Id };
        #endregion

        #region UpdateWorkItemUser_Request
        UpdateWorkItemUser_Request _updateWorkItemUser_Request = new UpdateWorkItemUser_Request();
        _updateWorkItemUser_Request.WorkItem = _workItemClassDTO;
        _updateWorkItemUser_Request.User = _userClassDTO;
        #endregion

        #endregion

        #region Act

        CreateCaseTaskUserHandler _handler = new CreateCaseTaskUserHandler(_userRepository, _workItemRepository);

        _workItemRepository
            .FirstOrDefaultAsync(Arg.Any<GetEntitySpec<F_WorkItem>>(), Arg.Any<CancellationToken>())
            .Returns(_workItem);

        _userRepository
            .FirstOrDefaultAsync(Arg.Any<GetIdEntitySpec<D_User>>(), Arg.Any<CancellationToken>())
            .Returns(_user.Id);

        var result = await _handler.Handle(new CreateCaseTaskUserCommand(_updateWorkItemUser_Request), CancellationToken.None);

        #endregion

        #region Assert

        Assert.True(result.IsSuccess);

        Assert.Equal(_user.Id, _workItem.UserId);

        #endregion

    }
}
