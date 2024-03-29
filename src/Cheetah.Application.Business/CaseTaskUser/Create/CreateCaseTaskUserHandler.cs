namespace Cheetah.Application.Business.CaseTaskUser.Create;

public class CreateCaseTaskUserHandler(IRepository<L_CaseTaskUser> _repository)
  : IQueryHandler<CreateCaseTaskUserQuery, Result<L_CaseTaskUser>>
{
    public async Task<Result<L_CaseTaskUser>> Handle(CreateCaseTaskUserQuery request, CancellationToken cancellationToken)
    {
        Guard.Against.Null<F_Case>(request.input.Case);
        Guard.Against.Null<F_Task>(request.input.Task);
        Guard.Against.Null<D_User>(request.input.User);

        var _addedCaseTaskUser = await _repository.AddAsync(request.input, cancellationToken);

        return _addedCaseTaskUser;
    }
}