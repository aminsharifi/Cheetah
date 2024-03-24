namespace Cheetah.Application.Business.Operand.Get;

/// <summary>
/// Queries don't necessarily need to use repository methods, but they can if it's convenient
/// </summary>
public class GetOperandHandler(IReadRepository<D_Operand> _repository)
  : IQueryHandler<GetOperandIdQuery, Result<long>>
{
    public async Task<Result<long>> Handle(GetOperandIdQuery request, CancellationToken cancellationToken)
    {
        var spec = new GetEntitySpec<D_Operand>(request.input);
        
        var entity = await _repository.FirstOrDefaultAsync(spec, cancellationToken);

        if (entity == null) return Result.NotFound();

        return entity.Id;
    }
}
