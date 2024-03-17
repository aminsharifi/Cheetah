using Ardalis.SharedKernel;
using Result = Ardalis.Result.Result;

namespace Cheetah.Application.Business.Tags.Delete;

public record DeleteContributorCommand(long TagId) : ICommand<Result>;
