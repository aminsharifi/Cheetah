using Cheetah.Core.Aggregates.ConditionAggregate.Dimentions;
using Cheetah.Core.Aggregates.ConditionAggregate.Facts;
using Cheetah.Core.Aggregates.ConditionAggregate.Specifications;
using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Common.Specifications;

namespace Cheetah.UseCases.Queries.Condition.Get;

/// <summary>
/// Queries don't necessarily need to use repository methods, but they can if it's convenient
/// </summary>
public class GetConditionIdHandler(
    IReadRepository<F_Condition> conditionRepository,
    IReadRepository<D_Tag> tagRepository,
    IReadRepository<D_Operand> operandRepository)
  : IQueryHandler<GetConditionIdQuery, Result<long>>
{
    public async ValueTask<Result<long>> Handle(GetConditionIdQuery request, CancellationToken cancellationToken)
    {
        long? _conditionID = default!;

        if (request.input.Base is not null)
        {
            var _conditionIDSpec = new GetIdEntitySpec<F_Condition>(request.input.Base.Adapt<SimpleClassDTO>());
            _conditionID = await conditionRepository.FirstOrDefaultAsync(_conditionIDSpec, cancellationToken);
            return _conditionID;
        }

        Guard.Against.Null(request.input.Tag);

        Guard.Against.Null(request.input.Operand);

        var _getIdEntitySpec = new GetIdEntitySpec<D_Tag>(request.input.Tag.Adapt<SimpleClassDTO>());
        var _tagId = await tagRepository.FirstOrDefaultAsync(_getIdEntitySpec, cancellationToken);


        var _getIdoperandSpec = new GetIdEntitySpec<D_Operand>(request.input.Operand.Adapt<SimpleClassDTO>());
        var _operandId = await operandRepository.FirstOrDefaultAsync(_getIdoperandSpec, cancellationToken);

        var spec = new GetConditionIdSpec(tagId: _tagId,
            operandId: _operandId, value: request.input.Value);

        _conditionID = await conditionRepository.FirstOrDefaultAsync(spec, cancellationToken);

        return _conditionID;
    }
}