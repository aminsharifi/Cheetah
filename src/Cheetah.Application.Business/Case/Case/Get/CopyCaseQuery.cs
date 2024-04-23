namespace Cheetah.Application.Business.Case.Get;

public record CopyCaseQuery(F_Case Case, D_User Creator, D_User Requestor, D_Process Process, 
    List<F_Condition> CaseConditions, D_User WorkItemUser, List<F_Condition> WorkItemConditions) : IQuery<Result<F_Case>>;