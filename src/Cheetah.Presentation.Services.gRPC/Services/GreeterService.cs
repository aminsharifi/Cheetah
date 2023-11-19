namespace Cheetah.Application.Services.gRPC.Services;

public class GreeterService(ILogger<GreeterService> _logger,
        ITableCRUD _isimpleClassRepository, IMapper _imapper,
        ICartable _iCartable, ICopyClass _iCopyClass) : Greeter.GreeterBase
{
    public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
    {
        var helloReply = new HelloReply()
        {
            Message = "Hello " + request.Name
        };

        return Task.FromResult(helloReply);
    }
}