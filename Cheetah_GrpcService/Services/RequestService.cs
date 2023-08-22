using AutoMapper;
using Azure.Core;
using Cheetah_Business;
using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Cheetah_Business.Facts;
using Cheetah_Business.Repository;
using Cheetah_DataAccess.Data;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Serilog.Parsing;

namespace Cheetah_GrpcService.Services
{
    public class RequestService : Request.RequestBase
    {
        private readonly ILogger<RequestService> _logger;
        private readonly ITableCRUD simpleClassRepository;
        private readonly ICartable iCartable;
        private readonly ISync iSync;
        private readonly IView iView;
        private readonly IWorkItem iWorkItem;
        private readonly IMapper _mapper;
        private readonly ICopyClass _iCopyClass;
        protected ApplicationDbContext _db;
        public RequestService(ILogger<RequestService> logger,
            ApplicationDbContext db,
            ITableCRUD iP_ParameterListRepository,
            ICartable _iCartable, ISync _iSync, IView _iView, IWorkItem _iWorkItem,
            IMapper mapper, ICopyClass _iCopyClass)
        {
            _logger = logger;
            _db = db;
            this._mapper = mapper;
            this.simpleClassRepository = iP_ParameterListRepository;
            this.iCartable = _iCartable;
            this.iSync = _iSync;
            this.iView = _iView;
            this.iWorkItem = _iWorkItem;
            this._iCopyClass = _iCopyClass;
        }


        public IEnumerable<F_Condition> GetCondition(IEnumerable<Condition> Conditions)
        {

            foreach (var Condition in Conditions)
            {
                var f_Condition = new F_Condition();
                if (Condition.Tag is not null)
                {
                    f_Condition.Tag = new D_Tag() { ERPCode = Condition?.Tag?.ERPCode };
                }
                if (Condition.Operand is not null)
                {
                    f_Condition.Operand = new D_Operand() { ERPCode = Condition?.Operand?.ERPCode };
                }
                if (Condition.Value is not null)
                {
                    f_Condition.Value = Condition.Value;
                }
                if (Condition.User is not null)
                {
                    f_Condition.User = new D_User() { ERPCode = Condition?.User?.ERPCode };
                }

                yield return f_Condition;
            }
        }

        public override async Task<Brief_Request> CreateRequest(Create_Input_Request request, ServerCallContext context)
        {
            var f_Request = new F_Case();

            f_Request.Creator = new()
            {
                Name = request.Creator.Name,
                ERPCode = request.Creator.ERPCode
            };

            f_Request.Requestor = new()
            {
                Name = request.Requestor.Name,
                ERPCode = request.Requestor.ERPCode
            };
            f_Request.Process = new()
            {
                Name = request.Process.Name,
                ERPCode = request.Process.ERPCode
            };

            f_Request.ERPCode = request.ERPCode;

            f_Request.Conditions = GetCondition(request.Conditions).ToList();

            f_Request = await iWorkItem.CreateRequestAsync(f_Request);

            var output_Request = new Brief_Request();

            output_Request.CaseId = f_Request.Id.Value;

            output_Request.ERPCode = f_Request.ERPCode.Value;

            var processes = await _db.D_Processes
                .Where(x => x.Id == f_Request.ProcessId)
                .SingleAsync();

            var caseState = await _db.D_CaseStates
                .Where(x => x.Id == f_Request.CaseStateId)
                .SingleAsync();

            output_Request.Process =
            new()
            {
                Id = processes.Id.Value,
                ERPCode = processes.ERPCode.Value,
                Name = processes.Name,
                DisplayName = processes.DisplayName
            };

            output_Request.CaseState =
                new()
                {
                    Id = caseState.Id.Value,
                    ERPCode = caseState.ERPCode.Value,
                    Name = caseState.Name,
                    DisplayName = caseState.DisplayName
                };

            return output_Request;
        }
        public override async Task<Brief_Request> PerformRequest(Perform_Input_Request request, ServerCallContext context)
        {
            var f_WorkItem = new F_WorkItem();

            f_WorkItem.Id = request.WorkItemId;

            f_WorkItem.Case = new F_Case();

            f_WorkItem.Case.Conditions = GetCondition(request.Conditions).ToList();

            f_WorkItem = await iWorkItem.PerformWorkItemAsync(f_WorkItem);

            var output_Request = new Brief_Request()
            {
                CaseId = f_WorkItem.Case.Id.Value,
                CaseState = new GRPC_BaseClass()
                {
                    Id = f_WorkItem.Case.CaseStateId.Value,
                    ERPCode = f_WorkItem.Case.CaseState.ERPCode.Value,
                    Name = f_WorkItem.Case.CaseState.Name,
                    DisplayName = f_WorkItem.Case.CaseState.DisplayName
                },
                Process = new GRPC_BaseClass()
                {
                    Id = f_WorkItem.Case.Process.Id.Value,
                    ERPCode = f_WorkItem.Case.Process.ERPCode.Value,
                    Name = f_WorkItem.Case.Process.Name,
                    DisplayName = f_WorkItem.Case.Process.DisplayName
                },
                ERPCode = f_WorkItem.Case.ERPCode.Value
            };

            return output_Request;
        }
        public override async Task<DetailOutput_Requests> GetCase(Brief_Request request, ServerCallContext context)
        {
            F_Case f_Request = new();

            #region CaseId
            if (request.CaseId > 0)
            {
                f_Request.Id = request.CaseId;
            }
            #endregion

            #region ERPCode
            if (request.ERPCode > 0)
            {
                f_Request.ERPCode = request.ERPCode;
            }
            #endregion

            #region Process

            if (request.Process is not null)
            {
                var _Process = _db.D_Processes
                    .AsNoTracking();

                if (!String.IsNullOrEmpty(request.Process.Name))
                {
                    _Process = _Process.Where(x => x.Name == request.Process.Name);
                }
                if (request.Process.ERPCode > 0)
                {
                    _Process = _Process.Where(x => x.ERPCode == request.Process.ERPCode);
                }
                if (_Process.Any())
                {
                    f_Request.ProcessId = _Process
                                .Select(x => x.Id)
                                .Single();
                }
            }

            #endregion

            #region CaseState

            if (request.CaseState is not null)
            {
                var _CaseStates = _db.D_CaseStates
                    .AsNoTracking();

                if (!String.IsNullOrEmpty(request.CaseState.Name))
                {
                    _CaseStates = _CaseStates.Where(x => x.Name == request.CaseState.Name);
                }
                if (request.Process.ERPCode > 0)
                {
                    _CaseStates = _CaseStates.Where(x => x.ERPCode == request.CaseState.ERPCode);
                }

                if (_CaseStates.Any())
                {
                    f_Request.CaseStateId = _CaseStates
                              .Select(x => x.Id)
                              .Single();
                }
            }

            #endregion

            var l_Requests = await iCartable.GetCaseAsync(f_Request);

            #region DetailOutput_Request

            DetailOutput_Requests output_Requests = new();

            var Endorsements = _db.F_Cases
               .SelectMany(x => x.WorkItems)
               .Where(x => x.Endorsement != null)
               .Select(x => x.Endorsement)
               .Distinct();

            var d_Tags = await _db.D_Tags.AsNoTracking().ToListAsync();

            foreach (var l_Request in l_Requests)
            {
                DetailOutput_Request output_Request = new();
                output_Request = new()
                {
                    Id = l_Request.Id.Value,
                    Process = new GRPC_BaseClass() { Name = l_Request.Process.Name },
                    ERPCode = l_Request.ERPCode.Value
                };

                #region CaseState
                output_Request.CaseState =
                              new()
                              {
                                  Id = l_Request.CaseStateId.Value,
                                  Name = l_Request.CaseState.Name,
                                  DisplayName = l_Request.CaseState.DisplayName
                              };
                #endregion

                #region Endorsements

                output_Request.Assignments.AddRange(
                    Endorsements
                    .OrderBy(x => x.SortIndex)
                    .Select(x => new GRPC_Assignment()
                    {
                        Endorsement = new GRPC_BaseClass()
                        {
                            Id = x.Id.Value,
                            Name = x.Name,
                            DisplayName = x.DisplayName
                        }
                    })
                    );

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
                                WorkItemId = x.Id.Value,
                                LastUpdatedRecord =
                                (x.LastUpdatedRecord is null) ? new Timestamp() :
                                Timestamp.FromDateTime(
                                    DateTime.SpecifyKind(x.LastUpdatedRecord.Value, DateTimeKind.Utc)),
                                User = new GRPC_BaseClass()
                                {
                                    Id = x.UserId.Value,
                                    ERPCode = x.User.ERPCode.Value,
                                    Name = x.User.Name,
                                    DisplayName = x.User.DisplayName
                                },

                                WorkItemState = new GRPC_BaseClass()
                                {
                                    Id = x.WorkItemStateId ?? 0,
                                    ERPCode = x.WorkItemState.ERPCode.Value,
                                    Name = x.WorkItemState?.Name ?? String.Empty,
                                    DisplayName = x.WorkItemState?.DisplayName ?? String.Empty
                                }
                            }
                            )
                    );
                }

                #region d_Tag


                foreach (var Assignment in output_Request.Assignments)
                {
                    foreach (var UserAssignment in Assignment.UserAssignments)
                    {
                        var TagId = L_WorkItems.Where(x => x.Id == UserAssignment.WorkItemId).Single().TagId;

                        if (TagId is not null && TagId > 0)
                        {
                            var d_Tag = d_Tags.Where(x => x.Id == TagId).SingleOrDefault();

                            UserAssignment.Tag = new GRPC_BaseClass()
                            {
                                Id = d_Tag.Id ?? 0,
                                ERPCode = d_Tag.ERPCode.Value,
                                Name = d_Tag?.Name ?? String.Empty,
                                DisplayName = d_Tag?.DisplayName ?? String.Empty
                            };
                        }
                    }
                }

                #endregion

                #endregion

                output_Requests.DetailOutputRequest.Add(output_Request);
            }

            #endregion

            return output_Requests;
        }
        public async Task<PageCartable> Cartable(PageCartable request, CartableProperty cartableProperty)
        {
            var _Username = String.Empty;

            if (request.Assignee is not null)
            {
                var _d_Users = _db.D_Users.AsNoTracking();
                if (!String.IsNullOrEmpty(request.Assignee.Name))
                {
                    _d_Users = _d_Users.Where(x => x.Name == request.Assignee.Name);
                }
                if (request.Assignee.ERPCode > 0)
                {
                    _d_Users = _d_Users.Where(x => x.ERPCode == request.Assignee.ERPCode);
                }
                _Username = await _d_Users.Select(x => x.Name).SingleAsync();
            }

            var _ProcessName = String.Empty;

            if (request.Assignee is not null)
            {
                var _d_Processes = _db.D_Processes.AsNoTracking();

                if (!String.IsNullOrEmpty(request.Process.Name))
                {
                    _d_Processes = _d_Processes.Where(x => x.Name == request.Process.Name);
                }
                if (request.Assignee.ERPCode > 0)
                {
                    _d_Processes = _d_Processes.Where(x => x.ERPCode == request.Process.ERPCode);
                }
                _ProcessName = await _d_Processes.Select(x => x.Name).SingleAsync();
            }

            var _CaseState = String.Empty;

            if (request.Assignee is not null)
            {
                var _CaseStates = _db.D_CaseStates.AsNoTracking();

                if (!String.IsNullOrEmpty(request.Process.Name))
                {
                    _CaseStates = _CaseStates.Where(x => x.Name == request.CaseState.Name);
                }
                if (request.Assignee.ERPCode > 0)
                {
                    _CaseStates = _CaseStates.Where(x => x.ERPCode == request.CaseState.ERPCode);
                }
                _CaseState = await _CaseStates.Select(x => x.Name).SingleAsync();
            }

            var cartableDTO = new CartableDTO()
            {
                Username = _Username,
                ProcessName = _ProcessName,
                PageSize = request.PageSize,
                PageNumber = request.PageNumber,
                CaseState = (request.CaseState is null) ? new() : new SimpleClassDTO()
                {
                    Name = _CaseState
                }
            };

            var OutputRequest = ((cartableProperty == CartableProperty.Inbox) ?
               await iCartable.Inbox(cartableDTO) :
               await iCartable.Outbox(cartableDTO)).ToList<CartableDTO>();

            request.TotalItems = OutputRequest.FirstOrDefault().TotalItems.Value;

            var _Recordtable = OutputRequest.Select(
                 x => new RecordCartable()
                 {
                     CreateDate = Timestamp.FromDateTime(
                         DateTime.SpecifyKind(
                         x.CreateDate.Value, DateTimeKind.Utc)),
                     CaseState = new GRPC_BaseClass()
                     {
                         Id = x.CaseState.Id.Value,
                         ERPCode = x.CaseState.ERPCode.Value,
                         Name = x.CaseState.Name,
                         DisplayName = x.CaseState.DisplayName
                     },
                     DTag = (x.Tag != null) ? new()
                     {
                         Id = x.Tag.Id.Value,
                         ERPCode = x.Tag.ERPCode.Value,
                         Name = x.Tag.Name,
                         DisplayName = x.Tag.DisplayName
                     } : new(),
                     RecieveDate = Timestamp.FromDateTime
                     (DateTime.SpecifyKind(x.RecieveDate.Value, DateTimeKind.Utc)),
                     Summary = x.Summary ?? String.Empty,
                     Process = new GRPC_BaseClass()
                     {
                         Name = x.ProcessName
                     },
                     CaseId = long.Parse(x.RadNumber),
                     ERPCode = x.ERPCode.Value,
                     WorkItemId = long.Parse(x.WorkItemId),
                     Requestor = new GRPC_BaseClass()
                     {
                         Name = x.Requestor
                     },
                     Task = new GRPC_BaseClass()
                     {
                         Name = x.TaskName
                     }
                 }
                 );

            request.RecordCartables.AddRange(_Recordtable);

            for (int i = 0; i < request.RecordCartables.Count(); i++)
            {
                request.RecordCartables[i].ValidUserActions.AddRange(

                    OutputRequest
                    .Where(x => x.WorkItemId == request.RecordCartables[i].WorkItemId.ToString())
                    .Single().ValidUserActions
                    .Select(
                          y =>
                      new GRPC_BaseClass()
                      {
                          Id = y.Id.Value,
                          ERPCode = y.ERPCode.Value,
                          Name = y.Name,
                          DisplayName = y.DisplayName
                      })
                    );
            }

            return request;
        }
        public override Task<PageCartable> Inbox(PageCartable request, ServerCallContext context)
        {
            return Cartable(request, CartableProperty.Inbox);
        }
        public override Task<PageCartable> Outbox(PageCartable request, ServerCallContext context)
        {
            return Cartable(request, CartableProperty.Outbox);
        }
        public override Task<TableInfo> Sync(TableInfo request, ServerCallContext context)
        {
            TableInfo outputSync = new();
            //iSync.Syncing(request.TableName).GetAwaiter().GetResult();
            return Task.FromResult(outputSync);
        }
        public override async Task<TableInfo> GetAllByName(TableInfo request, ServerCallContext context)
        {
            TableInfo tableInfo = new();
            var TableRecords = await simpleClassRepository.GetAllByName(request.TableInput.Name);
            tableInfo.TableOutput.AddRange(
                TableRecords.Select(x => new GRPC_BaseClass()
                {
                    Id = x.Id.Value,
                    Name = x.Name,
                    DisplayName = x.DisplayName,
                    ERPCode = x.ERPCode.Value
                })
                );
            return tableInfo;
        }
    }
}