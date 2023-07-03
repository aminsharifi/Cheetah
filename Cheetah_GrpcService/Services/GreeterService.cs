using AutoMapper;
using Cheetah_Business.Dimentions;
using Cheetah_Business.Links;
using Cheetah_Business.Repository;
using Cheetah_Business.Virtuals;
using Cheetah_GrpcService;
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
        public RequestService(ILogger<GreeterService> logger, ISimpleClassRepository iP_ParameterListRepository, IMapper mapper)
        {
            _logger = logger;
            this._mapper = mapper;
            this.simpleClassRepository = iP_ParameterListRepository;
        }
        public override Task<Output_Request> CreateRequest(Create_Input_Request request, ServerCallContext context)
        {
            var f_Request = new Cheetah_Business.Facts.F_Request();

            f_Request.RQT_Creator = new D_User() { PName = request.RQTCreatorPName };
            f_Request.RQT_Requestor = new D_User() { PName = request.RQTRequestorPName };
            f_Request.RQT_Process = new D_Process() { PName = request.RQTProcessPName };
            f_Request.PERPCode = request.PERPCode;

            f_Request = simpleClassRepository.CreateRequestAsync(f_Request)
                .GetAwaiter().GetResult();

            var output_Request = new Output_Request();

            output_Request.Id = f_Request.Id.Value;

            output_Request.ProcessState = "در جریان";

            output_Request.CurrentAssignments.AddRange(
                f_Request.RQT_CurrentAssignment.PRM_UserAssignments
                .Select(x => new GRPC_UserAssignment()
                {
                    Endorsement =
                    new GRPC_BaseClass()
                    {
                        Id = x.UA_Assignment.PRM_Endorsement.PIndex.Value,
                        PName = x.UA_Assignment.PRM_Endorsement.PName,
                        PDisplayName = x.UA_Assignment.PRM_Endorsement.PDisplayName
                    },
                    UserAssignment =
                    new GRPC_BaseClass()
                    {
                        Id = x.Id.Value,
                        PName = x.UA_User.PName
                    }
                }));

            output_Request.AllAssignments.AddRange(f_Request.RQT_Assignments
                .SelectMany(p => p.PRM_UserAssignments,
                (parent, child) => new GRPC_UserAssignment()
                {
                    UserAssignment =
                    new GRPC_BaseClass()
                    {
                        Id = child.Id.Value,
                        PName = child.UA_User.PName
                    },

                    Endorsement =
                    new GRPC_BaseClass()
                    {
                        Id = parent.PRM_Endorsement.PIndex.Value,
                        PName = parent.PRM_Endorsement.PName,
                        PDisplayName = parent.PRM_Endorsement.PDisplayName
                    }
                }));

            return Task.FromResult(output_Request);
        }
        public override Task<Output_Request> PerformRequest(Perform_Input_Request request, ServerCallContext context)
        {
            var tb1 = simpleClassRepository.GetAllTableName(nameof(Cheetah_Business.Dimentions))
                .GetAwaiter().GetResult();

            var helloReply = new Output_Request()
            {
                //Message = tb1.First().Value + " " + request.Name
            };

            return Task.FromResult(helloReply);
        }
    }
}