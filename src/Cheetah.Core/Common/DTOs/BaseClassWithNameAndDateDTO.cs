namespace Cheetah.Core.Common.DTOs;

public class BaseClassWithNameAndDateDTO : BaseClassWithDateDTO
{
    public string? Name { get; set; }
    public string? DisplayName { get; set; }
}
