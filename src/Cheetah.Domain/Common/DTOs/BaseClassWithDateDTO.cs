namespace Cheetah.Domain.Common.DTOs;

public class BaseClassWithDateDTO : BaseClassDTO
{
    public DateTimeOffset? Created { get; set; }
    public DateTimeOffset? LastModified { get; set; }
}
