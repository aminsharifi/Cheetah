namespace Cheetah.Application.Business.Condition.Get;

/// <summary>
/// Queries don't necessarily need to use repository methods, but they can if it's convenient
/// </summary>
public class CopyConditionHandler(IReadRepository<F_Condition> _repository, IMediator _mediator)
  : IQueryHandler<CopyConditionQuery, Result<F_Condition>>
{
    public async Task<Result<F_Condition>> Handle(CopyConditionQuery request, CancellationToken cancellationToken)
    {
        Guard.Against.Null<D_Tag>(request.input.Tag);
        Guard.Against.Null<D_Operand>(request.input.Operand);

        F_Condition _condition = new();

        _condition.TagId = await _mediator.Send(new GetTagIdQuery(request.input.Tag));
        _condition.OperandId = await _mediator.Send(new GetOperandIdQuery(request.input.Operand));

        var spec = new GetConditionSpec(tagId: _condition.TagId.Value,
            operandId: _condition.OperandId.Value, value: request.input.Value);

        if (await _repository.AnyAsync(spec, cancellationToken))
        {
            _condition = await _repository.FirstOrDefaultAsync(spec, cancellationToken);
        }
        else
        {
            _condition.Id = request.input.Id;
            _condition.ERPCode = request.input?.ERPCode;
            _condition.Name = request.input?.Name;
            _condition.Value = request.input?.Value;
        }

        return _condition;
    }
}
