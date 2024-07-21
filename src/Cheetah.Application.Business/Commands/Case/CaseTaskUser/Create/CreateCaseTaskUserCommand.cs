using Cheetah.Application.Business.DTOs.Case;

namespace Cheetah.Application.Business.Commands.Case.CaseTaskUser.Create;

public record CreateCaseTaskUserCommand(UpdateWorkItemUser_Request input) : ICommand<Result<UpdateWorkItemUser_Response>>;
