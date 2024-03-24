namespace Cheetah.Application.Business.Tag.Get;

/// <summary>
/// Queries don't necessarily need to use repository methods, but they can if it's convenient
/// </summary>
public class GetTagIdHandler(IReadRepository<D_Tag> _repository)
  : IQueryHandler<GetTagIdQuery, Result<long>>
{
    public async Task<Result<long>> Handle(GetTagIdQuery request, CancellationToken cancellationToken)
    {
        var spec = new GetEntitySpec<D_Tag>(request.input);
        
        var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);

        Guard.Against.Null(entity);

        return entity.Id;
    }
}
