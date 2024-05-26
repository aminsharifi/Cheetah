namespace Cheetah.Domain.Common;

public class SimpleClassDTO : BaseEntity
{
    public SimpleClassDTO()
    {
        
    }
    public SimpleClassDTO(Int64 id, String name, String displayName, Int64? sortIndex, Int64? eRPCode) : base(id, name, displayName, sortIndex, eRPCode)
    {

    }
}