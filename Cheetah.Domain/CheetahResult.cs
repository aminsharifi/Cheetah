using Cheetah.Domain.Data;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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