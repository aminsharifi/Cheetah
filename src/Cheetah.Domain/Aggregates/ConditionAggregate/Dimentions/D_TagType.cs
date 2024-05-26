namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_TagType : BaseEntity
{
    public D_TagType()
    {
        
    }
    public D_TagType(Int64 id, String name, String displayName, Int64 sortIndex, Int64 eRPCode) : base(id, name, displayName, sortIndex, eRPCode)
    {

    }
}