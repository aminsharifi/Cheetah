namespace Cheetah.Domain.Entities.Dimentions;

public partial class D_Operand : BaseEntity
{
    public D_Operand()
    {
        
    }
    public D_Operand(Int64 id, String name, String displayName, Int64 sortIndex, Int64 eRPCode) : base(id, name, displayName, sortIndex, eRPCode)
    {

    }
}