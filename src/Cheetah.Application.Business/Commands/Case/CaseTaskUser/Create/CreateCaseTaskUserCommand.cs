using Cheetah.Application.Business.DTOs.Process;

namespace Cheetah.Application.Business.Commands.Case.CaseTaskUser.Create;

public record CreateCaseTaskUserCommand(CreateCaseTaskUser_Request input) : ICommand<Result<CreateCaseTaskUser_Response>>;
