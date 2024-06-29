namespace Cheetah.Application.Business.DTOs.Entity;

public class SyncLink_Request
{
    public BaseClassWithNameDTO? Base { get; set; }
    public List<SimpleLinkClassDTO>? Records { get; set; }
    public long? Crud { get; set; }
}
