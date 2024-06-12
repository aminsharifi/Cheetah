namespace Cheetah.Application.Business.Entity;

public class SyncEntity_Request
{
    public BaseClassWithNameDTO? Base { get; set; }
    public List<BaseClassWithNameAndDateDTO>? Records { get; set; }
    public long? Crud { get; set; }
}
