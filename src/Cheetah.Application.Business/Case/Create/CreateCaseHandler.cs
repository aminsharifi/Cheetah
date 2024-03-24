namespace Cheetah.Application.Business.Operand.Create;

public class CreateCaseHandler(IMediator _mediator,
    IRepository<F_Case> _repository) : ICommandHandler<CreateCaseCommand, Result<F_Case>>
{
    public async Task<Result<F_Case>> Handle(CreateCaseCommand request,
      CancellationToken cancellationToken)
    {
        var _copyCaseQuery = await _mediator.Send(new CopyCaseQuery(request.input));

        var _getCaseSpec = new GetCaseSpec(processId: _copyCaseQuery.Value.ProcessId.Value,
            eRPCode: _copyCaseQuery.Value.ERPCode.Value);

        if (await _repository.AnyAsync(_getCaseSpec, cancellationToken))
        {
            var _caseID = (await _repository.FirstOrDefaultAsync(_getCaseSpec, cancellationToken)).Id;

            Result.Conflict(_caseID.ToString());
        }

        var _returnCase = await _repository.AddAsync(_copyCaseQuery);

        return _returnCase;
    }
}

