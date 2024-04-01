﻿namespace Cheetah.Application.Business.Case.Specifications;

public class GetDetailCasesSpec : Specification<F_Case>
{
    public GetDetailCasesSpec(F_Case request)
    {
        Query
            .Include(x => x.Creator)
            .Include(x => x.Requestor)
            .Include(x => x.Process)
            .Include(x => x.SelectedScenario)
            .Include(x => x.CaseConditions)
            .ThenInclude(x => x.Condition)
            .Include(x => x.CaseState)
            .Include(x => x.WorkItems)
            .ThenInclude(x => x.WorkItemConditions)
            .Include(x => x.WorkItems)
            .ThenInclude(x => x.WorkItemState)
            .Include(x => x.WorkItems)
            .ThenInclude(x => x.User)
            .AsNoTracking();

        if (request.Process is not null)
        {
            //var _ProcessId = await _iCopyClass.GetSimpleClassId(_db.D_Processes, request.Process);
            //GeneralRequest = GeneralRequest.Where(x => x.ProcessId == _ProcessId);
        }

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