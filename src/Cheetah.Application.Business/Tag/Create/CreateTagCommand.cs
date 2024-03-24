namespace Cheetah.Application.Business.Tag.Create;

/// <summary>
/// Create a new Contributor.
/// </summary>
/// <param name="Name"></param>
public record CreateTagCommand(string Name, string DisplayName) : Ardalis.SharedKernel.ICommand<Result<long>>;