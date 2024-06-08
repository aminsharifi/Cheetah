using Mapster;

namespace Cheetah.Application.Business.Condition.Get;

/// <summary>
/// Queries don't necessarily need to use repository methods, but they can if it's convenient
/// </summary>
public class GetConditionIdHandler(
    IReadRepository<F_Condition> _repository,
    IReadRepository<D_Tag> _tagRepository,
    ISender _ISender)
  : IQueryHandler<GetConditionIdQuery, Result<long?>>
{
    public async Task<Result<long?>> Handle(GetConditionIdQuery request, CancellationToken cancellationToken)
    {
        Guard.Against.Null<D_Tag>(request.input.Tag);
        Guard.Against.Null<D_Operand>(request.input.Operand);

        var _getIdEntitySpec = new GetIdEntitySpec<D_Tag>(request.input.Tag.Adapt<SimpleClassDTO>());
        var _tagId = await _tagRepository.FirstOrDefaultAsync(_getIdEntitySpec);
        var _operandId = await _ISender.Send(new GetOperandIdQuery(request.input.Operand));

        F_Condition _condition = new(tagId: _tagId, operandId: _operandId);


        long? _conditionID = default!;

        var spec = new GetConditionIdSpec(tagId: _condition.TagId.Value,
            operandId: _condition.OperandId.Value, value: request.input.Value);

        _conditionID = await _repository.FirstOrDefaultAsync(spec, cancellationToken);

        return _conditionID;
    }
}
