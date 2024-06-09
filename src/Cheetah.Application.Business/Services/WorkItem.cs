namespace Cheetah.Application.Business.Services;
public class WorkItem(ICopyClass _iCopyClass,
    ISender iSender, IMemoryCache _cache,
    IRepository<F_WorkItem> workItemRepository,
    IRepository<F_Case> caseRepository,
    IRepository<F_Task> taskRepository,
    IRepository<D_User> userRepository,
    IRepository<F_Condition> conditionRepository,
    IRepository<D_Process> processRepository
    ) : IWorkItem
{
    public async Task<Result<long>> CreateRequestAsync(SimpleClassDTO Case, SimpleClassDTO Creator,
        SimpleClassDTO Requestor, SimpleClassDTO Process,
        List<ConditionDTO> CaseConditions, SimpleClassDTO WorkItemUser,
        List<ConditionDTO> WorkItemConditions, SimpleClassDTO WorkItemBase)
    {
        var GeneralRequest = await iSender.Send(new CopyCaseQuery(Case, Creator, Requestor, Process,
            CaseConditions, WorkItemUser, WorkItemConditions));

        var _getCaseSpec = new GetIdCaseSpec(processId: GeneralRequest.Value.ProcessId.Value,
        eRPCode: GeneralRequest.Value.ERPCode.Value);

        Result<long> _OutputState;

        if (await caseRepository.AnyAsync(_getCaseSpec))
        {
            var _caseID = await caseRepository.FirstOrDefaultAsync(_getCaseSpec);

            _OutputState = Result<long>.Conflict();

            return _OutputState;
        }
        else
        {
            await SetWorkItems.Handle(iSender, taskRepository, Current_Case: GeneralRequest, WorkItemBase: WorkItemBase);

            GeneralRequest.Value.UpdateLastModified();

            var _createdCase = await caseRepository.AddAsync(GeneralRequest);

            _OutputState = Result<long>.Success(_createdCase.Id);
        }

        return _OutputState;
    }
    public async Task<Result<long>> PerformWorkItemAsync(
        SimpleClassDTO WorkItem, SimpleClassDTO WorkItemUser,
        List<ConditionDTO> WorkItemConditions, Boolean Rebase = false)
    {
        Result<long> _OutputState;

        F_WorkItem Current_WorkItem = await iSender.Send(new CopyWorkItemQuery(
            WorkItem, WorkItemUser, WorkItemConditions, Rebase));

        if (Current_WorkItem.LastModified is not null && !Rebase)
        {
            _OutputState = Result<long>.Conflict(WorkItem.Id.ToString());
            return _OutputState;
        }

        var _setCurrentAssignmentAsync = await SetCurrentAssignment.Handle(iSender, taskRepository, Current_WorkItem);

        Current_WorkItem = _setCurrentAssignmentAsync;

        if (Current_WorkItem.Case.IsEditing())
        {
            Current_WorkItem.Case.WorkItems
                .Where(x => !x.IsExit() && !x.IsSent())
                .ToList().ForEach(x => x.SetExit());

            await SetWorkItems.Handle(iSender, taskRepository, Current_WorkItem.Case, Current_WorkItem);
        }

        await workItemRepository.UpdateAsync(_setCurrentAssignmentAsync);

        _OutputState = Result<long>.Success(WorkItem.Id);

        return _OutputState;
    }
    public async Task<Result<L_CaseTaskUser>> SetCaseTaskUserAsync(L_CaseTaskUser CaseTaskUser)
    {
        var _selectedCaseTaskUsers = (await iSender.Send(
            new GetByCaseAndTaskQuery(
                caseId: CaseTaskUser.FirstId,
                taskId: CaseTaskUser.SecondId
                ))).Value;

        if (_selectedCaseTaskUsers.Any())
        {
            var _addedCaseTaskUsers = (await iSender.Send(
            new CreateCaseTaskUserQuery(CaseTaskUser))).Value;

            _selectedCaseTaskUsers.Append(_addedCaseTaskUsers);
        }

        return Result<L_CaseTaskUser>.Success(CaseTaskUser, "با موفقیت ایجاد شد");
    }

}