using Ardalis.Result;

namespace Cheetah.Domain;

public class CheetahResult<T>
{
    public  Result<T> Result { get; set; }
    public SimpleClassDTO SimpleClassDTO { get; set; } = new();
}
public class CheetahResult
{
    public Result Result { get; set; }
    public SimpleClassDTO SimpleClassDTO { get; set; } = new();
}