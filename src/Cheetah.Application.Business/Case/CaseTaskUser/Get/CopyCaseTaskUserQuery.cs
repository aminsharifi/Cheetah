namespace Cheetah.Application.Business.CaseTaskUser.Get;

public record CopyCaseTaskUserQuery(L_CaseTaskUser input) : IQuery<Result<L_CaseTaskUser>>;