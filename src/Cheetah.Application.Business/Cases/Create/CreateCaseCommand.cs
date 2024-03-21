using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Cheetah.Application.Business.Cases.Create;

/// <summary>
/// Create a new Contributor.
/// </summary>
/// <param name="Name"></param>
public record CreateCaseCommand(string Name, string DisplayName) : ICommand<Result<long>>;