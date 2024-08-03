﻿using Cheetah.Domain.Aggregates.ConditionAggregate.Specifications;
using Cheetah.Domain.Common.DTOs;
using Cheetah.Domain.Common.Specifications;
using Cheetah.Domain.Entities.Dimentions;
using Cheetah.Domain.Entities.Facts;

namespace Cheetah.Application.Business.Queries.Condition.Get;

/// <summary>
/// Queries don't necessarily need to use repository methods, but they can if it's convenient
/// </summary>
public class GetConditionExistsHandler(
    IReadRepository<F_Condition> conditionRepository,
    IReadRepository<D_Tag> tagRepository,
    IReadRepository<D_Operand> operandRepository)
  : IQueryHandler<GetConditionExistsQuery, Result<bool>>
{
    public async Task<Result<bool>> Handle(GetConditionExistsQuery request, CancellationToken cancellationToken)
    {
        Guard.Against.Null(request.input.Tag);
        Guard.Against.Null(request.input.Operand);

        var _getIdEntitySpec = new GetIdEntitySpec<D_Tag>(request.input.Tag.Adapt<SimpleClassDTO>());
        var _tagId = await tagRepository.FirstOrDefaultAsync(_getIdEntitySpec, cancellationToken);

        var _getIdOperandSpec = new GetIdEntitySpec<D_Operand>(request.input.Operand.Adapt<SimpleClassDTO>());
        var _operandId = await operandRepository.FirstOrDefaultAsync(_getIdOperandSpec, cancellationToken);

        F_Condition _condition = new F_Condition()
            .SetTagId(_tagId)
            .SetOperandId(_operandId);

        var spec = new GetConditionIdSpec(tagId: _condition.TagId!.Value,
            operandId: _condition.OperandId!.Value, value: request.input.Value);

        bool _isConditionExist = await conditionRepository.AnyAsync(spec, cancellationToken);

        return _isConditionExist;
    }
}
