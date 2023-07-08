using AutoMapper;
using Cheetah_Business;
using Cheetah_Business.Data;
using Cheetah_Business.Dimentions;
using Cheetah_Business.Facts;
using Cheetah_Business.Repository;
using Cheetah_DataAccess.Data;
using Grpc.Core;

namespace Cheetah_GrpcService.Services
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        private readonly ISimpleClassRepository simpleClassRepository;
        private readonly IMapper _mapper;

        public GreeterService(ILogger<GreeterService> logger, ISimpleClassRepository iP_ParameterListRepository, IMapper mapper)
        {
            _logger = logger;
            this._mapper = mapper;
            this.simpleClassRepository = iP_ParameterListRepository;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            var helloReply = new HelloReply()
            {
                Message = "Hello " + request.Name
            };

            return Task.FromResult(helloReply);
        }
    }

    public class RequestService : Request.RequestBase
    {
        private readonly ILogger<GreeterService> _logger;
        private readonly ISimpleClassRepository simpleClassRepository;
        private readonly IMapper _mapper;
        protected ApplicationDbContext _db;
        public RequestService(ILogger<GreeterService> logger,
            ApplicationDbContext db,
            ISimpleClassRepository iP_ParameterListRepository, IMapper mapper)
        {
            _logger = logger;
            _db = db;
            this._mapper = mapper;
            this.simpleClassRepository = iP_ParameterListRepository;
        }

        public override Task<Brief_Output_Request> CreateRequest(Create_Input_Request request, ServerCallContext context)
        {
            var f_Request = new F_Request();

            f_Request.RQT_Creator = new() { PName = request.CreatorPName };
            f_Request.RQT_Requestor = new() { PName = request.RequestorPName };
            f_Request.RQT_Process = new() { PName = request.ProcessPName };
            f_Request.PERPCode = request.PERPCode;

            f_Request = simpleClassRepository.CreateRequestAsync(f_Request)
                .GetAwaiter().GetResult();

            var output_Request = new Brief_Output_Request();

            output_Request.ProcessState =
                new()
                {
                    Id = f_Request.RQT_ProcessState.Id.Value,
                    PName = f_Request.RQT_ProcessState.PName,
                    PDisplayName = f_Request.RQT_ProcessState.PDisplayName
                };

            output_Request.Id = f_Request.Id.Value;

            return Task.FromResult(output_Request);
        }
        public override Task<Brief_Output_Request> PerformRequest(Perform_Input_Request request, ServerCallContext context)
        {
            var f_Request = new F_Request();

            f_Request.Id = request.AssignmentId;

            //if (GeneralRequest.RQT_CurrentAssignment.Id != request.RQT_Current_Review.APV_AssignmentId)

            f_Request = simpleClassRepository.PerformRequestAsync(f_Request)
            .GetAwaiter().GetResult();

            var output_Request = new Brief_Output_Request();

            output_Request.Id = f_Request.Id.Value;

            return Task.FromResult(output_Request);
        }
        public override Task<DetailOutput_Request> GetCase(GetCase_Input_Request request, ServerCallContext context)
        {
            F_Request f_Request = new();

            f_Request.Id = request.Id;

            if (request.PERPCode > 0)
                f_Request.PERPCode = request.PERPCode;

            if (!String.IsNullOrEmpty(request.ProcessName))
                f_Request.RQT_Process = _db.D_Processes.Single(x => x.PName == request.ProcessName);

            f_Request = simpleClassRepository.GetCaseAsync(f_Request)
                .GetAwaiter().GetResult();

            DetailOutput_Request output_Request = new();

            output_Request.Id = f_Request.Id.Value;

            output_Request.ProcessName = f_Request.RQT_Process.PName;

            output_Request.PERPCode = f_Request.PERPCode.Value;

            output_Request.ProcessState =
                new()
                {
                    Id = f_Request.RQT_ProcessState.Id.Value,
                    PName = f_Request.RQT_ProcessState.PName,
                    PDisplayName = f_Request.RQT_ProcessState.PDisplayName
                };

            output_Request.CurrentAssignments = new GRPC_UserAssignment();
            output_Request.CurrentAssignments.Endorsement = new()
            {
                Id = f_Request.RQT_CurrentAssignment.PRM_Endorsement.Id.Value,
                PName = f_Request.RQT_CurrentAssignment.PRM_Endorsement.PName,
                PDisplayName = f_Request.RQT_CurrentAssignment.PRM_Endorsement.PDisplayName
            };

            //output_Request.CurrentAssignments.UserAssignments.AddRange
            //    (
            //        f_Request.RQT_CurrentAssignment.PRM_UserAssignments
            //        .Select(x => new GRPC_BaseClass()
            //        {
            //            Id = x.Id.Value,
            //            PName = x.UA_User.PName
            //        }
            //        )
            //    );


            var assignments = f_Request.RQT_Assignments.ToList();

            output_Request.AllAssignments.AddRange(assignments
            .Select(p => new GRPC_UserAssignment()
            {
                Endorsement =
                new()
                {
                    Id = p.PRM_Endorsement.Id.Value,
                    PName = p.PRM_Endorsement.PName,
                    PDisplayName = p.PRM_Endorsement.PDisplayName
                }

            }));

            //output_Request.AllAssignments.ToList()
            //    .ForEach(x =>
            //    x.UserAssignments.AddRange(
            //        assignments.First(y => y.PRM_EndorsementId == x.Endorsement.Id).PRM_UserAssignments
            //        .Select(z =>
            //            new GRPC_BaseClass()
            //            {
            //                Id = z.Id.Value,
            //                PName = z.UA_User.PName,
            //                PDisplayName = z.UA_User.PDisplayName
            //            }
            //        )
            //    ));

            return Task.FromResult(output_Request);
        }
        public Task<PageCartable> Cartable(PageCartable request, CartableProperty cartableProperty)
        {
            var cartableDTO = new CartableDTO()
            {
                Username = request.Username,
                ProcessName = request.ProcessName
            };

            var OutputRequest = (cartableProperty == CartableProperty.Inbox) ?
                simpleClassRepository.Inbox(cartableDTO).GetAwaiter().GetResult() :
                simpleClassRepository.Outbox(cartableDTO).GetAwaiter().GetResult();

            request.RecordCartables.AddRange(
                OutputRequest.Select(
                    x => new RecordCartable()
                    {
                        CreateDate = ((DateTimeOffset)x.CreateDate).ToUnixTimeSeconds(),
                        PCreateDate = x.PCreateDate,
                        DTag = (x.Tag is not null) ? new()
                        {
                            Id = x.Tag.Id.Value,
                            PName = x.Tag.PName,
                            PDisplayName = x.Tag.PDisplayName
                        } : new(),
                        RecieveDate = ((DateTimeOffset)x.RecieveDate).ToUnixTimeSeconds(),
                        PRecieveDate = x.PRecieveDate,
                        Summary = x.Summary ?? String.Empty,
                        ProcessName = x.ProcessName,
                        RadNumber = x.RadNumber,
                        Requestor = x.Requestor,
                        TaskName = x.TaskName
                    }
                    )
                );

            return Task.FromResult(request);
        }
        public override Task<PageCartable> Inbox(PageCartable request, ServerCallContext context)
        {
            return Cartable(request, CartableProperty.Inbox);
        }
        public override Task<PageCartable> Outbox(PageCartable request, ServerCallContext context)
        {
            return Cartable(request, CartableProperty.Outbox);
        }
    }
}