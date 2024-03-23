namespace Cheetah.Application.Business.Tags.Get;


public record GetTagIdQuery(D_Tag input) : IQuery<Result<long>>;
