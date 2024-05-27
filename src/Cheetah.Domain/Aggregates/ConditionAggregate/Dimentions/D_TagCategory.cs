namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_TagCategory : BaseEntity
{
    public D_TagCategory()
    {

    }
    public D_TagCategory(Int64 id, String name, String displayName, Int64 sortIndex, Int64 eRPCode) : base(id, name, displayName, sortIndex, eRPCode)
    {

    }
}