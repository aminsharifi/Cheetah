namespace Cheetah.Application.Business.Case.Create;

/// <summary>
/// Create a new Contributor.
/// </summary>
/// <param name="Name"></param>
public record CreateCaseCommand(F_Case input) : ICommand<Result<F_Case>>;