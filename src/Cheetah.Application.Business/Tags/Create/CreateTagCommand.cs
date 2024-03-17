using Ardalis.Result;
using Ardalis.SharedKernel;

namespace Cheetah.Application.Business.Tags.Create;

/// <summary>
/// Create a new Tag.
/// </summary>
/// <param name="Name"></param>
public record CreateTagCommand(string Name, string? DisplayName, string? Description)
    : ICommand<Result<long>>;
