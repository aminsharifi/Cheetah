namespace Cheetah.Application.Business.Commands.Case.CaseTaskUser.Create;

public record CreateCaseTaskUserCommand(L_CaseTaskUser input) : ICommand<Result<L_CaseTaskUser>>;
