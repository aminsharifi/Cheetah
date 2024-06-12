namespace Cheetah.Application.Business.Entity;

public class SyncLink_Request
{
    public BaseClassWithNameDTO? Base { get; set; }
    public List<SimpleLinkClassDTO>? Records { get; set; }
    public long? Crud { get; set; }
}
