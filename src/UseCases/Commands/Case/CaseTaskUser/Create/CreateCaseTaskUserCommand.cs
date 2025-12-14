using Cheetah.Core.Interfaces.WorkItem.DTOs;


namespace Cheetah.UseCases.Commands.Case.CaseTaskUser.Create;

public record CreateCaseTaskUserCommand(UpdateWorkItemUser_Request input) : ICommand<Result<UpdateWorkItemUser_Response>>;
