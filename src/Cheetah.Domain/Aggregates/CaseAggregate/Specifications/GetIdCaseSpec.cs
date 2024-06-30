namespace Cheetah.Application.Business.Case.Specifications;
public class GetIdCaseSpec : Specification<F_Case, long?>
{
    public GetIdCaseSpec(long processId, long eRPCode)
    {
        Query
            .Select(x => x.Id);

        Query
            .Where(x => x.ProcessId == processId)
            .Where(x => x.ERPCode == eRPCode)
            .Where(x => x.CaseStateId == D_CaseState.Ongoing.Id || x.CaseStateId == D_CaseState.Editing.Id)
            .Where(x => x.EnableRecord == true);

        Query
            .AsNoTracking();
    }
}