﻿namespace Cheetah.Application.Services.gRPC.Services;

public class RequestService(ILogger<RequestService> logger, ApplicationDbContext db,
        ITableCRUD simpleClassRepository, ICartable iCartable, IWorkItem iWorkItem,
        IMapper mapper, ICopyClass iCopyClass) : Request.RequestBase
{
    public override async Task<CreateRequest_Output> CreateRequest(CreateRequest_Input request, ServerCallContext context)
    {
        logger.LogInformation("started " + nameof(CreateRequest));
        logger.LogInformation("{@Create_Input_Request}", request);

        #region Input

        F_Case f_Request = request.Case.GetSimpleClass<F_Case>();
        f_Request.Creator = request.Creator.GetSimpleClass<D_User>();
        f_Request.Requestor = request.Requestor.GetSimpleClass<D_User>();
        f_Request.Process = request.Process.GetSimpleClass<D_Process>();
        var _conditions = request.Conditions.GetConditions().ToList();
        F_WorkItem _workItem = request.WorkItem.GetWorkItemClass();

        f_Request.WorkItems.Add(_workItem);

        foreach (var _condition in _conditions)
        {
            L_CaseCondition _CaseCondition = new()
            {
                Condition = _condition,
                SecondId = _condition.Id
            };

            f_Request.CaseConditions.Add(_CaseCondition);
        }
        #endregion

        var Outputresult = await iWorkItem.CreateRequestAsync(f_Request);

        #region Output

        var OutputState = Outputresult.SimpleClassDTO;

        CreateRequest_Output output_Request = new();

        output_Request.OutputState = OutputState.GetBaseClassWithName();

        if (Outputresult.Result.IsFailed)
        {
            return output_Request;
        }

        f_Request = Outputresult.Result.Value;

        output_Request.Case = f_Request.GetBaseClassWithDate();

        #endregion

        logger.LogInformation("Ended " + nameof(CreateRequest));
        logger.LogInformation("{@Create_Output_Request}", output_Request);

        return output_Request;
    }
    public override async Task<PerformRequest_Output> PerformRequest(PerformRequest_Input request, ServerCallContext context)
    {
        logger.LogInformation("started " + nameof(PerformRequest));
        logger.LogInformation("{@Perform_Input_Request}", request);

        #region Input
        var f_WorkItem = request.WorkItem.WorkItem.GetSimpleClass<F_WorkItem>();

        f_WorkItem.Case = new();

        //f_WorkItem.Case.Conditions = request.Conditions.GetCondition().ToList();
        var _conditions = request.WorkItem.Conditions.GetConditions();

        foreach (var _condition in _conditions)
        {
            L_CaseCondition _caseCondition = new()
            {
                Case = f_WorkItem.Case,
                FirstId = f_WorkItem.CaseId,
                Condition = _condition,
                SecondId = _condition.Id
            };
            f_WorkItem.Case.CaseConditions.Add(_caseCondition);
        }
        #endregion

        var Outputresult = await iWorkItem.PerformWorkItemAsync(f_WorkItem, request.Rebase);

        #region Output

        var OutputState = Outputresult.SimpleClassDTO;

        PerformRequest_Output output_Request = new();

        output_Request.OutputState = OutputState.GetBaseClassWithName();

        if (Outputresult.Result.IsFailed)
        {
            return output_Request;
        }
        f_WorkItem = Outputresult.Result.Value;

        output_Request = new()
        {
            Case = f_WorkItem.Case?.GetBaseClass(),
            CaseState = f_WorkItem.Case?.CaseState?.GetBaseClassWithName(),
            Process = f_WorkItem.Case?.Process?.GetBaseClassWithName()
        };

        output_Request.OutputState = OutputState.GetBaseClassWithName();

        #endregion

        logger.LogInformation("Ended " + nameof(PerformRequest));
        logger.LogInformation("{@Perform_Output_Request}", output_Request);

        return output_Request;
    }
    public override async Task<GetCase_Output> GetCase(GetCase_Input request, ServerCallContext context)
    {
        #region Input
        var f_Request = request.Case.GetSimpleClass<F_Case>();
        f_Request.CaseState = request.CaseState.GetSimpleClass<D_CaseState>();
        f_Request.Process = request.Process.GetSimpleClass<D_Process>();
        #endregion

        #region Output

        #region GetCase_Output

        var _l_Request = await iCartable.GetCaseAsync(f_Request);
        var l_Request = _l_Request.FirstOrDefault();

        GetCase_Output output_Requests = new()
        {
            Case = l_Request?.GetBaseClass(),
            CaseState = l_Request?.CaseState?.GetBaseClassWithName(),
            Process = l_Request?.Process?.GetBaseClassWithName()
        };

        if (!_l_Request.Any())
        {
            output_Requests.OutputState = OutputState<Boolean>.NotFoundErrorCreateRequest(false).SimpleClassDTO.GetBaseClassWithName();
            return output_Requests;
        }

        #region Tasks

        var Tasks = l_Request?
            .SelectedScenario
            .Tasks
            .OrderBy(x => x.SortIndex)
            .ToList();


        output_Requests.Tasks.AddRange(
            Tasks.Select(x => new GRPC_Task()
            {
                Task = x.GetBaseClassWithName()
            })
            );

        #endregion

        #region L_WorkItem

        foreach (var Task in output_Requests.Tasks)
        {
            Task.WorkItems.AddRange(
            l_Request?.WorkItems
                .Where(x => x.TaskId == Task.Task.Id)
                .Select(x => new GRPC_WorkItem()
                {
                    User = x.User.GetBaseClassWithName(),
                    WorkItemState = x.WorkItemState?.GetBaseClassWithName(),
                    WorkItem = x.GetBaseClassWithDate()
                })
                );
            foreach (var workItem in Task.WorkItems)
            {
                workItem.Conditions.AddRange(
                l_Request?.WorkItems
                .Where(x => x.Id == workItem.WorkItem.Id)
                .Single()
                .WorkItemConditions.Select(x => x.Condition).GetCondition()
                );
            }
        }

        #endregion

        #endregion

        output_Requests.OutputState = OutputState<Boolean>.Success(nameof(GetCase), true).SimpleClassDTO.GetBaseClassWithName();

        #endregion

        return output_Requests;
    }
    public override async Task<GetAllByName_Output> GetAllByName(GetAllByName_Input request, ServerCallContext context)
    {
        GetAllByName_Output getAllByName_Output = new();

        if (String.IsNullOrWhiteSpace(request.TableInput.Name))
        {
            return getAllByName_Output;
        }

        #region Input

        getAllByName_Output.TableInput = request.TableInput;

        #endregion

        var TableRecords = await simpleClassRepository.GetAllBySimpleClass(getAllByName_Output.TableInput.GetSimpleClass<SimpleClassDTO>());

        #region Output

        getAllByName_Output.TableInput = TableRecords.Item1.GetBaseClassWithName();

        getAllByName_Output.TableOutput.AddRange(TableRecords.Item2.Select(x => x.GetBaseClassWithName()));

        getAllByName_Output.OutputState = OutputState<Boolean>.Success(nameof(GetAllByName), true).SimpleClassDTO.GetBaseClassWithName();

        #endregion

        return getAllByName_Output;
    }
    public override async Task<SetCaseTaskUser_Output> SetCaseTaskUser(SetCaseTaskUser_Input request, ServerCallContext context)
    {
        logger.LogInformation("started " + nameof(SetCaseTaskUser) + $": {request}");

        #region Input

        L_CaseTaskUser l_CaseTaskUser = new();
        l_CaseTaskUser.Case = request.Case.GetSimpleClass<F_Case>();
        l_CaseTaskUser.Task = request.Task.GetSimpleClass<F_Task>();
        l_CaseTaskUser.User = request.User.GetSimpleClass<D_User>();

        #endregion

        var Outputresult = await iWorkItem.SetCaseTaskUser(l_CaseTaskUser);

        #region Output

        var OutputState = Outputresult.SimpleClassDTO;

        SetCaseTaskUser_Output output_Request = new();

        output_Request.OutputState = OutputState.GetBaseClassWithName();

        if (Outputresult.Result.IsFailed)
        {
            return output_Request;
        }

        var _list_CaseTaskUser = Outputresult.Result.Value;

        output_Request.Case = Outputresult.Result.Value.Case.GetBaseClass();
        output_Request.Task = Outputresult.Result.Value.Task.GetBaseClassWithName();
        output_Request.User = Outputresult.Result.Value.User.GetBaseClassWithName();

        #endregion

        logger.LogInformation("Ended " + nameof(CreateRequest));
        logger.LogInformation("{@Create_Output_Request}", output_Request);

        return output_Request;
    }

    #region Cartable
    public async Task<Cartable_Output> Cartable(Cartable_Input request, CartableProperty cartableProperty)
    {
        logger.LogInformation("started " + nameof(Cartable));
        logger.LogInformation("{@InputCartable}", request);

        #region Input

        var assignee = request.Assignee.GetSimpleClass<SimpleClassDTO>();
        var process = request.Process.GetSimpleClass<SimpleClassDTO>();
        var caseState = request.CaseState.GetSimpleClass<SimpleClassDTO>();
        var caseItem = request.Case.GetSimpleClass<SimpleClassDTO>();
        var workItem = request.WorkItem.GetSimpleClass<SimpleClassDTO>();

        var cartableDTO = new CartableDTO()
        {
            User = assignee,
            Process = process,
            Case = caseItem,
            WorkItem = workItem,
            CaseState = caseState,
            PageSize = request.PageSize,
            PageNumber = request.PageNumber,
        };

        #endregion

        var OutputRequest = ((cartableProperty == CartableProperty.Inbox) ?
           await iCartable.Inbox(cartableDTO) :
           await iCartable.Outbox(cartableDTO)).ToList<CartableDTO>();

        #region Output
        Cartable_Output _OutputCartable = new();

        if (OutputRequest.Count() > 0)
        {
            _OutputCartable.TotalItems = OutputRequest.FirstOrDefault()?.TotalItems.Value;
            _OutputCartable.PageSize = OutputRequest.FirstOrDefault()?.PageSize.Value;
            _OutputCartable.PageNumber = OutputRequest.FirstOrDefault()?.PageNumber.Value;

            foreach (var outputRequestItem in OutputRequest)
            {
                RecordCartable recordCartable = new()
                {
                    Process = outputRequestItem.Process.GetBaseClassWithName(),
                    Case = outputRequestItem.Case.GetBaseClassWithDate(),
                    CaseState = outputRequestItem.CaseState.GetBaseClassWithName(),
                    Requestor = outputRequestItem.Requestor.GetBaseClassWithName(),
                    WorkItem = outputRequestItem.WorkItem.GetBaseClassWithDate(),
                    Assignee = outputRequestItem.User.GetBaseClassWithName(),
                    Task = outputRequestItem.Task.GetBaseClassWithName()
                };

                recordCartable.ValidUserActions
                    .AddRange(outputRequestItem.ValidUserActions.Select(x => x.GetBaseClassWithName()));

                recordCartable.Conditions
                    .AddRange(outputRequestItem.Conditions.Select(x => x.GetBaseClassWithName()));

                _OutputCartable.RecordCartables.Add(recordCartable);
            }

        }
        #endregion

        logger.LogInformation("Ended " + nameof(Cartable));
        logger.LogInformation("{@OutputCartable}", _OutputCartable);

        _OutputCartable.OutputState = OutputState<Boolean>.Success(nameof(Cartable), true).SimpleClassDTO.GetBaseClassWithName();

        return _OutputCartable;
    }
    public override Task<Cartable_Output> Inbox(Cartable_Input request, ServerCallContext context)
    {
        return Cartable(request, CartableProperty.Inbox);
    }
    public override Task<Cartable_Output> Outbox(Cartable_Input request, ServerCallContext context)
    {
        return Cartable(request, CartableProperty.Outbox);
    }
    #endregion 
}