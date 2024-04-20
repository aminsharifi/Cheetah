namespace Cheetah.Application.Business.Case.Specifications;

public class GetDetailCasesSpec : Specification<F_Case>
{
    public GetDetailCasesSpec(F_Case request)
    {
        Query
            .AsNoTracking();       

        if (request.CaseState is not null)
        {
            //var CaseStateId = await _iCopyClass.GetSimpleClassId(_db.D_CaseStates, request.CaseState);
            //GeneralRequest = GeneralRequest.Where(x => x.CaseStateId == CaseStateId);
        }

        if (request.Id != 0)
        {
            Query.Where(x => x.Id == request.Id);
        }

        if (request.ERPCode is not null)
        {
            Query.Where(x => x.ERPCode == request.ERPCode);
        }
    }
}