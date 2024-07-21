using Cheetah.Domain.Aggregates.ConditionAggregate.Specifications;
using Cheetah.Domain.Common.DTOs;
using Cheetah.Domain.Common.Specifications;
using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Application.Business.Queries.Condition.Condition.Get;

/// <summary>
/// Queries don't necessarily need to use repository methods, but they can if it's convenient
/// </summary>
public class GetConditionExistsHandler(
    IReadRepository<F_Condition> _repository,
    IReadRepository<D_Tag> _tagRepository,
    IReadRepository<D_Operand> _operandRepository,
    ISender _ISender)
  : IQueryHandler<GetConditionExistsQuery, Result<bool>>
{
    public async Task<Result<bool>> Handle(GetConditionExistsQuery request, CancellationToken cancellationToken)
    {
        Guard.Against.Null(request.input.Tag);
        Guard.Against.Null(request.input.Operand);

        var _getIdEntitySpec = new GetIdEntitySpec<D_Tag>(request.input.Tag.Adapt<SimpleClassDTO>());
        var _tagId = await _tagRepository.FirstOrDefaultAsync(_getIdEntitySpec);

        var _getIdOperandSpec = new GetIdEntitySpec<D_Operand>(request.input.Operand.Adapt<SimpleClassDTO>());
        var _operandId = await _operandRepository.FirstOrDefaultAsync(_getIdOperandSpec);

        F_Condition _condition = new F_Condition()
            .SetTagId(_tagId)
            .SetOperandId(_operandId);

        long? _isConditionExist = default!;

        var spec = new GetConditionIdSpec(tagId: _condition.TagId.Value,
            operandId: _condition.OperandId.Value, value: request.input.Value);

        _isConditionExist = await _repository.FirstOrDefaultAsync(spec, cancellationToken);

        return _isConditionExist is not null;
    }
}
