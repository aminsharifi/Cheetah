namespace Cheetah.Domain.Common;

public class SimpleClassDTO : BaseEntity
{
    public SimpleClassDTO()
    {
        
    }
    public SimpleClassDTO(Int64 Id, String Name, String DisplayName, Int64? SortIndex, Int64? ERPCode) 
        : base(Id, Name, DisplayName, SortIndex, ERPCode)
    {

    }
}