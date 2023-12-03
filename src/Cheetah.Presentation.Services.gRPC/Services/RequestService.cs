using System.Linq;

namespace Cheetah.Application.Services.gRPC.Services;

public class RequestService
    (ILogger<RequestService> logger,
        ApplicationDbContext db,
        ITableCRUD simpleClassRepository,
        ICartable iCartable, ISync iSync, IWorkItem iWorkItem,
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
        f_Request.Conditions = request.Conditions.GetCondition().ToList();

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
        var f_WorkItem = request.WorkItem.GetSimpleClass<F_WorkItem>();

        f_WorkItem.Case = new F_Case();

        f_WorkItem.Case.Conditions = request.Conditions.GetCondition().ToList();
        #endregion

        var Outputresult = await iWorkItem.PerformWorkItemAsync(f_WorkItem);

        #region Output
        f_WorkItem = Outputresult.Result.Value;
        var OutputState = Outputresult.SimpleClassDTO;

        PerformRequest_Output output_Request = new()
        {
            Case = f_WorkItem.Case?.GetBaseClass(),
            CaseState = f_WorkItem.Case?.CaseState?.GetBaseClass(),
            Process = f_WorkItem.Case?.Process?.GetBaseClass()
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
        #endregion

        var l_Request = await iCartable.GetCaseAsync(f_Request).Result.FirstOrDefaultAsync();

        #region Output

        #region GetCase_Output

        GetCase_Output output_Requests = new()
        {
            Case = l_Request?.GetBaseClass(),
            CaseState = l_Request?.CaseState?.GetBaseClassWithName(),
            Process = l_Request?.Process?.GetBaseClassWithName()
        };

        #region Endorsements

        var Endorsements = l_Request?
            .SelectedScenario
            .Endorsements
            .OrderBy(x => x.SortIndex)
            .ToList();


        output_Requests.Endorsements.AddRange(
            Endorsements.Select(x => new GRPC_Endorsement()
            {
                Endorsement = x.GetBaseClassWithName()
            })
            );

        #endregion

        #region L_WorkItem

        foreach (var Endorsement in output_Requests.Endorsements)
        {
            Endorsement.WorkItems.AddRange(
            l_Request?.WorkItems
                .Where(x => x.EndorsementId == Endorsement.Endorsement.Id)
                .Select(x => new GRPC_WorkItem()
                {
                    User = x.User.GetBaseClassWithName(),
                    Tag = x.Tag.GetBaseClassWithName(),
                    WorkItemState = x.WorkItemState?.GetBaseClassWithName(),
                    WorkItem = x.GetBaseClassWithDate()
                })
                );
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
                    Endorsement = outputRequestItem.Endorsement.GetBaseClassWithName(),
                    Tag = outputRequestItem.Tag.GetBaseClassWithName()
                };

                recordCartable.ValidUserActions.AddRange(outputRequestItem.ValidUserActions.Select(_ => _.GetBaseClassWithName()));

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