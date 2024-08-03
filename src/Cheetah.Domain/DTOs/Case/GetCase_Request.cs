using Cheetah.Domain.Common.DTOs;

namespace Cheetah.Domain.DTOs.Case;

public class GetCase_Request
{
    public BaseClassDTO? Case { get; set; }
    public BaseClassWithNameDTO? CaseState { get; set; }
    public BaseClassWithNameDTO? Process { get; set; }
}
