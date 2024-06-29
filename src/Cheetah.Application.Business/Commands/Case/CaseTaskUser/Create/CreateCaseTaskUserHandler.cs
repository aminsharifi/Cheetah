namespace Cheetah.Application.Business.Commands.Case.CaseTaskUser.Create;

public class CreateCaseTaskUserHandler(
    IRepository<L_CaseTaskUser> _repository)
  : ICommandHandler<CreateCaseTaskUserCommand, Result<L_CaseTaskUser>>
{
    public async Task<Result<L_CaseTaskUser>> Handle(CreateCaseTaskUserCommand request, CancellationToken cancellationToken)
    {
        Guard.Against.Null(request.input.FirstId);
        Guard.Against.Null(request.input.SecondId);
        Guard.Against.Null(request.input.ThirdId);

        var _addedCaseTaskUser = await _repository.AddAsync(request.input, cancellationToken);

        return _addedCaseTaskUser;
    }
}