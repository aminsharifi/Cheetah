namespace Cheetah.Application.Business.Condition.Get;

/// <summary>
/// Queries don't necessarily need to use repository methods, but they can if it's convenient
/// </summary>
public class IsConditionExistsHandler(
    IReadRepository<F_Condition> _repository,
    IReadRepository<D_Tag> _tagRepository,
    IReadRepository<D_Operand> _operandRepository,
    ISender _ISender)
  : IQueryHandler<IsConditionExistsQuery, Result<bool>>
{
    public async Task<Result<bool>> Handle(IsConditionExistsQuery request, CancellationToken cancellationToken)
    {
        Guard.Against.Null<D_Tag>(request.input.Tag);
        Guard.Against.Null<D_Operand>(request.input.Operand);

        var _getIdEntitySpec = new GetIdEntitySpec<D_Tag>(request.input.Tag.Adapt<SimpleClassDTO>());
        var _tagId = await _tagRepository.FirstOrDefaultAsync(_getIdEntitySpec);

        var _getIdOperandSpec = new GetIdEntitySpec<D_Operand>(request.input.Operand.Adapt<SimpleClassDTO>());
        var _operandId = await _operandRepository.FirstOrDefaultAsync(_getIdOperandSpec);

        F_Condition _condition = new(tagId: _tagId, operandId: _operandId);

        long? _isConditionExist = default!;

        var spec = new GetConditionIdSpec(tagId: _condition.TagId.Value,
            operandId: _condition.OperandId.Value, value: request.input.Value);

        _isConditionExist = await _repository.FirstOrDefaultAsync(spec, cancellationToken);

        return _isConditionExist is not null;
    }
}
