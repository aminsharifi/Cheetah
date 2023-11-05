using Cheetah.Domain.Data;
using FluentResults;

namespace Cheetah.Domain;

public class CheetahResult<T>
{
    public  Result<T> Result { get; set; }
    public  SimpleClassDTO SimpleClassDTO { get; set; }
}
public class CheetahResult
{
    public Result Result { get; set; }
    public SimpleClassDTO SimpleClassDTO { get; set; }
}