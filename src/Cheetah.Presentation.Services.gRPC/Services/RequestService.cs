namespace Cheetah.Application.Services.gRPC.Services;

public class RequestService
    (ILogger<RequestService> logger,
        ApplicationDbContext db,
        ITableCRUD simpleClassRepository,
        ICartable iCartable, ISync iSync, IWorkItem iWorkItem,
        IMapper mapper, ICopyClass iCopyClass) : Request.RequestBase
{
    public override async Task<Brief_Request> CreateRequest(Create_Input_Request request, ServerCallContext context)
    {
        logger.LogInformation("started " + nameof(CreateRequest));
        logger.LogInformation("{@Create_Input_Request}", request);

        var output_Request = new Brief_Request();

        var f_Request = (F_Case)request.Case.GetSimpleClass(typeof(F_Case));
        f_Request.Creator = (D_User)request.Creator.GetSimpleClass(typeof(D_User));
        f_Request.Requestor = (D_User)request.Requestor.GetSimpleClass(typeof(D_User));
        f_Request.Process = (D_Process)request.Process.GetSimpleClass(typeof(D_Process));
        f_Request.Conditions = request.Conditions.GetCondition().ToList();

        var Outputresult = await iWorkItem.CreateRequestAsync(f_Request);

        var OutputState = Outputresult.SimpleClassDTO;

        output_Request.OutputState = OutputState.GetBaseClassWithName();

        if (Outputresult.Result.IsFailed)
        {
            return output_Request;
        }

        f_Request = Outputresult.Result.Value;

        output_Request.Process = f_Request.Process?.GetBaseClass();

        output_Request.CaseState = f_Request.CaseState?.GetBaseClass();

        logger.LogInformation("Ended " + nameof(CreateRequest));
        logger.LogInformation("{@Brief_Request}", output_Request);

        return output_Request;
    }
    public override async Task<Brief_Request> PerformRequest(Perform_Input_Request request, ServerCallContext context)
    {
        logger.LogInformation("started " + nameof(PerformRequest));
        logger.LogInformation("{@Perform_Input_Request}", request);

        var f_WorkItem = (F_WorkItem)request.WorkItem.GetSimpleClass(typeof(F_WorkItem));

        f_WorkItem.Case = new F_Case();

        f_WorkItem.Case.Conditions = request.Conditions.GetCondition().ToList();

        var Outputresult = await iWorkItem.PerformWorkItemAsync(f_WorkItem);
        f_WorkItem = Outputresult.Result.Value;
        var OutputState = Outputresult.SimpleClassDTO;

        var output_Request = new Brief_Request()
        {
            Case = f_WorkItem.Case?.GetBaseClass(),
            CaseState = f_WorkItem.Case?.CaseState?.GetBaseClass(),
            Process = f_WorkItem.Case?.Process?.GetBaseClass()
        };
        output_Request.OutputState = OutputState.GetBaseClassWithName();

        logger.LogInformation("Ended " + nameof(PerformRequest));
        logger.LogInformation("{@Brief_Request}", output_Request);

        return output_Request;
    }
    public override async Task<DetailOutput_Requests> GetCase(Brief_Request request, ServerCallContext context)
    {
        var f_Request = (F_Case)request.Case.GetSimpleClass(typeof(F_Case));
        var _Process = (D_Process)request.Process.GetSimpleClass(typeof(D_Process));
        var _CaseState = (D_CaseState)request.CaseState.GetSimpleClass(typeof(D_CaseState));

        var l_Requests = await iCartable.GetCaseAsync(f_Request);

        #region DetailOutput_Request

        DetailOutput_Requests output_Requests = new();

        var Endorsements = l_Requests.SelectMany(x => x.WorkItems)
           .Where(x => x.Endorsement != null)
           .Select(x => x.Endorsement)
           .Distinct();

        //var d_Tags = await db.D_Tags.AsNoTracking().ToListAsync();

        foreach (var l_Request in l_Requests)
        {
            DetailOutput_Request output_Request = new();


            output_Request = new()
            {
                Case = l_Request.GetBaseClass(),
                Process = l_Request.Process?.GetBaseClassWithName(),
            };

            #region CaseState
            output_Request.CaseState = l_Request.CaseState?.GetBaseClassWithName();
            #endregion

            #region Endorsements

            var lendorsements = Endorsements
                .OrderBy(x => x.SortIndex)
                .ToList();

            var endorsements = lendorsements
                .Select(x => new GRPC_Assignment()
                {
                    Endorsement = x.GetBaseClassWithName()
                });

            output_Request.Assignments.AddRange(endorsements);

            #endregion

            #region L_WorkItem

            var L_WorkItems = l_Request.WorkItems.ToList();

            foreach (var Assignment in output_Request.Assignments)
            {
                Assignment.UserAssignments.AddRange
                    (
                        L_WorkItems.Where(x => x.EndorsementId == Assignment.Endorsement.Id)
                        .Select(x => new GRPC_UserAssignment()
                        {
                            WorkItem = x.GetBaseClassWithNameAndDate(),
                            User = x.User?.GetBaseClassWithName(),
                            WorkItemState = x.WorkItemState?.GetBaseClassWithName()
                        }
                        )
                );
            }

            #region d_Tag


            foreach (var Assignment in output_Request.Assignments)
            {
                foreach (var UserAssignment in Assignment.UserAssignments)
                {
                    var TagId = L_WorkItems.Where(x => x.Id == UserAssignment.WorkItem.Id).Single().TagId;

                    if (TagId is not null && TagId > 0)
                    {
                        //var d_Tag = d_Tags.Where(x => x.Id == TagId).SingleOrDefault();
                        //UserAssignment.Tag = d_Tag.GetBaseClass();
                    }
                }
            }

            #endregion

            #endregion

            output_Requests.DetailOutputRequest.Add(output_Request);
        }

        #endregion

        output_Requests.OutputState = OutputState<Boolean>.Success(nameof(GetCase), true).SimpleClassDTO.GetBaseClassWithName();

        return output_Requests;
    }
    public override async Task<TableInfo> GetAllByName(TableInfo request, ServerCallContext context)
    {
        TableInfo tableInfo = new();
        var TableRecords = await simpleClassRepository.GetAllByName(request.TableInput.Name);
        //tableInfo.TableOutput.AddRange(
        //    TableRecords.Select(x => new GRPC_BaseClass()
        //    {
        //        Id = x.GetBaseClassWithName(x)
        //        Name = x.Name,
        //        DisplayName = x.DisplayName,
        //        ERPCode = x.ERPCode.Value
        //    })
        //    );
        return tableInfo;
    }

    #region Cartable
    public async Task<OutputCartable> Cartable(InputCartable request, CartableProperty cartableProperty)
    {
        logger.LogInformation("started " + nameof(Cartable));
        logger.LogInformation("{@InputCartable}", request);

        OutputCartable _OutputCartable = new();

        var _D_User = (SimpleClassDTO)request.Assignee.GetSimpleClass(typeof(SimpleClassDTO));
        var _D_Process = (SimpleClassDTO)request.Process.GetSimpleClass(typeof(SimpleClassDTO));
        var _D_CaseState = (SimpleClassDTO)request.CaseState.GetSimpleClass(typeof(SimpleClassDTO));

        var cartableDTO = new CartableDTO()
        {
            User = _D_User,
            Process = _D_Process,
            CaseState = _D_CaseState,
            PageSize = request.PageSize,
            PageNumber = request.PageNumber,
        };

        var OutputRequest = ((cartableProperty == CartableProperty.Inbox) ?
           await iCartable.Inbox(cartableDTO) :
           await iCartable.Outbox(cartableDTO)).ToList<CartableDTO>();

        if (OutputRequest.Count() > 0)
        {
            _OutputCartable.TotalItems = OutputRequest.FirstOrDefault()?.TotalItems.Value;
            _OutputCartable.Assignee = OutputRequest.FirstOrDefault()?.User.GetBaseClassWithName();
            _OutputCartable.Process = OutputRequest.FirstOrDefault()?.Process.GetBaseClassWithName();
            _OutputCartable.CaseState = OutputRequest.FirstOrDefault()?.CaseState.GetBaseClassWithName();

            //var _Recordtable = OutputRequest.Select(
            //     x => new RecordCartable()
            //     {
            //         CreateDate = x.CreateDate.CGetTimestamp(),
            //         CaseState = GetBaseClass(x.CaseState),
            //         DTag = GetBaseClass(x.Tag),
            //         RecieveDate = x.RecieveDate.CGetTimestamp(),
            //         Summary = x.Summary ?? String.Empty,
            //         Process = GetBaseClass(x.Process),
            //         WorkItem = GetBaseClass(x.WorkItem),
            //         CaseId = long.Parse(x.RadNumber),
            //         ERPCode = x.ERPCode.Value,
            //         WorkItemId = long.Parse(x.WorkItemId),
            //         Requestor = GetBaseClass(x.Requestor),
            //         Task = GetBaseClass(x.Task)
            //     }
            //     );

            //_OutputCartable.RecordCartables.AddRange(_Recordtable);

            foreach (var RecordCartable in _OutputCartable.RecordCartables)
            {
                RecordCartable.ValidUserActions.AddRange(
                   OutputRequest
                   .Where(x => x.WorkItemId == RecordCartable.WorkItem.Id.ToString())
                   .Single().ValidUserActions
                   .Select(y => y.GetBaseClass())
                   );
            }
        }
        logger.LogInformation("Ended " + nameof(Cartable));
        logger.LogInformation("{@OutputCartable}", _OutputCartable);

        _OutputCartable.OutputState = OutputState<Boolean>.Success(nameof(Cartable), true).SimpleClassDTO.GetBaseClassWithName();

        return _OutputCartable;
    }
    public override Task<OutputCartable> Inbox(InputCartable request, ServerCallContext context)
    {
        return Cartable(request, CartableProperty.Inbox);
    }
    public override Task<OutputCartable> Outbox(InputCartable request, ServerCallContext context)
    {
        return Cartable(request, CartableProperty.Outbox);
    }
    #endregion 
}