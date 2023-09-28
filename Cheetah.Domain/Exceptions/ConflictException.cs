using System.Net;

namespace Cheetah.Domain.Exceptions;
public class ConflictException : CustomException
{
    public ConflictException(string message)
        : base(message, null, HttpStatusCode.Conflict) { }
}