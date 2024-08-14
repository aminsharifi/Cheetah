namespace Cheetah.Sample.Presentation.Services.gRPC.Middleware;

public class ServerLoggerInterceptor(ILogger<ServerLoggerInterceptor> _logger) : Interceptor
{
    public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(
        TRequest request,
        ServerCallContext context,
        UnaryServerMethod<TRequest, TResponse> continuation)
    {
        //LogCall<TRequest, TResponse>(MethodType.Unary, context);

        try
        {
            return await continuation(request, context);
        }
        catch (Exception ex)
        {
            // Note: The gRPC framework also logs exceptions thrown by handlers to .NET Core logging.
            _logger.LogError(ex, $"Error thrown by {context.Method}.");

            var errorResult = await new ExceptionMiddleware().HandleException(ex);

            var log = new LoggerConfiguration()
                    .WriteTo.Console()
                    .WriteTo.File("Serilog.txt")
                    .CreateLogger();

            log.Information("Error Result: {@ErrorResult}", errorResult);


            throw;
        }
    }
}

public class ExceptionMiddleware : IMiddleware
{

    public async Task<Result> HandleException(Exception exception)
    {
        string errorId = Guid.NewGuid().ToString();
        LogContext.PushProperty("ErrorId", errorId);
        LogContext.PushProperty("StackTrace", exception.StackTrace);

        return Result.Success();

        /*

        var errorResult = new ErrorResult
        {
            Source = exception.TargetSite?.DeclaringType?.FullName,
            Exception = exception.Message.Trim(),
            ErrorId = errorId,
            SupportMessage = $"Provide the Error Id: {errorId} to the support team for further analysis."
        };
        errorResult.Messages.Add(exception.Message);

        if (exception is not CustomException && exception.InnerException != null)
        {
            while (exception.InnerException != null)
            {
                exception = exception.InnerException;
            }
        }

        switch (exception)
        {
            case CustomException e:
                errorResult.StatusCode = (int)e.StatusCode;
                if (e.ErrorMessages is not null)
                {
                    errorResult.Messages = e.ErrorMessages;
                }

                break;

            case KeyNotFoundException:
                errorResult.StatusCode = (int)HttpStatusCode.NotFound;
                break;

            default:
                errorResult.StatusCode = (int)HttpStatusCode.InternalServerError;
                break;
        }

        return errorResult;

        */
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        try
        {
            await next(context);
        }
        catch (Exception exception)
        {
            var errorResult = await HandleException(exception);
            Log.Error($"{errorResult.ValidationErrors.FirstOrDefault()} Request failed with Status Code {context.Response.StatusCode} and Error Id {0}.");
            var response = context.Response;
            if (!response.HasStarted)
            {
                response.ContentType = "application/json";
                //response.StatusCode = errorResult.StatusCode;
                response.StatusCode = 1;
                await response.WriteAsync(JsonConvert.SerializeObject(errorResult));
            }
            else
            {
                Log.Warning("Can't write error response. Response has already started.");
            }
        }
    }
}

