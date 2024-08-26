using Cheetah.Core.Aggregates.CaseAggregate.Facts;
using Cheetah.Core.Aggregates.CaseAggregate.Links;
using Cheetah.Core.Aggregates.CaseAggregate.Specifications;
using Cheetah.Core.Aggregates.ConditionAggregate.DTOs;
using Cheetah.Core.Aggregates.ConditionAggregate.Facts;
using Cheetah.Core.Aggregates.ProcessAggregate.Dimentions;
using Cheetah.Core.Aggregates.ProcessAggregate.Facts;
using Cheetah.Core.Aggregates.UserAggregate.Dimentions;
using Cheetah.Core.Common.DTOs;
using Cheetah.Core.Interfaces;
using Cheetah.Core.Interfaces.WorkItem;
using Cheetah.Core.Interfaces.WorkItem.DTOs;
using Cheetah.UseCases.Commands.Case.CaseTaskUser.Create;
using Cheetah.UseCases.Commands.Case.WorkItem.Update;
using Cheetah.UseCases.Queries.Case.Case.Get;
using Cheetah.UseCases.Queries.Case.WorkItem.Get;

namespace Cheetah.UseCases.Services;
public class WorkItem(ICopyClass _iCopyClass,
    ISender iSender, IMemoryCache _cache,
    IRepository<F_WorkItem> workItemRepository,
    IRepository<F_Case> caseRepository,
    IRepository<F_Task> taskRepository,
    IRepository<D_User> userRepository,
    IRepository<F_Condition> conditionRepository,
    IRepository<D_Process> processRepository,
    IRepository<L_WorkItemCondition> workItemConditionRepository,
    IRepository<L_CaseCondition> caseConditionRepository,
    IRepository<L_CaseTaskUser> caseTaskUserRepository
    ) : IWorkItem
{
    public async Task<Result<bool>> ClearProjectAsync()
    {
        await ClearCasesAsync();

        return true;
    }
    public async Task<Result<bool>> ClearCasesAsync()
    {
        var _workItemConditions = await workItemConditionRepository.ListAsync();
        await workItemConditionRepository.DeleteRangeAsync(_workItemConditions);

        var _workItems = await workItemRepository.ListAsync();
        await workItemRepository.DeleteRangeAsync(_workItems);

        var _caseConditions = await caseConditionRepository.ListAsync();
        await caseConditionRepository.DeleteRangeAsync(_caseConditions);

        var _caseTaskUserRepository = await caseTaskUserRepository.ListAsync();
        await caseTaskUserRepository.DeleteRangeAsync(_caseTaskUserRepository);

        var _cases = await caseRepository.ListAsync();
        await caseRepository.DeleteRangeAsync(_cases);

        return true;
    }

    public async Task<Result<CreateCase_Response>> CreateRequestAsync(CreateCase_Request request)
    {
        #region Input

        SimpleClassDTO _case = request.Case.Adapt<SimpleClassDTO>();
        SimpleClassDTO _creator = request.Creator.Adapt<SimpleClassDTO>();
        SimpleClassDTO _requestor = request.Requestor.Adapt<SimpleClassDTO>();
        SimpleClassDTO _process = request.Process.Adapt<SimpleClassDTO>();
        List<ConditionDTO> _caseConditions = request?.Conditions;
        SimpleClassDTO _workItemUser = request.WorkItem.User.Adapt<SimpleClassDTO>();
        List<ConditionDTO> _workItemConditions = request.WorkItem.OccurredUserActions;
        SimpleClassDTO _workItemBase = request.WorkItem.Base.Adapt<SimpleClassDTO>();

        #endregion

        CreateCase_Response output_Request = new();

        var GeneralRequest = await iSender.Send(
            new GetCaseQuery(Case: _case, Creator: _creator, Requestor: _requestor, Process: _process,
            CaseConditions: _caseConditions, WorkItemUser: _workItemUser,
            WorkItemConditions: _workItemConditions, WorkItemBase: _workItemBase));

        var _getCaseSpec = new GetIdCaseSpec(processId: GeneralRequest.Value.ProcessId.Value,
        eRPCode: GeneralRequest.Value.ERPCode.Value);

        Result<long> _OutputState;

        var _duplicateCaseID = await caseRepository.FirstOrDefaultAsync(_getCaseSpec);
        if (_duplicateCaseID is not null)
        {
            var _result = Result.Conflict(_duplicateCaseID.ToString());
            output_Request.OutputState = new BaseClassWithNameDTO()
            {
                Id = 1,
                Name = _result.Status.ToString(),
                DisplayName = $"شماره رهگیری {_result.Errors.First()} تکراری است"
            };

            return output_Request;
        }

        GeneralRequest = await SetWorkItems.Handle(iSender, taskRepository,
            Current_Case: GeneralRequest, Current_WorkItem: GeneralRequest.Value.WorkItems.First());

        GeneralRequest.Value.SetLastModified();

        var _createdCase = await caseRepository.AddAsync(GeneralRequest);

        _OutputState = Result<long>.Success(_createdCase.Id);

        output_Request.OutputState = new BaseClassWithNameDTO() { Id = 0 };

        long _createdCaseId = _OutputState.Value;

        output_Request.Case = new()
        {
            Base = new()
            {
                Id = _createdCaseId
            }
        };

        return output_Request;
    }
    public async Task<Result<UpdateWorkItem_Response>> PerformWorkItemAsync(UpdateWorkItem_Request request)
    {
        #region Input
        SimpleClassDTO _workItem = request.WorkItem.Base.Adapt<SimpleClassDTO>();
        SimpleClassDTO _workItemUser = request.WorkItem.User.Adapt<SimpleClassDTO>();
        List<ConditionDTO> _workItemConditions = request.WorkItem.OccurredUserActions;
        bool _rebase = request.Rebase ?? false;
        #endregion

        UpdateWorkItem_Response _performRequest_Response = new();

        var Current_WorkItem = await iSender.Send(new GetWorkItemQuery(
            _workItem, _workItemUser, _workItemConditions, _rebase));

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

        #region Output

        _performRequest_Response.OutputState = new BaseClassWithNameDTO() { Id = 0 };

        var _createdCaseId = Current_WorkItem.Value.CaseId!.Value;

        var _getDetailCasesQuery_Input = new SimpleClassDTO()
        {
            Id = _createdCaseId
        };

        var _getDetailCasesQuery_Output =
            await caseRepository.FirstOrDefaultAsync(new GetCaseSpec(id: _createdCaseId));

        _performRequest_Response.Case = new();

        _performRequest_Response.Case.Base = _getDetailCasesQuery_Output.Adapt<BaseClassWithDateDTO>();

        _performRequest_Response.Case.CaseState = _getDetailCasesQuery_Output?.CaseState.Adapt<BaseClassWithNameDTO>();

        #endregion

        return _performRequest_Response;
    }
    public async Task<Result<UpdateWorkItemUser_Response>> SetCaseTaskUserAsync(UpdateWorkItemUser_Request CaseTaskUser)
    {
        var _addedCaseTaskUsers = await iSender.Send(new CreateCaseTaskUserCommand(CaseTaskUser));

        return Result.Success(_addedCaseTaskUsers.Value.Adapt<UpdateWorkItemUser_Response>(), "با موفقیت ایجاد شد");
    }
}