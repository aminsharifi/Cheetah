namespace Cheetah.Application.Business.Case.Get;

public record CopyCaseQuery(SimpleClassDTO Case, SimpleClassDTO Creator, SimpleClassDTO Requestor, SimpleClassDTO Process, 
    List<GRPC_Condition> CaseConditions, SimpleClassDTO WorkItemUser, List<GRPC_Condition> WorkItemConditions) : IQuery<Result<F_Case>>;