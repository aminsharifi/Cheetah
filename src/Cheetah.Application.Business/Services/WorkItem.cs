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
        var GeneralRequest = await iSender.Send(
            new CopyCaseQuery(Case: Case, Creator: Creator, Requestor: Requestor, Process: Process,
            CaseConditions: CaseConditions, WorkItemUser: WorkItemUser,
            WorkItemConditions: WorkItemConditions, WorkItemBase: WorkItemBase));

        var _getCaseSpec = new GetIdCaseSpec(processId: GeneralRequest.Value.ProcessId.Value,
        eRPCode: GeneralRequest.Value.ERPCode.Value);

        Result<long> _OutputState;

        var _duplicateCaseID = await caseRepository.FirstOrDefaultAsync(_getCaseSpec);

        if (_duplicateCaseID is not null)
        {
            _OutputState = Result.Conflict(_duplicateCaseID.ToString());

            return _OutputState;
        }
        else
        {
            GeneralRequest = await SetWorkItems.Handle(iSender, taskRepository,
                Current_Case: GeneralRequest, Current_WorkItem: GeneralRequest.Value.WorkItems.First());

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

        var Current_WorkItem = await iSender.Send(new CopyWorkItemQuery(
            WorkItem, WorkItemUser, WorkItemConditions, Rebase));

        await SetCurrentAssignment
        .Handle(iSender, taskRepository, Current_WorkItem);

        if (Current_WorkItem.Value.Case.IsEditing())
        {
            Current_WorkItem.Value.Case.WorkItems
                .Where(x => !x.IsExit() && !x.IsSent())
                .ToList().ForEach(x => x.SetExit());

            var _currentCase = await SetWorkItems
                .Handle(iSender, taskRepository, Current_WorkItem.Value.Case, Current_WorkItem);

            Current_WorkItem.Value.SetCase(_currentCase);
        }

        await workItemRepository.UpdateAsync(Current_WorkItem);

        _OutputState = Result.Success(Current_WorkItem.Value.CaseId.Value);

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