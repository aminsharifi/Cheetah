namespace Cheetah.Application.Business.CaseTaskUser.Create;

public record CreateCaseTaskUserQuery(L_CaseTaskUser input) : IQuery<Result<L_CaseTaskUser>>;
