﻿namespace Cheetah.Application.Business.Condition.Get;

/// <summary>
/// Queries don't necessarily need to use repository methods, but they can if it's convenient
/// </summary>
public class GetConditionIdHandler(
    IReadRepository<F_Condition> _repository,
    IReadRepository<D_Tag> _tagRepository,
    IReadRepository<D_Operand> _operandRepository,
    ISender _ISender)
  : IQueryHandler<GetConditionIdQuery, Result<long?>>
{
    public async Task<Result<long?>> Handle(GetConditionIdQuery request, CancellationToken cancellationToken)
    {
        Guard.Against.Null(request.input.Tag);
        Guard.Against.Null(request.input.Operand);

        var _getIdEntitySpec = new GetIdEntitySpec<D_Tag>(request.input.Tag.Adapt<SimpleClassDTO>());
        var _tagId = await _tagRepository.FirstOrDefaultAsync(_getIdEntitySpec);


        var _getIdoperandSpec = new GetIdEntitySpec<D_Operand>(request.input.Operand.Adapt<SimpleClassDTO>());
        var _operandId = await _operandRepository.FirstOrDefaultAsync(_getIdoperandSpec);

        long? _conditionID = default!;

        var spec = new GetConditionIdSpec(tagId: _tagId,
            operandId: _operandId, value: request.input.Value);

        _conditionID = await _repository.FirstOrDefaultAsync(spec, cancellationToken);

        return _conditionID;
    }
}
