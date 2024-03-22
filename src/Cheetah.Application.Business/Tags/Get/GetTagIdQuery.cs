using Ardalis.Result;
using Ardalis.SharedKernel;
using Cheetah.Domain.Entities.Dimentions;

namespace Cheetah.Application.Business.Tags.Get;


public record GetTagIdQuery(D_Tag input) : IQuery<Result<long>>;
