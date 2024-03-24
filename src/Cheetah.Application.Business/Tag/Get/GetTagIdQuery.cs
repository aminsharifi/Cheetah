namespace Cheetah.Application.Business.Tag.Get;


public record GetTagIdQuery(D_Tag input) : IQuery<Result<long>>;
